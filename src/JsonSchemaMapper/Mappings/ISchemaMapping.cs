using JsonSchemaMapper.Mappings.Filters;

namespace JsonSchemaMapper.Mappings
{
    public interface ISchemaMapping
    {
        IFilter CreateFilter();
    }
}
