using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Filters;

public class EndFilter : IFilter
{
    internal static IFilter Instance = new EndFilter();
    private EndFilter() { }
    public void SetNext(IFilter next)
    {
        throw new NotSupportedException("Can't set next on EndFilter");
    }

    public JObject Apply(JObject json)
    {
        return json;
    }
}