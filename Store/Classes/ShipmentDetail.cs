using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public sealed class ShipmentDetail : BaseObject
    {
        private Order order = null;
        private Shipment shipment = null;
        public int IdOrder
        {
            get
            {
                return fields.ContainsKey("id_order") ? (int)fields["id_order"] : 0;
            }
            set
            {
                order = new Order(value, null, null, true);
                if (fields.ContainsKey("id_order")) fields["id_order"] = value; else fields.Add("id_order", value);
            }
        }
        public int IdShipment
        {
            get
            {
                return fields.ContainsKey("id_shipment") ? (int)fields["id_shipment"] : 0;
            }
            set
            {
                if (fields.ContainsKey("id_shipment")) fields["id_shipment"] = value; else fields.Add("id_shipment", value);
            }
        }
        public String Num { get { return order.Num; } }
        public String Customer { get { return order.Customer.LastName + " " + order.Customer.FirstName + " " + order.Customer.SecondName; } }
        public String Address { get { return order.Customer.Address; } }
        public int Weight { get { return order.TotalWeight; } }
        public DateTime DtBeg { get { return order.DtBeg; } }
        public bool Checked { get { return order.IdStatus == (int)OrderStatus.OnRoute; } set { if (value) order.IdStatus = (int)OrderStatus.OnRoute; else order.IdStatus = (int)OrderStatus.Stored; } }

        public Order Order { get { return order; } }
        public Shipment Shipment { get { return shipment; } }

        public ShipmentDetail(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {}

        protected override void SetCommands()
        {
            loadCommand = "st_shipment_detail_get";
            saveCommand = "st_shipment_detail_save";
            deleteCommand = "st_shipment_detail_delete";
            idGet = id;
        }
        protected override void SetChildTypes()
        {}
        protected override void LoadFromDB()
        {
            base.LoadFromDB();
            IdOrder = IdOrder;
            shipment = (Shipment)parent;
        }

        public override void SaveToDB()
        {
            if (fields.ContainsKey("id_shipment")) fields["id_shipment"] = parent.Id;
            else fields.Add("id_shipment", parent.Id);
            if (fields.ContainsKey("id_order")) fields["id_order"] = order.Id;
            else fields.Add("id_order", order.Id);
            base.SaveToDB();
            order.SaveToDB();
        }




    }
}
