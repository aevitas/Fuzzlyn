using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fuzzlyn.ProbabilityDistributions
{
    internal class ProbabilityDistributionConverter : JsonConverter<ProbabilityDistribution>
    {
        public override ProbabilityDistribution Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert != typeof(ProbabilityDistribution))
                return (ProbabilityDistribution) JsonSerializer.Deserialize(ref reader, typeToConvert);

            var obj = JsonSerializer.Deserialize<ProbabilityDistribution>(ref reader);

            switch (obj.Type)
            {
                case nameof(GeometricDistribution):
                    return JsonSerializer.Deserialize<GeometricDistribution>(ref reader);
                case nameof(UniformRangeDistribution):
                    return JsonSerializer.Deserialize<UniformRangeDistribution>(ref reader);
                case nameof(TableDistribution):
                    return JsonSerializer.Deserialize<TableDistribution>(ref reader);
                default:
                    throw new NotSupportedException($"Probability Distribution of type {obj.Type} is not supported.");
            }
        }

        public override void Write(Utf8JsonWriter writer, ProbabilityDistribution value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString(nameof(value.Type), value.Type);

            if (value is GeometricDistribution g)
            {
                writer.WriteNumber(nameof(g.BaseValue), g.BaseValue);
                writer.WriteNumber(nameof(g.SuccessProbability), g.SuccessProbability);
            }

            if (value is TableDistribution t)
            {
                writer.WriteStartArray();

                foreach (var i in t.Pairs)
                {
                    writer.WriteStartObject();
                    writer.WriteNumberValue(i.Key);
                    writer.WriteNumberValue(i.Value);
                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
            }

            if (value is UniformRangeDistribution u)
            {
                writer.WriteNumber(nameof(u.Min), u.Min);
                writer.WriteNumber(nameof(u.Max), u.Max);
            }

            writer.WriteEndObject();
        }
    }
}
