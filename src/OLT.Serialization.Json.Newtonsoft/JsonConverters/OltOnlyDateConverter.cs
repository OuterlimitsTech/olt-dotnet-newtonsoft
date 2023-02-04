using Newtonsoft.Json.Converters;

namespace OLT.Serialization.Json.Newtonsoft
{
    /// <summary>
    /// Converts Date/Time to only date "yyyy-MM-dd"
    /// </summary>
    /// <example>
    /// Attribute Usage
    /// <code>
    /// using Newtonsoft.Json;
    /// public class SampleModel
    /// {
    ///    [JsonConverter(typeof(OltOnlyDateConverter))]
    ///    public DateTime BirthDate { get; set; }
    /// }
    /// </code>
    /// </example>
    public class OltOnlyDateConverter : IsoDateTimeConverter
    {
        public OltOnlyDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
