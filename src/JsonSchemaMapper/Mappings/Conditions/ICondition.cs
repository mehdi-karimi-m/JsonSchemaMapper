using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Conditions
{
    public interface ICondition
    {
        string PropertyName { get; }
        bool IsSatisfied(JObject json);
    }
}
