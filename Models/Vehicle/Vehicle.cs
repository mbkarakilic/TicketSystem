namespace TicketSystem.Models
{
	public abstract class Vehicle
	{
		public int Id { get; set; }
		public string Brand { get; set; }

		public string Type { get; set; }

		public Vehicle(string brand, string type)
		{
			Brand = brand;
			Type = type;
		}
	}
}
