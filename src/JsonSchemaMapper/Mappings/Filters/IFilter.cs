using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Filters
{
    public interface IFilter
    {
        void SetNext(IFilter filter);
        JObject Apply(JObject json);
    }
}
