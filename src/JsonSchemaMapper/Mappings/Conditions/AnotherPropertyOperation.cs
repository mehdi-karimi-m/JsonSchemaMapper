using JsonSchemaMapper.Mappings.Operations;
using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Conditions;

public class AnotherPropertyOperation : IOperation
{
    private readonly string _key;
    private readonly string _otherProperty;
    internal AnotherPropertyOperation(string key, string otherProperty)
    {
        _key = key;
        _otherProperty = otherProperty;
    }
    public JObject Apply(JObject json)
    {
        json[_key] = json[_otherProperty];
        json.Remove(_otherProperty);
        return json;
    }
}