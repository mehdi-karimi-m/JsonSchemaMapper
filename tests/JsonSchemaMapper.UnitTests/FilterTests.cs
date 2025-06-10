using FluentAssertions.Json;
using JsonSchemaMapper.Mappings.Conditions;
using JsonSchemaMapper.Mappings.Filters;
using JsonSchemaMapper.Mappings.Operations;
using Newtonsoft.Json.Linq;

namespace JsonSchemaMapper.UnitTests
{
    public class FilterTests
    {
        [Fact]
        public void When_absent_adding_default_value()
        {
            var json = JObject.Parse("{ 'userId': 1}");
            var expected = JObject.Parse("{ 'userId': 1, 'userType': 'Customer' }");
            var absentCondition = new AbsentCondition("userType");
            var operation = new DefaultValueOperation("userType", "Customer");
            var filter = new Filter(absentCondition, operation);

            var actual = filter.Apply(json);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Not_add_default_value_when_not_absent()
        {
            var json = JObject.Parse("{ 'userId': 1, 'userType': 'Agent'}");
            var expected = JObject.Parse("{ 'userId': 1, 'userType': 'Agent' }");
            var absentCondition = new AbsentCondition("userType");
            var operation = new DefaultValueOperation("userType", "Customer");
            var filter = new Filter(absentCondition, operation);

            var actual = filter.Apply(json);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
