using JsonSchemaMapper.Mappings.Filters;
using Framework.Domain;
using JsonSchemaMapper.Mappings.Builders;

namespace JsonSchemaMapper.Mappings
{
    public abstract class SchemaMapping<T> : ISchemaMapping where T : DomainEvent
    {
        public IFilter CreateFilter()
        {
            var builder = CreateFilterBuilder();
            Configure(builder);
            return builder.Build();
        }
        private static FilterBuilder CreateFilterBuilder()
        {
            return new FilterBuilder();
        }
        protected abstract void Configure(IFilterBuilder builder);
    }
}
