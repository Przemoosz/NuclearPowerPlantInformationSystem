namespace NuclearPowerPlantApi.Models
{
	internal sealed class PowerReactor
	{
		public int Id { get; init; }
		public string Name { get; init; }
		public string Origin { get; init; }
		public DateTime TimeOfInvention { get; init; }
		public string Coolant { get; init; }
		public string Moderator { get; init; }
		public int PercentageUraniumEnrichment { get; init; }
		public string NeutronSpectrum { get; init; }
	}
}
