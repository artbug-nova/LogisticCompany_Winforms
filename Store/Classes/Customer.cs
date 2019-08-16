using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public sealed class Customer : BaseObject
    {
        public int IdDistrict { get { return fields.ContainsKey("id_district") ? (int)fields["id_district"] : 0; } set { if (fields.ContainsKey("id_district")) fields["id_district"] = value; else fields.Add("id_district", value); } }
        public String LastName { get { return fields.ContainsKey("last_name") ? fields["last_name"] as String : ""; } set { if (fields.ContainsKey("last_name")) fields["last_name"] = value; else fields.Add("last_name", value); } }
        public String FirstName { get { return fields.ContainsKey("first_name") ? fields["first_name"] as String : ""; } set { if (fields.ContainsKey("first_name")) fields["first_name"] = value; else fields.Add("first_name", value); } }
        public String SecondName { get { return fields.ContainsKey("second_name") ? fields["second_name"] as String : ""; } set { if (fields.ContainsKey("second_name")) fields["second_name"] = value; else fields.Add("second_name", value); } }
        public String Address { get { return fields.ContainsKey("address") ? fields["address"] as String : ""; } set { if (fields.ContainsKey("address")) fields["address"] = value; else fields.Add("address", value); } }
        public String Phone { get { return fields.ContainsKey("phone") ? fields["phone"] as String : ""; } set { if (fields.ContainsKey("phone")) fields["phone"] = value; else fields.Add("phone", value); } }

        public Customer (int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(CustomerDialog);
        }

        protected override void SetCommands()
        {
            loadCommand = "st_customer_get";
            saveCommand = "st_customer_save";
            deleteCommand = "st_customer_delete";
            idGet = id;
        }

        protected override void LoadFromDB()
        {
            base.LoadFromDB();
        }

        protected override void SetChildTypes()
        {
            childTypeList.Add(typeof(Order));
            base.SetChildTypes();
        }
        public override void SaveToDB()
        {
            base.SaveToDB();
        }

    }
}
