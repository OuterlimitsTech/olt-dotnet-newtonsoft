<img src="https://user-images.githubusercontent.com/1365728/127748628-47575d74-a2fb-4539-a31e-74d8b435fc21.png" width="30%" >

[![CI](https://github.com/OuterlimitsTech/olt-dotnet-newtonsoft/actions/workflows/build.yml/badge.svg)](https://github.com/OuterlimitsTech/olt-dotnet-newtonsoft/actions/workflows/build.yml) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=OuterlimitsTech_olt-dotnet-newtonsoft&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=OuterlimitsTech_olt-dotnet-newtonsoft) [![Nuget](https://img.shields.io/nuget/v/OLT.Serialization.Json.Newtonsoft)](https://www.nuget.org/packages/OLT.Serialization.Json.Newtonsoft)

## [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) TypeCoverter, JsonConvert, & other classes targeting Netwonsoft.

| Utility/Item/Object                             | Description                               | Comments                                                                     |
| ----------------------------------------------- | ----------------------------------------- | ---------------------------------------------------------------------------- |
| [OltEnumRouteConverter](#OltEnumRouteConverter) | Serialization of Enum in route parameters | [See Also](https://github.com/dotnet/aspnetcore/issues/4008)                 |
| [OltOnlyDateConverter](#OltOnlyDateConverter)   | Serialization of DateTime to yyyy-MM-dd   | This allows for tranforming the time to the client timezone for the consumer |

### OltEnumRouteConverter - TypeConverter

```csharp
[OltEnumRouteConverter(typeof(OltEnumRouteConverter<DocumentType>))]
public enum DocumentType
{
    [EnumMember(Value = "passport")]
    Passport,

    [EnumMember(Value = "proof_of_address")]
    ProofOfAddress,
}
```

### OltOnlyDateConverter - JsonConverter that interits from IsoDateTimeConverter

```csharp
public class SampleModel
{
    [System.Text.Json.Serialization.JsonConverter(typeof(OltOnlyDateConverter))]
    public DateTime BirthDate { get; set; }
}
```
