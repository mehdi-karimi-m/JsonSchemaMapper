using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Operations
{
    public class ErrorOperation : IOperation
    {
        private readonly string _errorText;
        public ErrorOperation(string errorText)
        {
            _errorText = errorText;
        }

        public ErrorOperation() : this("Error in mapping")
        {
        }

        public JObject Apply(JObject json)
        {
            throw new EventMappingException(this._errorText);
        }
    }
}
