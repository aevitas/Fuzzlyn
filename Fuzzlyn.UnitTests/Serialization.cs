using System.Collections.Generic;
using System.Text.Json;
using Fuzzlyn.ProbabilityDistributions;
using Xunit;

namespace Fuzzlyn.UnitTests
{
    public class Serialization
    {
        [Fact]
        public void TestDeserializeProbabilityDistributions()
        {
            var geometric = new GeometricDistribution(10d);
            var table = new TableDistribution(new Dictionary<int, double>
            {
                {1, 10d}
            });
            var uniformRange = new UniformRangeDistribution(1, 10);
            
            var geometricJson = JsonSerializer.Serialize(geometric);
            var tableJson = JsonSerializer.Serialize(table);
            var uniformJson = JsonSerializer.Serialize(uniformRange);

            var g = JsonSerializer.Deserialize<ProbabilityDistribution>(geometricJson);
            var t = JsonSerializer.Deserialize<TableDistribution>(tableJson);
            var u = JsonSerializer.Deserialize<UniformRangeDistribution>(uniformJson);

            Assert.Equal(nameof(GeometricDistribution), g.Type);
            Assert.Equal(nameof(TableDistribution), t.Type);
            Assert.Equal(nameof(UniformRangeDistribution), u.Type);
        }
    }
}
