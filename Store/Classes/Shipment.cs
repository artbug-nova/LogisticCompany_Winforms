using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Store
{
    public sealed class Shipment : BaseObject
    {
        public int IdVehicle { get { return fields.ContainsKey("id_vehicle") ? (int)fields["id_vehicle"] : 0; } set { if (fields.ContainsKey("id_vehicle")) fields["id_vehicle"] = value; else fields.Add("id_vehicle", value); } }
        public int IdDriver { get { return fields.ContainsKey("id_driver") ? (int)fields["id_driver"] : 0; } set { if (fields.ContainsKey("id_driver")) fields["id_driver"] = value; else fields.Add("id_driver", value); } }
        public int IdAgent { get { return fields.ContainsKey("id_agent") ? (int)fields["id_agent"] : 0; } set { if (fields.ContainsKey("id_agent")) fields["id_agent"] = value; else fields.Add("id_agent", value); } }
        public int IdKeeper { get { return fields.ContainsKey("id_keeper") ? (int)fields["id_keeper"] : 0; } set { if (fields.ContainsKey("id_keeper")) fields["id_keeper"] = value; else fields.Add("id_keeper", value); } }
        public DateTime DtBeg { get { return fields.ContainsKey("dt_begin") ? (DateTime)fields["dt_begin"] : DateTime.Now; } set { if (fields.ContainsKey("dt_begin")) fields["dt_begin"] = value; else fields.Add("dt_begin", value); } }
        public DateTime? DtEnd { get { return fields.ContainsKey("dt_end") ? (DateTime?)fields["dt_end"] : null; } set { if (fields.ContainsKey("dt_end")) fields["dt_end"] = value; else fields.Add("dt_end", value); } }
        public String Num { get { return fields.ContainsKey("num") ? fields["num"] as String : ""; } set { if (fields.ContainsKey("num")) fields["num"] = value; else fields.Add("num", value); } }
        public int IdStatus { get { return fields.ContainsKey("id_status") ? (int)fields["id_status"] : 1; } set { status = GetSpravValue("st_shipment_status_get_by_id", value) as String; if (fields.ContainsKey("id_status")) fields["id_status"] = value; else fields.Add("id_status", value); } }
        public int TotalWeight
        {
            get
            {
                return childList[0].ConvertAll<ShipmentDetail>(delegate (BaseObject baseObject) { return (ShipmentDetail)baseObject; }).FindAll(sd => sd.Checked).Sum(s => s.Weight);
            }
        }

        public Shipment(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(ShipmentDialog);
            status = GetSpravValue("st_shipment_status_get_by_id", IdStatus) as String;
            IdStatus = IdStatus;
            if (IdStatus == (int)ShipmentStatus.New) LoadFreeOrders();
        }

        protected override void SetCommands()
        {
            loadCommand = "st_shipment_get";
            saveCommand = "st_shipment_save";
            deleteCommand = "st_shipment_delete";
            idGet = id;
        }

        private void LoadFreeOrders()
        {
            errCode = ErrCode.ErrOK;
            errMessage = "";
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SQLConnection.GetConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "st_order_list_by_status";
                command.Parameters.AddWithValue("@id_status", (int)OrderStatus.Stored);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ShipmentDetail detail = null;
                foreach (DataRow row in table.Rows)
                {
                    detail = new ShipmentDetail(0, this, null, false);
                    detail.IdOrder = (int)row["id"];
                    childList[0].Add(detail);
                }
            }
            catch (Exception ex)
            {
                errCode = ErrCode.ErrDB;
                errMessage = ex.Message;
            }
        }

        protected override void SetChildTypes()
        {
            childTypeList.Add(typeof(ShipmentDetail));
            base.SetChildTypes();
        }
        public override void SaveToDB()
        {
            List<ShipmentDetail> tmpDetail = childList[0].ConvertAll<ShipmentDetail>(delegate (BaseObject baseObject) { return (ShipmentDetail)baseObject; }).FindAll(sd => sd.Checked);
            childList[0] = tmpDetail.ConvertAll<BaseObject>(delegate (ShipmentDetail baseObject) { return baseObject; });
            base.SaveToDB();
        }
    }
}
