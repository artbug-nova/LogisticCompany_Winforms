using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public sealed class Shelf : BaseObject
    {
        private Rack rack = null;
        public int IdRack { get { return fields.ContainsKey("id_rack") ? (int)fields["id_rack"] : 0; } set { if (fields.ContainsKey("id_rack")) fields["id_rack"] = value; else fields.Add("id_rack", value); } }
        public String Num { get { return fields.ContainsKey("num") ? fields["num"] as String : ""; } set { if (fields.ContainsKey("num")) fields["num"] = value; else fields.Add("num", value); } }
        public int MaxWeight { get { return fields.ContainsKey("max_weight") ? (int)fields["max_weight"] : 0; } set { if (fields.ContainsKey("max_weight")) fields["max_weight"] = value; else fields.Add("max_weight", value); } }
        public String Note { get { return fields.ContainsKey("note") ? fields["note"] as String : ""; } set { if (fields.ContainsKey("note")) fields["note"] = value; else fields.Add("note", value); } }
        public decimal Procent { get { return MaxWeight != 0 ? (100 * ((decimal)childList[0].ConvertAll<Box>(delegate (BaseObject baseObject) { return (Box)baseObject; }).Sum(b => b.Weight)))/MaxWeight : 0m; } }
        public Rack Rack { get { return rack; } }

        public Shelf(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(ShelfDialog);
            if (parent != null) rack = (Rack)parent;
            else rack = new Rack(IdRack, null, this);
        }

        protected override void SetCommands()
        {
            loadCommand = "st_shelf_get";
            saveCommand = "st_shelf_save";
            deleteCommand = "st_shelf_delete";
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
            if (fields.ContainsKey("id_rack")) fields["id_rack"] = parent.Id;
            else fields.Add("id_rack", parent.Id);
            SaveChildren = false;
            base.SaveToDB();
        }
    }
}
