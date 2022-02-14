using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Newtonsoft.Json;

namespace OLT.Serialization.Json.Newtonsoft
{

    /// <summary>
    /// Serialization of <see cref="System.Enum"/> in route parameters 
    /// 
    /// <see href="https://github.com/dotnet/aspnetcore/issues/4008">Code copied from</see>
    /// </summary>
    /// <typeparam name="T"></typeparam>    
    /// <exception cref="JsonSerializationException"><see cref="System.Runtime.Serialization.EnumMemberAttribute"/> is not present on the value</exception>
    public class OltEnumRouteConverter<T> : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var val = value as string;
            if (string.IsNullOrWhiteSpace(val))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<T>(@"""" + value.ToString() + @"""");
        }
    }
}
