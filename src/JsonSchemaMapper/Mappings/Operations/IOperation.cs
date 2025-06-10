using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Operations
{
    public interface IOperation
    {
        JObject Apply(JObject json);
    }
}
