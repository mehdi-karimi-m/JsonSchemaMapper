using JsonSchemaMapper.Mappings.Conditions;
using JsonSchemaMapper.Mappings.Operations;
using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Filters;

public class Filter : IFilter
{
    private readonly ICondition _condition;
    private readonly IOperation _operation;
    private IFilter _nextFilter;
    public Filter(ICondition condition, IOperation operation)
    {
        _condition = condition;
        _operation = operation;
        _nextFilter = EndFilter.Instance;
    }
    public void SetNext(IFilter next)
    {
        this._nextFilter = next;
    }
    public JObject Apply(JObject json)
    {
        if (_condition.IsSatisfied(json))
            json = _operation.Apply(json);

        return _nextFilter.Apply(json);
    }
}