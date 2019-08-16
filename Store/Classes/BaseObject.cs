using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Store
{
    public enum ErrCode //Энумератор для кодов ошибок
    {
        ErrOK = 0,
        ErrDB = 1,
        ErrNoData = 2
    }
    public enum VehicleStatus //Энумератор для статусов автомобилей
    {
        Free = 1,
        OnRoute = 2,
        OnRepair = 3,
        Deleted = 4
    }
    public enum PersonPosition //Энумератор для должностей
    {
        Boss = 1,
        Keeper = 2,
        Driver = 3,
        Agent = 4
    }
    public enum PersonStatus //Энумератор для статусов персонала
    {
        Free = 1,
        OnRoute = 2,
        Hospital = 3,
        OnVacation = 4,
        Retired = 5
    }
    public enum ShipmentStatus //Энумератор для статусов отгрузок
    {
        New = 1,
        OnRoute = 2,
        Closed = 3
    }
    public enum OrderStatus //Энумератор для статусов заказов
    {
        New = 1,
        OnWork = 2,
        ToStore = 3,
        Stored = 4,
        OnRoute = 5,
        Delivered = 6,
        Defected = 7,
        Returned = 8
    }



    //Абстрактный класс, базовый, для всех классов, загружаемых из базы данных
    public abstract class BaseObject
    {
        public class Comparer : IComparer<BaseObject>
        {
            String memberName = "";
            System.Windows.Forms.SortOrder sortOrder = System.Windows.Forms.SortOrder.None;

            public Comparer (String memberName, System.Windows.Forms.SortOrder sortOrder)
            {
                this.memberName = memberName;
                this.sortOrder = sortOrder;
            }

            public virtual int Compare(BaseObject object1, BaseObject object2)
            {
                return 0;
            }
        }




        protected object idGet = null;
        protected bool loadChildren = true;

        protected int id = 0; //идентификатор в базе (первичный ключ)
        protected BaseObject parent = null; //ссылка на объект-владелец (если null, то текущий объект верхний в списке иерархии)
        protected BaseObject child = null; //ссылка на подчиненный объект, вызвавший загрузку
        protected List<List<BaseObject>> childList = new List<List<BaseObject>>(); //коллекция подчиненных объектов, если пустая - то объект нижний в списке иерархии
        protected List<List<BaseObject>> childListOld = new List<List<BaseObject>>(); //коллекция со старым набором подчиненных объектов
        protected List<Type> childTypeList = new List<Type>(); //список подчиненных типов
        protected Dictionary<String, object> fields = new Dictionary<String, object>(); //коллекция полей данных загруженного объекта
        protected ErrCode errCode = ErrCode.ErrOK; //Код результата последней операции с базой данных
        protected String errMessage = ""; //Текст ошибки
        protected String status = "";

        protected Type dialogType = null;  //Тип диалогового окна, соответствующий классу, заполняется в конструкторе

        protected String loadCommand = ""; //Имя хранимой процедуры для чтения из базы
        protected String saveCommand = ""; //Имя хранимой процедуры для записи в базу
        protected String deleteCommand = ""; //Имя хранимой процедуры для удаления из базы

        protected DataSet dataSet = new DataSet(); 

        public int Id {  get { return id; } }
        public BaseObject Parent { get { return parent; } }
        public List<List<BaseObject>> ChildList { get { return childList; } }
        public Type DialogType { get { return dialogType; } }
        public ErrCode ErrCode { get { return errCode; } }
        public String ErrMessage { get { return errMessage; } }
        public String Status { get { return status; } }
        public bool SaveChildren { get; set; }

        public BaseObject()
        { }

        public BaseObject(int id, BaseObject parent = null, BaseObject child = null, bool loadChildren = true)
        {
            this.id = id;
            this.parent = parent;
            this.child = child;
            this.loadChildren = loadChildren;
            SetCommands();
            SetChildTypes();
            if (id > 0) LoadFromDB();
        }

        protected abstract void SetCommands();
        protected virtual void SetChildTypes()
        {
            foreach (Type childType in childTypeList)
            {
                childList.Add(new List<BaseObject>());
                childListOld.Add(new List<BaseObject>());
            }
        }
        public Type GetChildType(int index)
        {
            return childTypeList[index];
        }
        protected void LoadChild() //метод для загрузки списка подчиненных объектов
        {
            DataTable table = null;
            Type childType = null;
            BaseObject childObject = null;
            List<BaseObject> currentChildList = null;
            List<BaseObject> currentChildListOld = null;
            for (int i = 1; i < dataSet.Tables.Count; i++)
            {
                table = dataSet.Tables[i];
                childType = childTypeList[i - 1];
                currentChildList = childList[i - 1];
                currentChildListOld = childListOld[i - 1];
                foreach (DataRow row in table.Rows)
                {
                    if (child == null || ((int)row["id"] != child.Id && child.Id != 0))
                    {
                        childObject = (BaseObject)childType.GetConstructor(new Type[] { typeof(int), typeof(BaseObject), typeof(BaseObject), typeof(bool) }).Invoke(new object[] { row["id"], this, null, true });
                        if (childObject.ErrCode != ErrCode.ErrOK)
                        {
                            errCode = childObject.ErrCode;
                            errMessage = childObject.ErrMessage;
                        }
                    }
                    else childObject = child;
                    currentChildList.Add(childObject);
                    currentChildListOld.Add(childObject);
                }
            }
        }

        protected virtual void LoadFromDB()
        {
            errCode = ErrCode.ErrOK;
            errMessage = "";
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SQLConnection.GetConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = loadCommand;
                command.Parameters.AddWithValue("@id", idGet);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, "table");
                if (dataSet.Tables["table"].Rows.Count == 0)
                {
                    errCode = ErrCode.ErrNoData;
                    errMessage = String.Format("Запись с id={0} не найдена.", id);
                    return;
                }
                id = (int)dataSet.Tables["table"].Rows[0]["id"];
                //Заполняем все поля данных
                foreach (DataColumn column in dataSet.Tables["table"].Columns)
                {
                    if (column.ColumnName != "id")
                    {
                        if (!fields.ContainsKey(column.ColumnName)) fields.Add(column.ColumnName, dataSet.Tables["table"].Rows[0][column.ColumnName] != DBNull.Value ? dataSet.Tables["table"].Rows[0][column.ColumnName] : null);
                        else fields[column.ColumnName] = dataSet.Tables["table"].Rows[0][column.ColumnName] != DBNull.Value ? dataSet.Tables["table"].Rows[0][column.ColumnName] : null;
                    }
                }
                if (dataSet.Tables.Count > 1 && loadChildren) LoadChild();
            }
            catch (Exception ex)
            {
                errCode = ErrCode.ErrDB;
                errMessage = ex.Message;
            }
        }

        public virtual void SaveToDB()
        {
            errCode = ErrCode.ErrOK;
            errMessage = "";
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SQLConnection.GetConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = saveCommand;
                command.Parameters.AddWithValue("@id", id);
                foreach (KeyValuePair<String, object> pair in fields)
                {
                    command.Parameters.AddWithValue("@" + pair.Key, pair.Value == null ? DBNull.Value : pair.Value);
                }
                int result = (int)command.ExecuteScalar();
                if (result <= 0)
                {
                    errCode = ErrCode.ErrNoData;
                    errMessage = "Сохранение не произведено.";
                    return;
                }
                id = result;
                if (SaveChildren) SaveChild();
            }
            catch (Exception ex)
            {
                errCode = ErrCode.ErrDB;
                errMessage = ex.Message;
            }
        }

        public void DeleteFromDB()
        {
            errCode = ErrCode.ErrOK;
            errMessage = "";
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SQLConnection.GetConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = deleteCommand;
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errCode = ErrCode.ErrDB;
                errMessage = ex.Message;
            }
        }
        protected virtual void SaveChild()
        {
            //Идем по массиву списков подчиненных объектов
            foreach (List<BaseObject> currListOld in childListOld)
            {
                //Сначала убираем лишние объекты
                foreach (BaseObject childOld in currListOld)
                {
                    if (!childList[childListOld.IndexOf(currListOld)].Exists(o => o == childOld)) childOld.DeleteFromDB();
                }
                foreach (BaseObject child in childList[childListOld.IndexOf(currListOld)])
                {
                    child.SaveToDB();
                    if (child.ErrCode != ErrCode.ErrOK)
                    {
                        errCode = child.ErrCode;
                        errMessage = child.errMessage;
                        return;
                    }
                }
            }
        }

        public void RestoreChildren()
        {
            foreach (List<BaseObject> currChildList in childList)
            {
                currChildList.Clear();
                foreach (BaseObject oldObject in childListOld[childList.IndexOf(currChildList)])
                {
                    currChildList.Add(oldObject);
                }
            }
        }

        protected static object GetSpravValue(String procedure, int parameter)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = SQLConnection.GetConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedure;
                command.Parameters.AddWithValue("@id", parameter);
                object res = command.ExecuteScalar();
                return res == DBNull.Value ? null : res;
            }
            catch
            {
                return null;
            }
        }
    }
}
