using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class ShipmentDialog : BaseObjectDialog
    {
        private int capacity = 0;
        public ShipmentDialog() : base()
        {
            InitializeComponent();
        }
        public ShipmentDialog(BaseObject baseObject) : base(baseObject)
        {
            Shipment shipment = (Shipment)baseObject;
            InitializeComponent();
            columns = new List<List<String>> { new List<String> { "Checked", "Id", "Num", "DtBeg", "Weight", "Customer", "Address", "id_shipment" } };
            comboSource = new List<String> { "st_vehicle_list_combo", "st_person_list_combo", "st_person_list_combo", "st_person_list_combo" };
            comboValueMember = new List<String> { "id", "id", "id", "id" };
            comboDisplayMember = new List<String> { "vehicle", "person", "person", "person" };
            comboParameters = new List<Dictionary<String, object>> { new Dictionary<String, object> { { "@id", shipment.IdVehicle }, { "@id_status", (int)VehicleStatus.Free } },
                                                                     new Dictionary<String, object> { { "@id", shipment.IdDriver }, { "@id_status", (int)PersonStatus.Free }, { "@id_position", (int)PersonPosition.Driver } },
                                                                     new Dictionary<String, object> { { "@id", shipment.IdKeeper }, { "@id_status", (int)PersonStatus.Free }, { "@id_position", (int)PersonPosition.Keeper } },
                                                                     new Dictionary<String, object> { { "@id", shipment.IdAgent }, { "@id_status", (int)PersonStatus.Free }, { "@id_position", (int)PersonPosition.Agent } } };
        }
        protected override void SetGrids()
        {
            base.SetGrids();
            gridDetail.DataSource = null;
            if (((Shipment)baseObject).ChildList.Count > 0 && ((Shipment)baseObject).ChildList[0].Count > 0) gridDetail.DataSource = ((Shipment)baseObject).ChildList[0].ConvertAll<ShipmentDetail>(delegate (BaseObject baseObject) { return (ShipmentDetail)baseObject; });
        }

        protected override void SetFields()
        {
            Shipment shipment = (Shipment)baseObject;
            if (shipment.Id == 0) Text = "Новая отгрузка";
            else Text = String.Format("Отгрузка: № {0}; статус: {1}", shipment.Num, shipment.Status);

            txtID.Text = shipment.Id.ToString();
            txtNum.Text = shipment.Num;
            dtDtBegin.Value = dtDtBeginTime.Value = shipment.DtBeg;

            if (shipment.DtEnd.HasValue)
            {
                dtDtEnd.Format = DateTimePickerFormat.Short;
                dtDtEndTime.Format = DateTimePickerFormat.Time;
                dtDtEnd.Value = dtDtEndTime.Value = shipment.DtEnd.Value;
            }
            else
            {
                dtDtEnd.Format = dtDtEndTime.Format = DateTimePickerFormat.Custom;
                dtDtEnd.CustomFormat = " ";
                dtDtEndTime.CustomFormat = " ";
            }

            cbVehicle.SelectedValue = shipment.IdVehicle;
            cbDriver.SelectedValue = shipment.IdDriver;
            cbAgent.SelectedValue = shipment.IdAgent;
            cbKeeper.SelectedValue = shipment.IdKeeper;
        }

        protected override bool GetFields(out string errMessage)
        {
            errMessage = "";
            Shipment shipment = (Shipment)baseObject;
            shipment.Num = txtNum.Text;
            shipment.DtBeg = new DateTime(dtDtBegin.Value.Year, dtDtBegin.Value.Month, dtDtBegin.Value.Day, dtDtBeginTime.Value.Hour, dtDtBeginTime.Value.Minute, dtDtBeginTime.Value.Second);
            if (dtDtEnd.Format == DateTimePickerFormat.Custom)
            {
                shipment.DtEnd = null;
            }
            else
            {
                shipment.DtEnd = new DateTime(dtDtEnd.Value.Year, dtDtEnd.Value.Month, dtDtEnd.Value.Day, dtDtEndTime.Value.Hour, dtDtEndTime.Value.Minute, dtDtEndTime.Value.Second);
            }
            if (cbVehicle.SelectedValue == null)
            {
                errMessage = "Не выбран автомобиль";
                return false;
            }
            if (cbDriver.SelectedValue == null)
            {
                errMessage = "Не выбран водитель";
                return false;
            }
            if (cbAgent.SelectedValue == null)
            {
                errMessage = "Не выбран экспедитор";
                return false;
            }
            if (cbKeeper.SelectedValue == null)
            {
                errMessage = "Не выбран кладовщик";
                return false;
            }
            shipment.IdVehicle = (int)(cbVehicle.SelectedValue);
            shipment.IdDriver = (int)(cbDriver.SelectedValue);
            shipment.IdAgent = (int)(cbAgent.SelectedValue);
            shipment.IdKeeper = (int)(cbKeeper.SelectedValue);
            return true;
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            baseObject.SaveChildren = true;
            SaveObject();
        }

        private void OnVehicleSelectionChanged(object sender, EventArgs e)
        {
            if (cbVehicle.SelectedItem == null)
            {
                capacity = 0;
            }
            else
            {
                DataRowView selectedRow = (DataRowView)cbVehicle.SelectedItem;
                capacity = selectedRow.Row["capacity"] == DBNull.Value ? 0 : (int)selectedRow.Row["capacity"];
            }
            txtCapacity.Text = capacity == 0 ? "" : capacity.ToString();
            CheckWeight();
        }

        private void CheckWeight()
        {
            if (capacity == 0) return;
            Shipment shipment = (Shipment)baseObject;
            if (shipment.TotalWeight > capacity)
            {
                MessageBox.Show("Вес выбранных заказов превышают грузоподъемность автомобиля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OnDirtyStateChanged(object sender, EventArgs e)
        {
            gridDetail.CurrentCellDirtyStateChanged -= OnDirtyStateChanged;
            gridDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CheckWeight();
            gridDetail.CurrentCellDirtyStateChanged += OnDirtyStateChanged;
        }

        private void OnForwardClick(object sender, EventArgs e)
        {

        }
    }
}
