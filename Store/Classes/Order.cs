using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Store
{
    public sealed class Order : BaseObject
    {
        private Customer customer = null;


        public String Num
        {
            get
            {
                return fields.ContainsKey("num") ? fields["num"] as String : "";
            }
            set
            {
                if (fields.ContainsKey("num")) fields["num"] = value; else fields.Add("num", value);
            }
        }


        public DateTime DtBeg { get { return fields.ContainsKey("dt_beg") ? (DateTime)fields["dt_beg"] : DateTime.Today; } set { if (fields.ContainsKey("dt_beg")) fields["dt_beg"] = value; else fields.Add("dt_beg", value); } }
        public DateTime DtEnd { get { return fields.ContainsKey("dt_end") ? (DateTime)fields["dt_end"] : DateTime.Today; } set { if (fields.ContainsKey("dt_end")) fields["dt_end"] = value; else fields.Add("dt_end", value); } }
        public DateTime? DtShip { get { return fields.ContainsKey("dt_ship") ? (DateTime?)fields["dt_ship"] : null; } set { if (fields.ContainsKey("dt_ship")) fields["dt_ship"] = value; else fields.Add("dt_ship", value); } }
        public int IdCustomer { get { return fields.ContainsKey("id_customer") ? (int)fields["id_customer"] : 0; } set { customer = new Customer(value, null, this, false);  if (fields.ContainsKey("id_customer")) fields["id_customer"] = value; else fields.Add("id_customer", value); } }
        public int IdStatus { get { return fields.ContainsKey("id_status") ? (int)fields["id_status"] : 1; } set { status = GetSpravValue("st_order_status_get_by_id", value) as String; if (fields.ContainsKey("id_status")) fields["id_status"] = value; else fields.Add("id_status", value); } }
        public String Note { get { return fields.ContainsKey("note") ? fields["note"] as String : ""; } set { if (fields.ContainsKey("note")) fields["note"] = value; else fields.Add("note", value); } }
        public Customer Customer { get { return customer; } }
        public int ProductCount { get { return childList[0].Count; } }


        public int BoxCount
        {
            get
            {
                return childList[0].ConvertAll<Product>(delegate (BaseObject baseObject)
                { return (Product)baseObject; }).Sum(p => p.BoxCount);
            }
        }


        public int TotalWeight { get { return childList[0].ConvertAll<Product>(delegate (BaseObject baseObject) { return (Product)baseObject; }).Sum(p => p.TotalWeight); } }

        public Order(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(OrderDialog);
            if (id == 0) IdStatus = 1;
        }

        protected override void SetCommands()
        {
            loadCommand = "st_order_get";
            saveCommand = "st_order_save";
            deleteCommand = "st_order_delete";
            idGet = id;
        }
        protected override void LoadFromDB()
        {
            base.LoadFromDB();
            status = GetSpravValue("st_order_status_get_by_id", IdStatus) as String;
            customer = new Customer(IdCustomer, null, this, false);
        }
        protected override void SetChildTypes()
        {
            childTypeList.Add(typeof(Product));
            base.SetChildTypes();
        }

        public override void SaveToDB()
        {
            base.SaveToDB();
        }

        public void SetChildStatus()
        {
            foreach (BaseObject product in childList[0])
            {
                product.SaveChildren = true;
                foreach (BaseObject box in ((Product)product).ChildList[0])
                {
                    ((Box)box).IdStatus = IdStatus;
                }
            }
        }
    }
}
