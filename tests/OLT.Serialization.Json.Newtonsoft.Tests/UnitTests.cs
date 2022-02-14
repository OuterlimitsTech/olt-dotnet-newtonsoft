using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace OLT.Serialization.Json.Newtonsoft.Tests
{
    public class UnitTests
    {
        [Fact]
        public void EnumRouteConverter()
        {
            Assert.Equal(TestEnumType.Value1, new OltEnumRouteConverter<TestEnumType>().ConvertFrom("value-one"));
            Assert.Equal(TestEnumType.Value2, new OltEnumRouteConverter<TestEnumType>().ConvertFrom("value-two"));
            Assert.Throws<JsonSerializationException>(() => new OltEnumRouteConverter<TestEnumType>().ConvertFrom("value-three"));
            Assert.Null(new OltEnumRouteConverter<TestEnumType>().ConvertFrom(""));
            Assert.Null(new OltEnumRouteConverter<TestEnumType>().ConvertFrom(" "));
        }

        [Fact]
        public void OnlyDateConverter()
        {
            var converter = new OltOnlyDateConverter();
            var dt = DateTime.Now;
            var expected = "\"" + dt.ToString("yyyy-MM-dd") + "\"";

            var model = new OnlyDateModel
            {
                BirthDate = dt
            };

            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                converter.WriteJson(writer, model.BirthDate, JsonSerializer.CreateDefault());
            }

            var value = sb.ToString();
            Assert.Equal(expected, value);

            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.Converters.Add(new OltOnlyDateConverter());
            var serializer = JsonSerializer.Create(serializerSettings);

            var testJson = "{\"BirthDate\":\"" + dt.ToUniversalTime().ToString("O") + "\"}";

            var jObject = JObject.Parse(testJson);
            var result = jObject.ToObject<OnlyDateModel>(serializer);

            Assert.NotNull(result);
            Assert.Equal(dt.ToUniversalTime(), result.BirthDate);

        }
    }


}