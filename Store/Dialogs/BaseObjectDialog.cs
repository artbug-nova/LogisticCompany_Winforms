using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class BaseObjectDialog : Form
    {
        protected BaseObject baseObject = null;
        protected List<List<String>> columns = null;
        protected List<String> comboSource = null;
        protected List<Dictionary<String, object>> comboParameters = null;
        protected List<String> comboValueMember = null;
        protected List<String> comboDisplayMember = null;

        protected Pen selPen = new Pen(SystemColors.Highlight, 2);
        public BaseObjectDialog()
        {
            InitializeComponent();
        }

        public BaseObjectDialog(BaseObject baseObject)
        {
            InitializeComponent();
            this.baseObject = baseObject;
        }
        protected void OnLoad(object sender, EventArgs e)
        {
            try
            {
                SetCombo();
                SetGrids();
                SetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия формы: " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }
        }
        protected virtual void SetCombo()
        {
            if (comboSource == null) return;
            Control control = null;
            String source = "";
            DataTable table = null;
            SqlCommand command = new SqlCommand();
            command.Connection = SQLConnection.GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = null;

            for (int index = 0; index < comboSource.Count; index++)
            {
                source = comboSource[index];
                control = FindByTag(index, typeof(ComboBox), this);
                if (control != null)
                {
                    if ((control is ComboBox) && (control.Tag != null))
                    {
                        command.CommandText = source;
                        command.Parameters.Clear();
                        if (comboParameters != null && comboParameters[index] != null)
                        {
                            foreach (KeyValuePair<String, object> pair in comboParameters[index])
                            {
                                command.Parameters.AddWithValue(pair.Key, pair.Value);
                            }
                        }
                        table = new DataTable();
                        adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                        ((ComboBox)control).ValueMember = comboValueMember[index];
                        ((ComboBox)control).DisplayMember = comboDisplayMember[index];
                        ((ComboBox)control).DataSource = table;
                        ((ComboBox)control).DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }
        }
        protected virtual void SetGrids()
        {
            if (columns == null) return;
            int index = 0;
            Control control = null;
            foreach (List<String> _columns in columns)
            {
                index = columns.IndexOf(_columns);
                control = FindByTag(index, typeof(DataGridView), this);
                if (control != null)
                {
                    if ((control is DataGridView) && (control.Tag != null))
                    {
                        ((DataGridView)control).RowPostPaint += OnRowPostpaint;
                        ((DataGridView)control).AutoGenerateColumns = false;
                        for (int j = 0; j < _columns.Count; j++)
                        {
                            ((DataGridView)control).Columns[j].DataPropertyName = _columns[j];
                        }
                    }
                }
            }
        }
        protected virtual void SetFields()
        { }
        protected virtual bool GetFields(out String errMessage)
        {
            errMessage = "";
            return true;
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
        private void OnCancelClick(object sender, EventArgs e)
        {
            baseObject.RestoreChildren();
            DialogResult = DialogResult.Cancel;
        }

        protected void SaveObject()
        {
            try
            {
                String errMessage = "";
                bool result = GetFields(out errMessage);
                if (!result)
                {
                    MessageBox.Show("Некорректные данные: " + errMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (baseObject.Parent == null)
                {
                    baseObject.SaveToDB();
                    if (baseObject.ErrCode != ErrCode.ErrOK)
                    {
                        MessageBox.Show("Ошибка сохранения: " + baseObject.ErrMessage, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        protected void OnAddClick(object sender, EventArgs e)
        {
            int indexGrid = ((Button)sender).Tag == null ? -1 : (int)(((Button)sender).Tag);
            if (indexGrid == -1) return;
            BaseObject childObject = (BaseObject)baseObject.GetChildType(indexGrid).GetConstructor(new Type[] { typeof(int), typeof(BaseObject), typeof(BaseObject), typeof(bool) }).Invoke(new object[] { 0, baseObject, null, true });
            DialogResult result = ShowDialog(childObject);
            if (result == DialogResult.OK)
            {
                baseObject.ChildList[indexGrid].Add(childObject);
                RetrieveGrid();
            }
        }
        protected void OnEditClick(object sender, EventArgs e)
        {
            int indexGrid = ((Button)sender).Tag == null ? -1 : (int)(((Button)sender).Tag);
            if (indexGrid == -1) return;
            Control control = FindByTag(indexGrid, typeof(DataGridView), this);
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
            DialogResult result = ShowDialog(baseObject.ChildList[indexGrid][grid.SelectedRows[0].Index]);
            if (result == DialogResult.OK)
            {
                RetrieveGrid();
            }
        }

        protected void OnDeleteClick(object sender, EventArgs e)
        {
            int indexGrid = ((Button)sender).Tag == null ? -1 : (int)(((Button)sender).Tag);
            if (indexGrid == -1) return;
            Control control = FindByTag(indexGrid, typeof(DataGridView), this);
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
            baseObject.ChildList[indexGrid].Remove(baseObject.ChildList[indexGrid][grid.SelectedRows[0].Index]);
            RetrieveGrid();
        }

        protected DialogResult ShowDialog(BaseObject baseObject)
        {
            try
            {
                BaseObjectDialog baseDialog = (BaseObjectDialog)baseObject.DialogType.GetConstructor(new Type[] { typeof(BaseObject) }).Invoke(new object[] { baseObject });
                return baseDialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия формы: " + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }
        }

        protected virtual void RetrieveGrid()
        { }
    }
}
