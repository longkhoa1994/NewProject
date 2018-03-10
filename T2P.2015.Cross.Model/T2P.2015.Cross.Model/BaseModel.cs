using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;
using System.ComponentModel.DataAnnotations;
using T2P._2015.Cross.Model.View;
using Newtonsoft.Json;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class BaseModel
    {
        private long _CreatedBy;
        public long CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        private DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        private long _UpdatedBy;
        public long UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }

        private DateTime _UpdatedDate;
        public DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }

        private int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        [JsonIgnore]
        public virtual string Table { get { return String.Empty; } }

        [JsonIgnore]
        public virtual string PrimaryKey { get { return String.Empty; } }

        [JsonIgnore]
        public virtual string InsertUpdateProcedure { get { return string.Empty; } }

        [JsonIgnore]
        public virtual string DeleteProcedure { get { return "p_Common_Delete"; } }

        [JsonIgnore]
        public virtual string DeletePhysicalProcedure { get { return "p_Common_Delete_Physic"; } }

        [JsonIgnore]
        public virtual string DeleteListPhysicalProcedure { get { return "p_Common_DeleteList_Physic"; } }


        [JsonIgnore]
        public virtual string GetByID { get { return "p_Common_GetByID"; } }

        [JsonIgnore]
        public virtual string GetList { get { return "p_Common_GetList"; } }


        public BaseModel()
        {

        }

        public EntityValidationResult Validate<T>(T entity)
        {
            var validationResults = new List<ValidationResult>();
            var vc = new ValidationContext(entity, null, null);
            var isValid = Validator.TryValidateObject(entity, vc, validationResults, true);

            return new EntityValidationResult(validationResults);
        }

    }


    public enum BaseModelColumm
    {
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }


    public enum BaseModelProcedure
    {
        p_GetLocalServerTimezone
    }


    public class BaseModelList : List<BaseModel>
    {
    }

    public class Dynamic : DynamicObject
    {
        // The inner dictionary.
        private Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        // This property returns the number of elements 
        // in the inner dictionary. 
        public int Count
        {
            get
            {
                return Dictionary.Count;
            }
        }

        public Dictionary<string, object> Dictionary
        {
            get { return _dictionary; }
            set { _dictionary = value; }
        }

        // If you try to get a value of a property  
        // not defined in the class, this method is called. 
        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {
            // Converting the property name to lowercase 
            // so that property names become case-insensitive. 
            string name = binder.Name.ToLower();

            // If the property name is found in a dictionary, 
            // set the result parameter to the property value and return true. 
            // Otherwise, return false. 
            return Dictionary.TryGetValue(name, out result);
        }

        //// If you try to set a value of a property that is 
        //// not defined in the class, this method is called. 
        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            // Converting the property name to lowercase 
            // so that property names become case-insensitive.
            Dictionary[binder.Name.ToLower()] = value;

            // You can always add a value to a dictionary, 
            // so this method always returns true. 
            return true;
        }
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _dictionary.Keys;
        }

        public Dynamic()
        {

        }
        public Dynamic(Dictionary<string, object> values)
        {
            Dictionary = values;
        }
        public static void SetListObject<T>(List<T> listobj, Dynamic refKey)
        {
            if (listobj != null && listobj.Count > 0)
            {
                foreach (var obj in listobj)
                {
                    SetObject(obj, refKey);
                }
            }

        }
        public static T SetObject<T>(T obj, Dynamic refKey)
        {
            if (obj != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(obj.GetType().GetProperties());
                if (refKey != null)
                {
                    foreach (var dictionary in refKey.Dictionary)
                    {
                        if (list.Any(x => x.Name.ToLower() == dictionary.Key.ToLower()))
                        {
                            if (dictionary.Value != DBNull.Value)
                            {

                                list.First(x => x.Name.ToLower() == dictionary.Key.ToLower()).SetValue(obj, dictionary.Value, null);
                            }
                        }
                    }
                }
            }
            return obj;
        }

        public static object GetValueByT<T>(T obj, string name)
        {

            IList<PropertyInfo> list = new List<PropertyInfo>(obj.GetType().GetProperties());
            if (list.Any(x => x.Name.ToLower() == name.ToLower()))
            {
                var value = list.First(x => x.Name.ToLower() == name.ToLower()).GetValue(obj, null);
                return value;
            }
            else
            {
                return null;
            }
        }

        public static T1 ConvertObject<T, T1>(T fromObj)
        {

            Type type = typeof(T1);
            T1 entity = (T1)Activator.CreateInstance(type);
            if (fromObj != null)
            {
                // T obj = Utility.Conversion.Conversion.Clone<T>(fromObj);

                IList<PropertyInfo> props = new List<PropertyInfo>(fromObj.GetType().GetProperties());
                IList<PropertyInfo> list = new List<PropertyInfo>(entity.GetType().GetProperties());
                foreach (PropertyInfo prop in props)
                {

                    if (list.Any(x => x.Name.ToLower() == prop.Name.ToLower() && x.CanWrite == true && prop.CanRead == true && prop.PropertyType.Name == x.PropertyType.Name))
                    {
                        var value = prop.GetValue(fromObj, null);
                        list.First(x => x.Name.ToLower() == prop.Name.ToLower() && x.CanWrite == true && prop.CanRead == true && prop.PropertyType.Name == x.PropertyType.Name).SetValue(entity, value, null);
                    }

                    //PropertyInfo pi = type.GetProperty(prop.Name);
                    //if (pi != null)
                    //{
                    //    var value = prop.GetValue(fromObj, null);
                    //    pi.SetValue(entity, value, null);
                    //}
                }
            }
            else
            {
                entity = default(T1);
            }
            return entity;
        }

        public static List<T> ConvertDynamicToTList<T>(List<dynamic> listobj)
        {
            List<T> listResult = new List<T>();

            foreach (var item in listobj)
            {
                T obj = ConvertDynamicToT<T>(item);
                if (obj != null)
                {
                    listResult.Add(obj);
                }
                else
                {
                    throw new Exception("Object is not null");
                }
            }

            return listResult;
        }


        public static T ConvertDynamicToT<T>(Dynamic obj)
        {
            if (obj.Dictionary.Count > 0)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(typeof(T).GetProperties());
                T entity = (T)Activator.CreateInstance(typeof(T));
                foreach (var item in list)
                {
                    if (obj.Dictionary.Any(x => x.Key.ToLower() == item.Name.ToLower()))
                    {
                        KeyValuePair<string, object> temp = obj.Dictionary.Where(x => x.Key.ToLower() == item.Name.ToLower()).First();
                        var objectParse = Utility.Conversion.Conversion.Parse(item.PropertyType, temp.Value);
                        item.SetValue(entity, objectParse);                        
                    }
                }
                return entity;
            }
            else
            {
                return default(T);
            }

        }




        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="fromObj"></param>
        /// <param name="additionKey">key is name of field,value is value of field</param>
        /// <param name="copyField">key is name of field to object, value is name of field from object   </param>
        /// <returns></returns>
        public static List<T1> ConvertListObject<T, T1>(List<T> fromObj, Dynamic additionKey = null, Dynamic copyField = null)
        {
            List<T1> result = new List<T1>();

            foreach (var item in fromObj)
            {
                if (copyField != null)
                {
                    IList<PropertyInfo> list = new List<PropertyInfo>(item.GetType().GetProperties());

                    foreach (var dictionary in copyField.Dictionary)
                    {
                        if (list.Any(x => x.Name.ToLower() == dictionary.Value.ToString().ToLower()))
                        {
                            string key = dictionary.Key.ToString();
                            object value = list.FirstOrDefault(x => x.Name.ToLower() == dictionary.Value.ToString().ToLower()).GetValue(item, null);

                            if (additionKey != null)
                            {
                                if (additionKey.Dictionary.Any(x => x.Key == key))
                                {
                                    additionKey.Dictionary[key] = value;
                                }
                                else
                                {
                                    additionKey.Dictionary.Add(key, value);
                                }
                            }
                        }
                    }


                }

                T1 obj = ConvertObjectAddition<T, T1>(item, additionKey);
                result.Add(obj);
            }

            return result;
        }


        //private static Dictionary<string, object> GetValueForCopyField<T>(T fromObj, Dynamic copyField)
        //{
        //    Dictionary<string, object> result = new Dictionary<string, object>();
        //    if (fromObj != null)
        //    {
        //        IList<PropertyInfo> list = new List<PropertyInfo>(fromObj.GetType().GetProperties());
        //        foreach (var dictionary in copyField.Dictionary)
        //        {
        //            if (list.Any(x => x.Name.ToLower() == dictionary.Value.ToString().ToLower()))
        //            {
        //                string key = dictionary.Key.ToString();
        //                object value = list.FirstOrDefault(x => x.Name.ToLower() == dictionary.Value.ToString().ToLower()).GetValue(fromObj, null);
        //                result.Add(key, value);
        //            }
        //        }
        //    }
        //    return result;
        //}


        public static T1 ConvertObjectAddition<T, T1>(T fromObj, T1 toObject, Dynamic additionKey)
        {
            T1 entity = ConvertObject<T, T1>(fromObj);
            if (entity != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(entity.GetType().GetProperties());
                if (additionKey != null)
                {
                    foreach (var dictionary in additionKey.Dictionary)
                    {
                        if (list.Any(x => x.Name.ToLower() == dictionary.Key.ToLower()))
                        {
                            list.First(x => x.Name.ToLower() == dictionary.Key.ToLower()).SetValue(entity, dictionary.Value, null);
                        }
                    }
                }
            }
            return entity;
        }


        public static T1 ConvertObjectAddition<T, T1>(T fromObj, Dynamic additionKey)
        {
            T1 entity = ConvertObject<T, T1>(fromObj);
            if (entity != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(entity.GetType().GetProperties());
                if (additionKey != null)
                {
                    foreach (var dictionary in additionKey.Dictionary)
                    {
                        if (list.Any(x => x.Name.ToLower() == dictionary.Key.ToLower()))
                        {
                            list.First(x => x.Name.ToLower() == dictionary.Key.ToLower()).SetValue(entity, dictionary.Value, null);
                        }
                    }
                }
            }
            return entity;
        }

        public static Dynamic Additions(long userID = 1, DateTime? timeNow = null)
        {
            dynamic addition = new Dynamic();
            addition.CreatedBy = userID;
            DateTime timeTemp = !timeNow.HasValue ? DateTime.Now : timeNow.Value;
            
            addition.CreatedDate = timeTemp;
            addition.UpdatedBy = userID;
            addition.UpdatedDate = timeTemp;
            addition.Status = Const.IsActive;
            return addition;
        }

        public static dynamic Create<T>(T obj, V_Pagination pagination = null, V_Permission permission = null)
        {
            Dynamic result = new Dynamic();
            if (obj != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(obj.GetType().GetProperties());

                foreach (PropertyInfo item in list)
                {
                    var value = item.GetValue(obj, null);
                    result.Dictionary.Add(item.Name, value);
                }
            }

            if (pagination != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(pagination.GetType().GetProperties());

                foreach (PropertyInfo item in list)
                {
                    var value = item.GetValue(pagination, null);
                    result.Dictionary.Add(item.Name, value);
                }

                result.Dictionary.Add("TotalRecords", 0);
            }

            if (permission != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(permission.GetType().GetProperties());

                foreach (PropertyInfo item in list)
                {
                    var value = item.GetValue(permission, null);
                    result.Dictionary.Add(item.Name, value);
                }
            }

            return result;
        }
        public static dynamic Create(Dynamic result, V_Pagination pagination = null, V_Permission permission = null)
        {

            if (pagination != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(pagination.GetType().GetProperties());

                foreach (PropertyInfo item in list)
                {
                    var value = item.GetValue(pagination, null);
                    result.Dictionary.Add(item.Name, value);
                }

                result.Dictionary.Add("TotalRecords", 0);
            }

            if (permission != null)
            {
                IList<PropertyInfo> list = new List<PropertyInfo>(permission.GetType().GetProperties());

                foreach (PropertyInfo item in list)
                {
                    var value = item.GetValue(permission, null);
                    result.Dictionary.Add(item.Name, value);
                }
            }

            return result;
        }

    }

    public class EntityValidationResult
    {
        public IList<ValidationResult> Errors { get; private set; }
        public bool HasError
        {
            get { return Errors.Count > 0; }
        }

        public EntityValidationResult(IList<ValidationResult> errors = null)
        {
            Errors = errors ?? new List<ValidationResult>();
        }
    }
}