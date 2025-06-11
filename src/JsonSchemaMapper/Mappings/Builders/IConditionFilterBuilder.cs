namespace JsonSchemaMapper.Mappings.Builders;

public interface IConditionFilterBuilder
{
    IOperationFilterBuilder WhenAbsent(string propertyName);
}