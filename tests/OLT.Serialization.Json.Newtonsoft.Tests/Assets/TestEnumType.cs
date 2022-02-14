using System.ComponentModel;
using System.Runtime.Serialization;

namespace OLT.Serialization.Json.Newtonsoft.Tests
{
    [TypeConverter(typeof(OltEnumRouteConverter<TestEnumType>))]
    public enum TestEnumType
    {
        [EnumMember(Value = "value-one")]
        Value1 = 10,

        [EnumMember(Value = "value-two")]
        Value2 = 20,

        Value3 = 30,


    }

    
}