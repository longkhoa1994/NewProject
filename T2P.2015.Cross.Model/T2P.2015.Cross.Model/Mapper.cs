using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using T2P._2015.Cross.Utility.Conversion;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class MapperObjectList : List<MapperObject>
    {
    }

    [Serializable]
    public class MapperObject
    {
        public string SourceObjectName { get; set; }
        public string SourcePath { get; set; }
        public string SourceField { get; set; }
        public string SourceType { get; set; }

        public string DesObjectName { get; set; }
        public string DesPath { get; set; }
        public string DesField { get; set; }
        public string DesType { get; set; }

        public string Condition { get; set; }
        public string ConditionPath { get; set; }
        public IResolver<object, object> Resolver { get; set; }

        //public Func<T, T2> Converter<T,T2>() { get; set; }
        public Func<object, object> Converter { get; set; }

        //public Func<List<object>, object> ConverterListToObject { get; set; }

        //public Func<object, List<object>> ConverterObjectToList { get; set; }

        public string Formula { get; set; }
        public string listAdditionalPath { get; set; }
    }

    [Serializable]
    public class MapperManager
    {
        private static MapperManager process;

        public static MapperManager Process
        {
            get
            {
                if (process == null)
                    process = new MapperManager();
                return process;
            }
        }

        public MapperManager()
        {
        }

        public TDes Parse<TSourse, TDes>(TSourse source, List<MapperObject> listMapping, bool IsAddAuditInfomation = false, long _UserID = 1, bool isPaymentHub = false)
        {
            TDes result = (TDes)Activator.CreateInstance(typeof(TDes));

            Parse<TSourse, TDes>(source, ref result, listMapping, IsAddAuditInfomation, _UserID, isPaymentHub);

            return result;
        }

        public void Parse<TSourse, TDes>(TSourse source, ref TDes result, List<MapperObject> listMapping, bool IsAddAuditInfomation = false, long _UserID = 1, bool isPaymentHub = false)
        {
            string sourceName = typeof(TSourse).Name;
            string desName = typeof(TDes).Name;

            //Check TSourse Type

            //Check TDes Type

            dynamic input = new Dynamic();
            input.SourceName = sourceName;
            input.DesName = desName;

            //List<P_BookingMapping> listMapping = BaseBLL.Instance.CommandStoredProcedureName<P_BookingMapping>(P_BookingMappingProcedure.p_P_BookingMapping_GetByPlatform.ToString(), input);
            using (var mapper = new MapperProcess(source))
            {
                mapper.IsPaymentHub = isPaymentHub;
                mapper.Map(source, result, listMapping);
                if (IsAddAuditInfomation) AddAuditInfomation(result, _UserID);
            }
        }

        private void AddAuditInfomation<T>(T obj, long userId)
        {
            if (obj == null || obj.IsSimpleType())
                return;

            if (obj is IEnumerable)
            {
                var objs = (IEnumerable)obj;
                foreach (var item in objs)
                {
                    AddAuditInfomation(item, userId);
                }
            }
            else if (obj.GetType().IsClass)
            {
                var auditFields = new List<string>() { "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" };
                var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var prop in properties)
                {
                    var type = prop.PropertyType;
                    if (auditFields.Exists(o => o.ToLower() == prop.Name.ToLower()))
                    {
                        if (type == typeof(long))
                        {
                            prop.SetValue(obj, userId, null);
                        }

                        if (type == typeof(DateTime))
                        {
                            prop.SetValue(obj, DateTime.Now, null);
                        }
                    }

                    if (type.IsClass)
                    {
                        var val = prop.GetValue(obj);
                        AddAuditInfomation(val, userId);
                    }
                }
            }
        }
    }

    public class MapperProcess : IDisposable
    {
        private object _source = null;

        private bool _isPaymentHub;
        public bool IsPaymentHub
        {
            get { return _isPaymentHub; }
            set { _isPaymentHub = value; }
        }

        public MapperProcess(object source)
        {
            _source = source;
            IsPaymentHub = false;
        }

        public object Map(object src, object dest, List<MapperObject> mapping, string destParentPath = "")
        {
            //if (src == null)
            //    return null;

            var destType = dest.GetType();
            if (destType.IsPrimitive)
            {
                var mapPath = mapping.First();
                return GetValue(src, mapPath.GetFullSourcePath()).FirstOrDefault();
            }
            else if (dest.IsGenericList())
            {
                var subType = destType.GetInterfaces().First().GetGenericArguments().FirstOrDefault();
                if (subType == null && destType.HasElementType)
                {
                    subType = destType.GetElementType();
                }

                var mapPath = mapping.First();
                var srcValue = GetValue(src, mapPath.SourcePath);

                var destReplacement = mapPath.DesPath;
                var srcReplacement = mapPath.SourcePath;

                var subMapping = mapping.Where(o => o.GetFullDesPath().StartsWith(destReplacement))
                                        .Select(o => new MapperObject
                                        {
                                            DesPath = o.DesPath.Replace(destReplacement, "").NormalizePath(),
                                            DesField = o.DesField,
                                            SourcePath = o.SourcePath.Replace(srcReplacement, "").NormalizePath(),
                                            SourceField = o.SourceField,
                                            Resolver = o.Resolver,
                                            Converter = o.Converter,
                                            Condition = o.Condition,
                                            Formula = o.Formula,
                                            listAdditionalPath = o.listAdditionalPath
                                        })
                                        .OrderBy(o => o.GetFullDesPath().Length)
                                        .ToList();

                if (srcValue is IEnumerable && !(srcValue is string))
                {
                    var srcValues = (IEnumerable)srcValue;
                    foreach (var val in srcValues)
                    {
                        if (val == null)
                        {
                            continue;
                        }
                        if (val.IsSimpleType() && val.GetType() == subType)
                        {
                            ((IList)dest).Add(val);
                        }
                        else
                        {
                            var item = Activator.CreateInstance(subType);
                            ((IList)dest).Add(Map(val, item, subMapping, ""));
                        }
                    }
                }
                else
                {
                    var item = Activator.CreateInstance(subType);
                    ((IList)dest).Add(Map(srcValue, item, subMapping, ""));
                }
            }
            else if (destType.IsClass)
            {
                var properties = dest.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    var propType = prop.PropertyType;
                    var propParentPath = string.Join(".", destParentPath, prop.Name).NormalizePath();
                    var propMapping = mapping.Where(o =>
                                                        o.GetFullDesPath().StartsWith(propParentPath) &&
                                                        //check condition for Transaction Type
                                                        (
                                                            string.IsNullOrWhiteSpace(o.Condition) || string.IsNullOrWhiteSpace(o.ConditionPath) ||
                                                            (GetValue(src, o.ConditionPath).FirstOrDefault() != null && GetValue(src, o.ConditionPath).FirstOrDefault().ToString() == o.Condition)
                                                        )
                                                        && 
                                                        (
                                                            !IsPaymentHub || 
                                                            (IsPaymentHub && !string.IsNullOrWhiteSpace(o.SourcePath) && !string.IsNullOrWhiteSpace(o.DesPath))
                                                        )
                                                        //&& !string.IsNullOrWhiteSpace(o.SourcePath) 
                                                        //&& !string.IsNullOrWhiteSpace(o.DesPath)
                                                    )
                                             .OrderBy(o => o.GetFullDesPath().Length)
                                             .ToList();

                    if (propMapping.Count > 0)
                    {
                        try
                        {
                            var propValue = prop.GetValue(dest, null);
                            if (propType.IsSimpleType())
                            {
                                var map = propMapping.FirstOrDefault(o => o.DesField == prop.Name);
                                if (map != null)
                                {
                                    if (map.Converter == null)
                                    {
                                        if (!string.IsNullOrWhiteSpace(map.Formula))
                                        {
                                            Dictionary<string, object> listAdditionalInputField = new Dictionary<string, object>();

                                            var listSourceProperties = src.GetType().GetProperties();

                                            if (!string.IsNullOrWhiteSpace(map.listAdditionalPath))
                                            {
                                                List<string> list_Temp = map.listAdditionalPath.Split('|').ToList();

                                                if (list_Temp != null && list_Temp.Any())
                                                {
                                                    foreach (string item in list_Temp)
                                                    {
                                                        string[] tempArray = item.Split('-');
                                                        string fieldName = tempArray[0];
                                                        string fieldPath = tempArray[1];

                                                        
                                                        if (listSourceProperties != null && listSourceProperties.Any(x => fieldPath.Split('.').ToList().Any(y => x.Name == y)) && fieldPath.Contains("<"))
                                                        {
                                                            string tempPath = string.Empty;
                                                            bool isMatchPath = false;

                                                            foreach (string item2 in fieldPath.Split('.'))
                                                            {
                                                                if (!isMatchPath && listSourceProperties.Any(x => x.Name == item2))
                                                                {
                                                                    isMatchPath = true;
                                                                }

                                                                if (isMatchPath)
                                                                {
                                                                    if (item2 == "<")
                                                                    {
                                                                        tempPath = tempPath.Substring(0, tempPath.Length - 1);
                                                                        tempPath = tempPath.Substring(0, tempPath.LastIndexOf("."));
                                                                        tempPath += ".";
                                                                    }
                                                                    else
                                                                    {
                                                                        tempPath += item2 + ".";
                                                                    }
                                                                }
                                                            }

                                                            IList<object> value = GetValue(src, (tempPath + fieldName).Normalize());
                                                            listAdditionalInputField.Add(fieldName, value);
                                                        }
                                                        else
                                                        {
                                                            object value = GetValue(src, (fieldPath.Split('.').Last() + "." + fieldName).Normalize()).FirstOrDefault();
                                                            listAdditionalInputField.Add(fieldName, value);
                                                        }
                                                    }
                                                }
                                            }

                                            object inputFieldValue = null;

                                            if (listSourceProperties != null && listSourceProperties.Any(x => map.SourcePath.Split('.').ToList().Any(y => x.Name == y)) && map.SourcePath.Contains("<"))
                                            {
                                                string tempPath = string.Empty;
                                                bool isMatchPath = false;

                                                foreach (string item2 in map.SourcePath.Split('.'))
                                                {
                                                    if (!isMatchPath && listSourceProperties.Any(x => x.Name == item2))
                                                    {
                                                        isMatchPath = true;
                                                    }

                                                    if (isMatchPath)
                                                    {
                                                        if (item2 == "<")
                                                        {
                                                            tempPath = tempPath.Substring(0, tempPath.Length - 1);
                                                            tempPath = tempPath.Substring(0, tempPath.LastIndexOf("."));
                                                            tempPath += ".";
                                                        }
                                                        else
                                                        {
                                                            tempPath += item2 + ".";
                                                        }
                                                    }
                                                }

                                                inputFieldValue = GetValue(src, (tempPath + map.SourceField).Normalize());
                                            }
                                            else
                                            {
                                                inputFieldValue = GetValue(src, map.GetFullSourcePath()).FirstOrDefault();
                                            }

                                            FormulaType formulaType = ValidateFormula(map.Formula);

                                            propValue = CalculateFormula(formulaType, listAdditionalInputField, map.Formula, inputFieldValue);
                                        }
                                        else
                                        {
                                            propValue = Convert.ChangeType(GetValue(src, map.GetFullSourcePath()).FirstOrDefault(), propType);
                                        }
                                    }
                                    else
                                    {
                                        var sourcevalue = GetValue(src, map.GetFullSourcePath()).FirstOrDefault();
                                        propValue = map.Converter.Invoke(sourcevalue);
                                    }
                                }
                            }
                            else if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            {
                                if (propType.IsGenericType)
                                {
                                    propType = propType.GetGenericArguments().FirstOrDefault();
                                }
                                var map = propMapping.FirstOrDefault(o => o.DesField == prop.Name);
                                if (map != null)
                                {
                                    object value = null;

                                    if (!string.IsNullOrWhiteSpace(map.Formula))
                                    {
                                        Dictionary<string, object> listAdditionalInputField = new Dictionary<string, object>();

                                        var listSourceProperties = src.GetType().GetProperties();

                                        if (!string.IsNullOrWhiteSpace(map.listAdditionalPath))
                                        {
                                            List<string> list_Temp = map.listAdditionalPath.Split('|').ToList();

                                            if (list_Temp != null && list_Temp.Any())
                                            {
                                                foreach (string item in list_Temp)
                                                {
                                                    string[] tempArray = item.Split('-');
                                                    string fieldName = tempArray[0];
                                                    string fieldPath = tempArray[1];
                                                    
                                                    if (listSourceProperties != null && listSourceProperties.Any(x => fieldPath.Split('.').ToList().Any(y => x.Name == y)) && fieldPath.Contains("<"))
                                                    {
                                                        string tempPath = string.Empty;
                                                        bool isMatchPath = false;

                                                        foreach (string item2 in fieldPath.Split('.'))
                                                        {
                                                            if (!isMatchPath && listSourceProperties.Any(x => x.Name == item2))
                                                            {
                                                                isMatchPath = true;
                                                            }

                                                            if (isMatchPath)
                                                            {
                                                                if (item2 == "<")
                                                                {
                                                                    tempPath = tempPath.Substring(0, tempPath.Length - 1);
                                                                    tempPath = tempPath.Substring(0, tempPath.LastIndexOf("."));
                                                                    tempPath += ".";
                                                                }
                                                                else
                                                                {
                                                                    tempPath += item2 + ".";
                                                                }
                                                            }
                                                        }

                                                        IList<object> tempValue = GetValue(src, (tempPath + fieldName).Normalize());
                                                        listAdditionalInputField.Add(fieldName, tempValue);
                                                    }
                                                    else
                                                    {
                                                        object tempValue = GetValue(src, (fieldPath.Split('.').Last() + "." + fieldName).Normalize()).FirstOrDefault();
                                                        listAdditionalInputField.Add(fieldName, tempValue);
                                                    }

                                                    //object tempValue = GetValue(src, (fieldPath.Split('.').Last() + "." + fieldName).Normalize()).FirstOrDefault();

                                                    //listAdditionalInputField.Add(fieldName, tempValue);
                                                }
                                            }
                                        }

                                        object inputFieldValue = null;

                                        if (listSourceProperties != null && listSourceProperties.Any(x => map.SourcePath.Split('.').ToList().Any(y => x.Name == y)) && map.SourcePath.Contains("<"))
                                        {
                                            string tempPath = string.Empty;
                                            bool isMatchPath = false;

                                            foreach (string item2 in map.SourcePath.Split('.'))
                                            {
                                                if (!isMatchPath && listSourceProperties.Any(x => x.Name == item2))
                                                {
                                                    isMatchPath = true;
                                                }

                                                if (isMatchPath)
                                                {
                                                    if (item2 == "<")
                                                    {
                                                        tempPath = tempPath.Substring(0, tempPath.Length - 1);
                                                        tempPath = tempPath.Substring(0, tempPath.LastIndexOf("."));
                                                        tempPath += ".";
                                                    }
                                                    else
                                                    {
                                                        tempPath += item2 + ".";
                                                    }
                                                }
                                            }

                                            inputFieldValue = GetValue(src, (tempPath + map.SourceField).Normalize());
                                        }
                                        else
                                        {
                                            inputFieldValue = GetValue(src, map.GetFullSourcePath()).FirstOrDefault();
                                        }

                                        //object inputFieldValue = GetValue(src, map.GetFullSourcePath()).FirstOrDefault();

                                        FormulaType formulaType = ValidateFormula(map.Formula);

                                        value = CalculateFormula(formulaType, listAdditionalInputField, map.Formula, inputFieldValue);
                                    }
                                    else
                                    {
                                        value = GetValue(src, map.GetFullSourcePath()).FirstOrDefault();
                                    }
                                    

                                    if (value != null)
                                        try
                                        {
                                            propValue = Convert.ChangeType(value, propType);
                                        }
                                        catch (Exception)
                                        {
                                            if (propType == typeof(DateTime))
                                            {
                                                var convertedValue = value.ToDateTime();
                                                if (!convertedValue.Equals(DateTime.MinValue))
                                                    propValue = convertedValue;
                                            }
                                            else
                                                throw;
                                        }
                                }
                            }
                            else
                            {
                                if (propValue == null)
                                {
                                    propValue = Activator.CreateInstance(propType);
                                }

                                var map = propMapping.FirstOrDefault(o => o.DesField == prop.Name);

                                if (map != null && map.Converter != null)
                                {
                                    var sourcevalue = GetValue(src, map.GetFullSourcePath());
                                    propValue = map.Converter.Invoke(sourcevalue);
                                }
                                else
                                {
                                    if (propValue != null)
                                    {
                                        propValue = Map(src, propValue, propMapping, propParentPath);
                                    }
                                }
                            }
                            prop.SetValue(dest, propValue);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(prop.Name + "is error\n" + T2P._2015.Cross.Utility.ExceptionHandling.ExceptionHelper.GetDetailMessage(ex));
                        }
                    }
                }
            }

            return dest;
        }

        public IList<object> GetValue(object obj, string path, object parentObj = null)
        {
            if (path.Contains("BilledAmountSignIndicator"))
            {
                string str = string.Empty;
            }

            try
            {
                IList<object> retObjs = new List<object>();
                if (obj == null)
                {
                    return retObjs;
                }

                var props = path.Split('.').ToList();
                Type typeInput = obj.GetType();
                object value = obj;
                do
                {
                    if (value == null)
                    {
                        if (typeInput.IsArray)
                        {
                            value = Array.CreateInstance(typeInput.GetElementType(), 0);
                        }
                        else
                        {
                            value = Activator.CreateInstance(typeInput);
                        }
                    }

                    string prop = props[0];
                    //Root indicator
                    if (prop == "$")
                    {
                        value = obj = _source;
                        typeInput = obj.GetType();
                        props.RemoveAt(0);
                        continue;
                    }

                    if (prop == "<")
                    {
                        var parentProp = value.GetType().GetProperty("Parent");
                        if (parentProp != null)
                        {
                            var prarentValue = parentProp.GetValue(obj, null);
                            value = obj = prarentValue;
                            typeInput = obj.GetType();
                            props.RemoveAt(0);
                            continue;
                        }
                        else if (parentProp == null && value is IEnumerable == false)
                            throw new ArgumentException(string.Format("Parent object is not available", path));
                        
                    }

                    // Constant indicator
                    if (prop == "@")
                    {
                        var constVal = path.Substring(path.LastIndexOf(".") + 1);
                        if (constVal == "@")
                        {
                            constVal = string.Empty;
                        }
                        retObjs.Add(constVal);
                        return retObjs;
                    }

                    if (typeInput.IsSimpleType())
                    {
                        break;
                    }
                    else if (value is IEnumerable)
                    {
                        var values = (IEnumerable)value;
                        foreach (var item in values)
                        {
                            var objs = GetValue(item, string.Join(".", props));
                            foreach (var o in objs)
                            {
                                retObjs.Add(o);
                            }
                        }

                        return retObjs;
                    }
                    else
                    {
                        PropertyInfo propInfo = typeInput.GetProperty(prop);
                        if (propInfo != null)
                        {
                            //typeInput = propInfo.PropertyType;
                            typeInput = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
                            var propValue = propInfo.GetValue(value, null);
                            if (propValue != null)
                            {
                                value = Convert.ChangeType(propValue, typeInput);
                            }
                            else
                                value = null;
                        }
                        else
                        {
                            var parentProp = value.GetType().GetProperty("Parent");
                            bool isPathExist = false;

                            while (parentProp != null)
                            {
                                var prarentValue = parentProp.GetValue(value, null);
                                value = prarentValue;
                                typeInput = value.GetType();

                                propInfo = typeInput.GetProperty(prop);

                                if (propInfo != null)
                                {
                                    typeInput = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
                                    var propValue = propInfo.GetValue(value, null);
                                    if (propValue != null)
                                    {
                                        value = Convert.ChangeType(propValue, typeInput);
                                    }
                                    else
                                        value = null;

                                    isPathExist = true;
                                    break;
                                }
                                else
                                {
                                    parentProp = value.GetType().GetProperty("Parent");
                                }
                            }

                            if (!isPathExist) 
                            {
                                throw new ArgumentException(string.Format("Path {0} isn't existed", path));
                            }
                        }
                    }
                    props.RemoveAt(0);
                }
                while (props.Count > 0);

                if (value is IEnumerable && !(value is string))
                {
                    var values = (IEnumerable)value;
                    foreach (var item in values)
                    {
                        retObjs.Add(item);
                    }
                }
                else
                {
                    retObjs.Add(value);
                }

                return retObjs;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _source = null;
        }

        private FormulaType ValidateFormula(string formula)
        {
            if (string.IsNullOrWhiteSpace(formula))
                return FormulaType.Unknown;
            var additionPattern = @"^[$a-zA-Z0-9_.]+ = Addition\(([a-zA-Z0-9](\,[a-zA-Z0-9])*)?\) at [a-zA-Z0-9_.$]*$";
            var regex = new Regex(additionPattern);
            if (regex.IsMatch(formula))
                return FormulaType.Addition;
            var subtractionPattern = @"^[$a-zA-Z0-9_.]+ = Subtraction\([A-Za-z]+\-[a-zA-Z0-9]+\,[A-Za-z]+\-[a-zA-Z0-9]+\) at [a-zA-Z0-9_.$]*$";
            regex = new Regex(subtractionPattern);
            if (regex.IsMatch(formula))
                return FormulaType.Subtraction;

            var getFirstNamePattern = @"^GetFirstName\(\)$";
            regex = new Regex(getFirstNamePattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetFirstName;
            }

            var getLastNamePattern = @"^GetLastName\(\)$";
            regex = new Regex(getLastNamePattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetLastName;
            }

            //var dividePattern = @"^([$a-zA-Z0-9_.]+ = )?Divide\(+([A-Z0-9]+\-)?([a-zA-Z0-9])+\,+([A-Z0-9]+\-)?([a-zA-Z0-9])+\)+( at [a-zA-Z0-9_.$]*)?$";
            var dividePattern = @"^([$a-zA-Z0-9_.]+ = )?Divide\([a-zA-Z0-9,-]*\)+( at [a-zA-Z0-9_.$]*)?$";
            regex = new Regex(dividePattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.Divide;
            }

            var getIfDebitAmountPattern = @"^GetIfDebitAmount\(+\+?\-?\)$";
            regex = new Regex(getIfDebitAmountPattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetIfDebitAmount;
            }

            var getIfCreditAmountPattern = @"^GetIfCreditAmount\(+\+?\-?\)$";
            regex = new Regex(getIfCreditAmountPattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetIfCreditAmount;
            }

            var getFirstValueNotNullPattern = @"^GetFirstValueNotNull\(\)$";
            regex = new Regex(getFirstValueNotNullPattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetFirstValueNotNull;
            }

            var getSignIndicatorOfTotalPattern = @"^GetSignIndicatorOfTotal\([a-zA-Z0-9,+-:]*\)$";
            regex = new Regex(getSignIndicatorOfTotalPattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetSignIndicatorOfTotal;
            }

            var totalPattern = @"^Total\([a-zA-Z0-9,+-:]*\)$";
            regex = new Regex(totalPattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.Total;
            }

            var getDefaultValuePattern = @"^GetDefaultValue\([a-zA-Z0-9,+-:]*\)$";
            regex = new Regex(getDefaultValuePattern);
            if (regex.IsMatch(formula))
            {
                return FormulaType.GetDefaultValue;
            }

            return FormulaType.Unknown;
        }

        private object CalculateFormula(FormulaType formulaType, Dictionary<string, object> listAdditionalInputField, string formula, object inputFieldValue)
        {
            object result = null;
            switch (formulaType)
            {
                case FormulaType.GetFirstName:
                    result = inputFieldValue.ToString().Split(' ').ToList().FirstOrDefault();
                    break;

                case FormulaType.GetLastName:
                    result = inputFieldValue.ToString().Split(' ').ToList().Last();
                    break;

                case FormulaType.Divide:
                    {
                        string dividePattern = @"^Divide\(+([a-zA-Z0-9])+\,+([a-zA-Z0-9])+\)$";
                        Regex regex = new Regex(dividePattern);
                        if (regex.IsMatch(formula))
                        {
                            formula = formula.Replace("Divide(", "");
                            formula = formula.Replace(")", "");
                            string[] tempArray = formula.Split(',');

                            //string firstElementName = tempArray[0];
                            //object firstElementValue;
                            //listAdditionalInputField.TryGetValue(firstElementName, out firstElementValue);

                            string secondElementName = tempArray[1];
                            object secondElementValue;
                            listAdditionalInputField.TryGetValue(secondElementName, out secondElementValue);

                            result = (decimal)inputFieldValue / (decimal)secondElementValue;
                        }
                    }
                    break;

                case FormulaType.GetIfDebitAmount:
                    formula = formula.Replace("GetIfDebitAmount(", "");
                    formula = formula.Replace(")", "");

                    if (formula.Equals(listAdditionalInputField.FirstOrDefault().Value.ToString()))
                    {
                        result = inputFieldValue;
                    }
                    break;

                case FormulaType.GetIfCreditAmount:
                    formula = formula.Replace("GetIfCreditAmount(", "");
                    formula = formula.Replace(")", "");

                    if (formula.Equals(listAdditionalInputField.FirstOrDefault().Value.ToString()))
                    {
                        result = inputFieldValue;
                    }
                    break;

                case FormulaType.GetFirstValueNotNull:
                    if (inputFieldValue != null && !string.IsNullOrWhiteSpace(inputFieldValue.ToString()))
                    {
                        result = inputFieldValue;
                    }
                    else
                    {
                        if (listAdditionalInputField.Any(x => x.Value != null && !string.IsNullOrWhiteSpace(x.Value.ToString())))
                        {
                            result = listAdditionalInputField.FirstOrDefault(x => x.Value != null && !string.IsNullOrWhiteSpace(x.Value.ToString())).Value;
                        }                        
                    }
                    break;

                case FormulaType.GetSignIndicatorOfTotal:
                    {
                        string[] tempArray = formula.Replace("GetSignIndicatorOfTotal(", "").Replace(")", "").Split(',');
                        string debitSignIndicator = tempArray[0].Split(':')[1];
                        string creditSignIndicator = tempArray[1].Split(':')[1];

                        var listInputFieldValue = (System.Collections.IList)inputFieldValue;
                        var listAdditionalInputFieldValue = (System.Collections.IList)listAdditionalInputField.FirstOrDefault().Value;

                        decimal totalAmount = 0;

                        for (int i = 0; i < listInputFieldValue.Count; i ++)
                        {
                            totalAmount += Conversion.ObjectToDecimal(listInputFieldValue[i]) * (listAdditionalInputFieldValue[i].ToString().Trim().Equals(debitSignIndicator, StringComparison.OrdinalIgnoreCase) ? 1 : -1);
                        }

                        if (totalAmount >= 0)
                        {
                            result = debitSignIndicator;
                        }
                        else
                        {
                            result = creditSignIndicator;
                        }
                    }

                    break;
                case FormulaType.Total:
                    {
                        string[] tempArray = formula.Replace("Total(", "").Replace(")", "").Split(',');
                        string debitSignIndicator = tempArray[0].Split(':')[1];
                        string creditSignIndicator = tempArray[1].Split(':')[1];

                        var listInputFieldValue = (System.Collections.IList)inputFieldValue;
                        var listAdditionalInputFieldValue = (System.Collections.IList)listAdditionalInputField.FirstOrDefault().Value;

                        decimal totalAmount = 0;

                        for (int i = 0; i < listInputFieldValue.Count; i++)
                        {
                            totalAmount += Conversion.ObjectToDecimal(listInputFieldValue[i]) * (listAdditionalInputFieldValue[i].ToString().Trim().Equals(debitSignIndicator, StringComparison.OrdinalIgnoreCase) ? 1 : -1);
                        }

                        result = Math.Abs(totalAmount);
                    }
                    break;

                case FormulaType.GetDefaultValue:
                    {
                        if (inputFieldValue == null)
                        {
                            string defaultValue = formula.Replace("GetDefaultValue(", "").Replace(")", "");

                            result = defaultValue;
                        }
                        else
                        {
                            result = inputFieldValue;
                        }
                    }
                    break;

                default:
                    break;
            }

            return result;
        }
    }

    public static class MapperProcessExtension
    {
        public static string GetFullDesPath(this MapperObject map)
        {
            string path = string.Join(".", map.DesPath, map.DesField);
            return NormalizePath(path);
        }

        public static string GetFullSourcePath(this MapperObject map)
        {
            string path = string.Join(".", map.SourcePath, map.SourceField);
            return NormalizePath(path);
        }

        public static string NormalizePath(this string path)
        {
            path = path.Trim();
            if (path.StartsWith("."))
            {
                path = path.Substring(1).Trim();
            }
            if (path.EndsWith("."))
            {
                path = path.Substring(0, path.Length - 1).Trim();
            }
            return path;
        }

        public static bool IsSimpleType(this object val)
        {
            return val == null || val.GetType().IsSimpleType();
            //if (val != null)
            //{
            //    return val.GetType().IsSimpleType();
            //}
            //else
            //{
            //    return false;
            //}
        }

        public static bool IsSimpleType(this Type type)
        {
            TypeCode code = Type.GetTypeCode(type);
            switch (code)
            {
                case TypeCode.Boolean:
                case TypeCode.Byte:
                case TypeCode.Char:
                case TypeCode.DateTime:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.String:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
            }

            return false;
        }

        public static bool IsGenericList(this object list)
        {
            return list.GetType().GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IList<>));
        }
    }

    public interface IResolver<T, O>
    {
        //public
        O Resolve(T input);
    }

    public enum FormulaType
    {
        Addition,
        Subtraction,
        Unknown,
        GetFirstName,
        GetLastName,
        Divide,
        AddCounter,
        GetIfDebitAmount,
        GetIfCreditAmount,
        GetFirstValueNotNull,
        GetSignIndicatorOfTotal,
        Total,
        GetDefaultValue
    }
}