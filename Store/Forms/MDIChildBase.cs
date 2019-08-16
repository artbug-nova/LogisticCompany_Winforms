using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Store
{
    public partial class MDIChildBase : Form
    {
        protected ToolStrip toolStrip = null;
        protected Pen selPen = new Pen(SystemColors.Highlight, 2);

        protected DataSet dataSet = new DataSet();
        protected List<bool> execute = null;
        protected List<String> procedure = null;
        protected List<String> tables = null;
        protected List<String> queries = null;
        protected List<List<String>> columns = null;
        protected List<BindingSource> bindSources = null;
        protected List<SqlDataAdapter> adapters = null;
        protected List<Dictionary<String, object>> parameters = null;

        protected Type parentType = null;  //Класс, отображаемый в заглавном окне, заполняется в конструкторе производных классов

        protected ErrCode errCode = ErrCode.ErrOK;
        protected String errMessage = "";

        protected Thread thread = null;

        public ErrCode ErrCode { get { return errCode; } }
        public String ErrMessage { get { return errMessage; } }

        public MDIChildBase()
        {
            InitializeComponent();
        }

        public MDIChildBase(MDIForm mdiForm)
        {
            InitializeComponent();
            this.MdiParent = mdiForm;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                ((MDIForm)MdiParent).ChangeWindowList();
            }
            catch { }
            SetGridParameters();
            SetProcedureParameters();
            if (execute != null) LoadData();
        }

        protected virtual void SetGridParameters()
        { }
        protected virtual void SetProcedureParameters()
        { }
        protected virtual void ExecuteQueries()
        { }
        protected virtual void SetFilters()
        { }
        protected virtual void FinalProc()
        { }
        protected virtual void SortGrids()
        { }
        protected virtual void SetControls(bool _on)
        {
            ((MDIForm)MdiParent).SetControls(_on);

        }


        protected void SetDataSources()
        {
            Control _control = null;
            for (int i = bindSources.Count - 1; i >= 0;  i--)
            {
                _control = FindByTag(i, typeof(DataGridView),  this);
                if (_control != null)
                {
                    List<String> _columns = null;
                    if ((_control is DataGridView) && (_control.Tag != null))
                    {
                        ((DataGridView)_control).RowPostPaint += OnRowPostpaint;
                        ((DataGridView)_control).DataError += OnDataError;
                        ((DataGridView)_control).AutoGenerateColumns = false;
                        _columns = columns[(int)_control.Tag];
                        for (int j = 0; j < _columns.Count; j++)
                        {
                            ((DataGridView)_control).Columns[j].DataPropertyName = _columns[j];
                        }
                        bindSources[(int)_control.Tag].DataSource = dataSet;
                        bindSources[(int)_control.Tag].DataMember = queries[(int)_control.Tag] != ""
                                                                    ? queries[(int)_control.Tag]
                                                                    : tables[(int)_control.Tag];
                        ((DataGridView)_control).DataSource = bindSources[(int)_control.Tag];
                    }
                }
            }
        }


        protected void LoadData()
        {
            thread = new Thread(LoadMethod);
            thread.Start();
        }


        private void LoadMethod()
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate { SetControls(false); });
                SetGridParameters();
                SetProcedureParameters();
                RetrieveData();
                ExecuteQueries();
                FinalProc();
                this.BeginInvoke((MethodInvoker)delegate { SetDataSources(); SetFilters(); SortGrids(); SetControls(true); });
            }
            catch (ThreadAbortException e) { }
            catch (Exception e)
            {
                this.BeginInvoke((MethodInvoker)delegate 
                {
                    this.MdiParent.Activate(); SetControls(true); MessageBox.Show("Ошибка загрузки данных: " + e.Message,
                                                                                  "Внимание",
                                                                                  MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Error);
                });
            }
        }



        protected void RetrieveForm(int index = 0)
        {
            if (bindSources == null) return;
            Control _control = null;
            for (int i = 0; i < bindSources.Count; i++)
            {
                _control = FindByTag(i, typeof(DataGridView), this);
                if (_control != null) ((DataGridView)_control).DataSource = null;
            }
            LoadData();
            //SelectRow(index);
        }

        protected void SelectRow(int index = 0)
        {
            Control _control = FindByTag(0, typeof(DataGridView), this);
            if (_control != null)
            {
                if (((DataGridView)_control).Rows.Count == 0) return;
                foreach (DataGridViewRow _row in ((DataGridView)_control).Rows)
                {
                    if ((int)_row.Cells[0].Value == index)
                    {
                        _row.Selected = true;
                        return; ;
                    }
                }
                ((DataGridView)_control).Rows[0].Selected = true;
            }
        }



        protected void RetrieveData()
        {
            dataSet.Tables.Clear();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = SQLConnection.GetConnection();
            for (int i = 0; i < execute.Count; i++)
            {
                if (execute[i])
                {
                    comm.CommandText = procedure[i];
                    comm.Parameters.Clear();
                    if (parameters != null && parameters.Count > i && parameters[i] != null)
                    {
                        foreach (KeyValuePair<String, object> _pair in parameters[i])
                        {
                            comm.Parameters.AddWithValue(_pair.Key, _pair.Value);
                        }
                    }
                    adapters[i].SelectCommand = comm;
                    adapters[i].Fill(dataSet, procedure[i]);
                }
            }
        }



        protected Control FindByTag(int tag, Type typeControl, Control control)
        {
            foreach (Control _control in control.Controls)
            {
                if (_control.GetType() == typeControl && _control.Tag != null && _control.Tag.GetType() == typeof(int) && (int)_control.Tag == tag) return _control;
            }
            Control tmpControl = null;
            foreach (Control _control in control.Controls)
            {
                tmpControl = FindByTag(tag, typeControl, _control);
                if (tmpControl != null) return tmpControl;
            }
            return null;
        }
        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answ;
            if (thread != null && thread.ThreadState == ThreadState.Running)
            {
                answ = MessageBox.Show("Продолжается загрузка данных, Вы желаете прервать операцию?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (answ == DialogResult.Yes)
                {
                    if (thread.ThreadState == ThreadState.Running) thread.Abort();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        protected void OnRowPostpaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewElementStates state = e.State & DataGridViewElementStates.Selected;
            if (state == DataGridViewElementStates.Selected)
            {
                Graphics graph = e.Graphics;
                graph.DrawRectangle(selPen, e.RowBounds.Left + 3, e.RowBounds.Top + 1, ((DataGridView)sender).PreferredSize.Width - 38, e.RowBounds.Height - 3);
            }
        }
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            ((MDIForm)MdiParent).ChangeWindowList(this);
        }
        private void OnActivate(object sender, EventArgs e)
        {
            if (toolStrip != null) ((MDIForm)MdiParent).SetToolStrip(toolStrip);
            RetrieveForm(0);
        }
        private void OnDeactivate(object sender, EventArgs e)
        {
            if (toolStrip != null) ((MDIForm)MdiParent).RemoveToolStrip(toolStrip);
        }

        protected void OnAddClick(object sender, EventArgs e)
        {
            ShowDialog(0);
        }
        protected void OnEditClick(object sender, EventArgs e)
        {
            Control control = FindByTag(0, typeof(DataGridView), this);
            if (control == null)
            {
                MessageBox.Show("Поле со списком объектов отсутствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridView grid = (DataGridView)control;
            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Объект не выбран, открытие формы невозможно", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowDialog((int)grid.SelectedRows[0].Cells[0].Value);
        }

        protected void OnDeleteClick(object sender, EventArgs e)
        {
            Control control = FindByTag(0, typeof(DataGridView), this);
            if (control == null)
            {
                MessageBox.Show("Поле со списком объектов отсутствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridView grid = (DataGridView)control;
            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Объект не выбран, удаление невозможно", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)grid.SelectedRows[0].Cells[0].Value;
            BaseObject baseObject = (BaseObject)parentType.GetConstructor(new Type[] { typeof(int), typeof(BaseObject), typeof(BaseObject), typeof(bool) }).Invoke(new object[] { id, null, null, true });
            if (baseObject.ErrCode != ErrCode.ErrOK)
            {
                MessageBox.Show("Ошибка загрузки данных: " + baseObject.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult answ = MessageBox.Show("Вы уверены, что хотите удалить выбранный объект?\nВосстановление будет невозможно", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (answ == DialogResult.Yes)
            {
                baseObject.DeleteFromDB();
                if (baseObject.ErrCode != ErrCode.ErrOK)
                {
                    MessageBox.Show("Ошибка удаления объекта: " + baseObject.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (execute != null)
                {
                    RetrieveForm(baseObject.Id); //Здесь надо включить обновление формы
                }
            }
        }

        private void ShowDialog(int id, BaseObject parent = null, BaseObject child = null)
        {
            try
            {
                BaseObject baseObject = (BaseObject)parentType.GetConstructor(new Type[] { typeof(int), typeof(BaseObject), typeof(BaseObject), typeof(bool) }).Invoke(new object[] { id, parent, child, true });
                if (baseObject.ErrCode != ErrCode.ErrOK)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + baseObject.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BaseObjectDialog baseDialog = (BaseObjectDialog)baseObject.DialogType.GetConstructor(new Type[] { typeof(BaseObject) }).Invoke(new object[] { baseObject });
                baseDialog.ShowDialog(this);
                if (baseDialog.DialogResult == DialogResult.OK)
                {
                    if (execute != null)
                    {
                        RetrieveForm(baseObject.Id); //Здесь надо включить обновление формы
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия формы: " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void OnDataError(object sender, DataGridViewDataErrorEventArgs e)
        { }

    }
}
