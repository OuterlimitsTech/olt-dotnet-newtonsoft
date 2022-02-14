using Newtonsoft.Json.Converters;

namespace OLT.Serialization.Json.Newtonsoft
{
    /// <summary>
    /// Converts Date/Time to only date "yyyy-MM-dd"
    /// </summary>
    /// <example>
    /// Attribute Usage
    /// <code>
    /// public class SampleModel
    /// {
    ///    [System.Text.Json.Serialization.JsonConverter(typeof(OltOnlyDateConverter))]
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


    public class OltOnlyDateConverter2 : IsoDateTimeConverter
    {
        public OltOnlyDateConverter2()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}
