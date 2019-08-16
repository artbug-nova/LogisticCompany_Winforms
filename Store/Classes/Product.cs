using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Store
{
    public sealed class Product : BaseObject
    {
        private Order order = null;
        public int IdOrder { get { return fields.ContainsKey("id_order") ? (int)fields["id_order"] : 0; } set { if (fields.ContainsKey("id_order")) fields["id_order"] = value; else fields.Add("id_order", value); } }
        public String Name { get { return fields.ContainsKey("name") ? fields["name"] as String : ""; } set { if (fields.ContainsKey("name")) fields["name"] = value; else fields.Add("name", value); } }
        public Order Order { get { return order; } }
        public int BoxCount { get { return childList[0].Count; } }
        public int TotalWeight { get { return childList[0].ConvertAll<Box>(delegate (BaseObject baseObject) { return (Box)baseObject; }).Sum(b => b.Weight); } }

        public Product(int id, BaseObject parent = null, BaseObject child = null, bool loadChild = true) : base(id, parent, child, loadChild)
        {
            dialogType = typeof(ProductDialog);
            if (parent != null) order = (Order)parent;
            else order = new Order(IdOrder, null, this, true);
        }

        protected override void SetCommands()
        {
            loadCommand = "st_product_get";
            saveCommand = "st_product_save";
            deleteCommand = "st_product_delete";
            idGet = id;
        }
        protected override void LoadFromDB()
        {
            base.LoadFromDB();
        }

        protected override void SetChildTypes()
        {
            childTypeList.Add(typeof(Box));
            base.SetChildTypes();
        }

        public override void SaveToDB()
        {
            if (order != null)
            {
                if (fields.ContainsKey("id_order")) fields["id_order"] = order.Id;
                else fields.Add("id_order", order.Id);
            }
            base.SaveToDB();
        }
    }
}
