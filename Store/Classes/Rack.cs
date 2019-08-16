using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public sealed class Rack : BaseObject
    {
        public String Num { get { return fields.ContainsKey("num") ? fields["num"] as String : ""; } set { if (fields.ContainsKey("num")) fields["num"] = value; else fields.Add("num", value); } }
        public String Note { get { return fields.ContainsKey("note") ? fields["note"] as String : ""; } set { if (fields.ContainsKey("note")) fields["note"] = value; else fields.Add("note", value); } }


        public Rack(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(RackDialog);
        }
        protected override void SetCommands()
        {
            loadCommand = "st_rack_get";
            saveCommand = "st_rack_save";
            deleteCommand = "st_rack_delete";
            idGet = id;
        }

        protected override void LoadFromDB()
        {
            base.LoadFromDB();
        }

        protected override void SetChildTypes()
        {
            childTypeList.Add(typeof(Shelf));
            base.SetChildTypes();
        }

        public override void SaveToDB()
        {
            base.SaveToDB();
        }
    }
}
