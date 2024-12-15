using System.Diagnostics;
using TicketSystem.Models;

namespace TicketSystem.Models
{
	public class Travel
	{
		public int Id { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public string Company { get; set; }
		public double Price { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public Vehicle Vehicle { get; set; }

		public Travel(int id, string from, string to, string company, double price, string date, string time, Vehicle vehicle)
		{
			Id = id;
			From = from;
			To = to;
			Company = company;
			Price = price;
			Date = date;
			Time = time;
			Vehicle = vehicle;
		}

		public override string ToString()
		{
			return $"ID: {this.Id}, price: {Price}, company: {Company}, from: {From}, to: {To}";
		}
	}
}
