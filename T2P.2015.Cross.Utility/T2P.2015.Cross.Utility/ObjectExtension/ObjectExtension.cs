using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.ObjectExtension
{
    public static class ObjectExtension
    {
        public const string RecordType = "RecordType";
        public static decimal ToNumberOfTransactionRecords(this object obj, string recordType, string attributeValueName, Dictionary<string, string> listConditions)
        {
            if (obj == null)
                return 0M;
            var properties = obj.GetType().GetProperties();
            var recordProp = properties.Where(x => x.Name.Equals(RecordType, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            if (recordProp != null)
            {
                var recordValue = recordProp.GetValue(obj, null);
                if (recordValue != null && (string.IsNullOrWhiteSpace(recordType) || recordValue.ToString().Equals(recordType, StringComparison.CurrentCultureIgnoreCase)))
                {
                    foreach (var condition in listConditions)
                    {
                        var conditionProp = properties.Where(x => x.Name.Equals(condition.Key, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                        if (conditionProp == null)
                            return 0M;
                        var conditionValue = (string)conditionProp.GetValue(obj, null);
                        if (conditionValue == null || !conditionValue.Equals(condition.Value, StringComparison.CurrentCultureIgnoreCase))
                            return 0M;
                    }
                    if(string.IsNullOrWhiteSpace(attributeValueName))
                        return 1M;
                    else
                    {
                        var attributeProp = properties.Where(x => x.Name.Equals(attributeValueName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                        if (attributeProp == null)
                            return 1M;
                        var result = 1M;
                        try
                        {
                            var typeInput = Nullable.GetUnderlyingType(attributeProp.PropertyType) ?? attributeProp.PropertyType;
                            var attributeValue = attributeProp.GetValue(obj, null);

                            if (attributeValue != null)
                            {
                                var localResult = Convert.ChangeType(attributeValue, typeInput);
                                result = Conversion.Conversion.ObjectToDecimal(localResult);
                            }
                        }
                        catch (Exception)
                        {
                            
                            throw;
                        }
                        return result;
                    }
                }
                return 0M;
            }
            var sum = 0M;
            foreach (var prop in properties)
            {
                var localValue = prop.GetValue(obj, null);
                if (localValue == null)
                    continue;
                else if (localValue.IsGenericList())
                {
                    var propValues = (IList)localValue;
                    if (propValues != null)
                        foreach (var iteratorObj in propValues)
                        {
                            sum += ToNumberOfTransactionRecords(iteratorObj, recordType, attributeValueName, listConditions);
                        }
                }
                else if (prop.PropertyType.IsClass && !prop.PropertyType.Name.Equals("String", StringComparison.CurrentCultureIgnoreCase))
                {
                    sum += ToNumberOfTransactionRecords(localValue, recordType, attributeValueName, listConditions);
                }
            }
            return sum;
        }
        private static bool IsGenericList(this object list)
        {
            return list.GetType().GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IList<>));
        }
        public static DateTime GetFirstDayOfMonth(this DateTime current)
        {
            var firstDay = new DateTime(current.Year, current.Month, 1);
            return firstDay;
        }
        public static DateTime GetLastDayOfMonth(this DateTime current)
        {
            var firstDay = current.GetFirstDayOfMonth();
            var lastDay = firstDay.AddMonths(1).AddDays(-1);
            return lastDay;
        }
    }
}
