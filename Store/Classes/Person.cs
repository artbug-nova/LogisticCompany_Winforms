using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Store
{
    public sealed class Person : BaseObject
    {
        private static Person currUser = null;
        private String position = "";
        private String role = "";
        private String newPassword = "";
        public String LastName { get { return fields.ContainsKey("last_name") ? fields["last_name"] as String : ""; } set { if (fields.ContainsKey("last_name")) fields["last_name"] = value; else fields.Add("last_name", value); } }
        public String FirstName { get { return fields.ContainsKey("first_name") ? fields["first_name"] as String : ""; } set { if (fields.ContainsKey("first_name")) fields["first_name"] = value; else fields.Add("first_name", value); } }
        public String SecondName { get { return fields.ContainsKey("second_name") ? fields["second_name"] as String : ""; } set { if (fields.ContainsKey("second_name")) fields["second_name"] = value; else fields.Add("second_name", value); } }
        public DateTime DtBirth { get { return fields.ContainsKey("dt_birth") ? (DateTime)fields["dt_birth"] : DateTime.Today; } set { if (fields.ContainsKey("dt_birth")) fields["dt_birth"] = value; else fields.Add("dt_birth", value); } }
        public int IdPosition { get { return fields.ContainsKey("id_position") ? (int)fields["id_position"] : 0; } set { position = GetSpravValue("st_person_position_get_by_id", value) as String; if (fields.ContainsKey("id_position")) fields["id_position"] = value; else fields.Add("id_position", value); } }
        public String Address { get { return fields.ContainsKey("address") ? fields["address"] as String : ""; } set { if (fields.ContainsKey("address")) fields["address"] = value; else fields.Add("address", value); } }
        public int IdStatus { get { return fields.ContainsKey("id_status") ? (int)fields["id_status"] : 1; } set { status = GetSpravValue("st_person_status_get_by_id", value) as String; if (fields.ContainsKey("id_status")) fields["id_status"] = value; else fields.Add("id_status", value); } }
        public String Login { get { return fields.ContainsKey("login") ? fields["login"] as String : ""; } set { if (fields.ContainsKey("login")) fields["login"] = value; else fields.Add("login", value); } }
        public String Password { get { return fields.ContainsKey("password") ? fields["password"] as String : ""; } set { if (fields.ContainsKey("password")) fields["password"] = value; else fields.Add("password", value); } }
        public int IdRole { get { return fields.ContainsKey("id_role") ? (fields["id_role"] == null ? 0 : (int)fields["id_role"]) : 2; } set { status = GetSpravValue("st_person_role_get_by_id", value) as String; if (fields.ContainsKey("id_role")) fields["id_role"] = value; else fields.Add("id_role", value); } }
        public String Phone { get { return fields.ContainsKey("phone") ? fields["phone"] as String : ""; } set { if (fields.ContainsKey("phone")) fields["phone"] = value; else fields.Add("phone", value); } }
        public int Access { get { return fields.ContainsKey("access") ? (int)fields["access"] : 0; } set { if (fields.ContainsKey("access")) fields["access"] = value; else fields.Add("access", value); } }
        public String Position { get { return position; } }
        public String Role { get { return role; } }
        public String NewPassword { set { newPassword = value; } }
        public static Person CurrUser { get { return currUser; } }

        public Person(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true) : base(id, parent, child, loadChildren)
        {
            dialogType = typeof(PersonDialog);
            if (id == 0) IdStatus = 1;
        }


        private Person(String login) : base()
        {
            loadCommand = "st_person_get_by_login";
            saveCommand = "st_person_save";
            deleteCommand = "st_person_delete";
            Login = login;
            idGet = Login;
            LoadFromDB();
        }



        protected override void SetCommands()
        {
            loadCommand = "st_person_get";
            saveCommand = "st_person_save";
            deleteCommand = "st_person_delete";
            idGet = id;
        }

        protected override void LoadFromDB()
        {
            base.LoadFromDB();
            status = GetSpravValue("st_person_status_get_by_id", IdStatus) as String;
            position = GetSpravValue("st_person_position_get_by_id", IdPosition) as String;
            role = GetSpravValue("st_person_role_get_by_id", IdRole) as String;
        }

        protected override void SetChildTypes()
        { }

        public override void SaveToDB()
        {
            if (Access == 1 && newPassword != "") Password = GetHashPassword(newPassword);
            base.SaveToDB();
        }


        public static void CreateUser(String login)
        {
            if (currUser == null) currUser = new Person(login);
        }


        public bool CheckPassword(String openPass)
        {
            return Password == GetHashPassword(openPass);
        }


        private String GetHashPassword(String openPass)
        {
            return GetHashString(GetHashString(openPass) + Login);
        }

        private String GetHashString(String srcString)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] srcByte = Encoding.ASCII.GetBytes(srcString);
                byte[] resByte = md5Hash.ComputeHash(srcByte);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < resByte.Length; i++)
                {
                    sb.Append(resByte[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


    }
}
