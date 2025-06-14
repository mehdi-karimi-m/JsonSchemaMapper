﻿using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.Mappings.Operations
{
    public class DefaultValueOperation : IOperation
    {
        private readonly string _key;
        private readonly string _value;
        public DefaultValueOperation(string key, string value)
        {
            _key = key;
            _value = value;
        }
        public JObject Apply(JObject json)
        {
            json[_key] = _value;
            return json;
        }
    }
}
