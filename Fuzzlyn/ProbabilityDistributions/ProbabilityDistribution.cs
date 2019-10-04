using System.Text.Json.Serialization;

namespace Fuzzlyn.ProbabilityDistributions
{
    [JsonConverter(typeof(ProbabilityDistributionConverter))]
    internal abstract class ProbabilityDistribution
    {
        public string Type => GetType().Name;
        internal abstract int Sample(Rng rng);
    }
}
