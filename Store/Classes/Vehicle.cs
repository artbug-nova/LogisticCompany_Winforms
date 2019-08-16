using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public sealed class Vehicle : BaseObject
    {
        public String Mark { get { return fields.ContainsKey("mark") ? fields["mark"] as String : ""; } set { if (fields.ContainsKey("mark")) fields["mark"] = value; else fields.Add("mark", value); } }
        public String StateNum { get { return fields.ContainsKey("state_num") ? fields["state_num"] as String : ""; } set { if (fields.ContainsKey("state_num")) fields["state_num"] = value; else fields.Add("state_num", value); } }
        public int Capacity { get { return fields.ContainsKey("capacity") ? (int)fields["capacity"] : 0; } set { if (fields.ContainsKey("capacity")) fields["capacity"] = value; else fields.Add("capacity", value); } }
        public int Length { get { return fields.ContainsKey("length") ? (int)fields["length"] : 0; } set { if (fields.ContainsKey("length")) fields["length"] = value; else fields.Add("length", value); } }
        public int Width { get { return fields.ContainsKey("width") ? (int)fields["width"] : 0; } set { if (fields.ContainsKey("width")) fields["width"] = value; else fields.Add("width", value); } }
        public int Height { get { return fields.ContainsKey("height") ? (int)fields["height"] : 0; } set { if (fields.ContainsKey("height")) fields["height"] = value; else fields.Add("height", value); } }
        public int IdStatus { get { return fields.ContainsKey("id_status") ? (int)fields["id_status"] : 1; } set { status = GetSpravValue("st_vehicle_status_get_by_id", value) as String; if (fields.ContainsKey("id_status")) fields["id_status"] = value; else fields.Add("id_status", value); } }

        public Vehicle(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(VehicleDialog);
            if (id == 0) IdStatus = 1;
        }

        protected override void SetCommands()
        {
            loadCommand = "st_vehicle_get";
            saveCommand = "st_vehicle_save";
            deleteCommand = "st_vehicle_delete";
            idGet = id;
        }

        protected override void LoadFromDB()
        {
            base.LoadFromDB();
            status = GetSpravValue("st_vehicle_status_get_by_id", IdStatus) as String;
        }

        protected override void SetChildTypes()
        { }

        public override void SaveToDB()
        {
            base.SaveToDB();
        }


    }
}
