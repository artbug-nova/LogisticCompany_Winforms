using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Store
{
    public sealed class Box : BaseObject
    {
        private Product product = null;
        private Shelf shelf = null;
        public int IdProduct { get { return fields.ContainsKey("id_product") ? (int)fields["id_product"] : 0; } set { if (fields.ContainsKey("id_product")) fields["id_product"] = value; else fields.Add("id_product", value); } }
        public int? IdShelf { get { return fields.ContainsKey("id_shelf") ? (fields["id_shelf"] == null ? 0 : (int)fields["id_shelf"]) : 0; } set { if (fields.ContainsKey("id_shelf")) fields["id_shelf"] = value == 0 ? null : (object)value; else fields.Add("id_shelf", value == 0 ? null : (object)value); } }
        public int IdRack { get { object res = GetSpravValue("st_rack_get_by_shelf_id", IdShelf.HasValue ? IdShelf.Value : 0); return res == null ? 0 : (int)res; } }
        public int Weight { get { return fields.ContainsKey("weight") ? (int)fields["weight"] : 0; } set { if (fields.ContainsKey("weight")) fields["weight"] = value; else fields.Add("weight", value); } }
        public int Length { get { return fields.ContainsKey("length") ? (int)fields["length"] : 0; } set { if (fields.ContainsKey("length")) fields["length"] = value; else fields.Add("length", value); } }
        public int Width { get { return fields.ContainsKey("width") ? (int)fields["width"] : 0; } set { if (fields.ContainsKey("width")) fields["width"] = value; else fields.Add("width", value); } }
        public int Height { get { return fields.ContainsKey("height") ? (int)fields["height"] : 0; } set { if (fields.ContainsKey("height")) fields["height"] = value; else fields.Add("height", value); } }
        public int IdStatus { get { return fields.ContainsKey("id_status") ? (int)fields["id_status"] : 1; } set { status = GetSpravValue("st_order_status_get_by_id", value) as String; if (fields.ContainsKey("id_status")) fields["id_status"] = value; else fields.Add("id_status", value); } }
        public String Note { get { return fields.ContainsKey("note") ? fields["note"] as String : ""; } set { if (fields.ContainsKey("note")) fields["note"] = value; else fields.Add("note", value); } }
        public Product Product { get { return product; } }
        public Shelf Shelf { get { return shelf; } }

        public Box(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(BoxDialog);
            if (parent != null)
            {
                if (parent is Product)
                {
                    product = (Product)parent;
                }
                else
                {
                    shelf = (Shelf)parent;
                }
            }
            else
            {
                product = new Product(IdProduct, null, this, true);
            }
            //if (product == null) product = new Product(IdProduct, null, this);
            //if (shelf == null) shelf = new Shelf(IdShelf, null, this);

            if (id == 0) IdStatus = 1;
        }

        protected override void SetCommands()
        {
            loadCommand = "st_box_get";
            saveCommand = "st_box_save";
            deleteCommand = "st_box_delete";
            idGet = id;
        }

        protected override void LoadFromDB()
        {
            base.LoadFromDB();
            status = GetSpravValue("st_order_status_get_by_id", IdStatus) as String;
        }

        protected override void SetChildTypes()
        {}

        public override void SaveToDB()
        {
            if (product != null)
            {
                if (fields.ContainsKey("id_product")) fields["id_product"] = product.Id;
                else fields.Add("id_product", product.Id);
            }
            if (IdStatus != (int)OrderStatus.Stored) IdShelf = null;
            base.SaveToDB();
        }

        public void SetStatusToOrder()
        {
            Order order = null;
            if (Product != null && Product.Order != null) order = Product.Order;
            else return;
            if (order.IdStatus != IdStatus)
            {
                order.IdStatus = IdStatus;
                if (IdStatus == (int)OrderStatus.OnWork) order.SetChildStatus();
            }
        }
    }
}
