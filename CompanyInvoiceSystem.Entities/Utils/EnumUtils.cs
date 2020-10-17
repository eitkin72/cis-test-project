using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace CompanyInvoiceSystem.Entities.Utils
{
    public class EnumUtils
    {
        public static Dictionary<int, string> EnumDictionaryByType(string enumName)
        {            
            Type enumType = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .FirstOrDefault(t => t.Name == enumName); ;

            var enumUtilsClass = typeof(EnumUtils);
            var method = enumUtilsClass.GetTypeInfo().GetDeclaredMethod("EnumDictionary");
            var genericsMethod = method.MakeGenericMethod(enumType);
            var result = genericsMethod.Invoke(enumUtilsClass, null);
            return (Dictionary<int, string>) Convert.ChangeType(result, typeof(Dictionary<int, string>));
        }

        public static Dictionary<int, string> EnumDictionary<T>()
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Type must be an enum");
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary(t => (int)(object)t, t => t.ToString());
        }
    }
}
