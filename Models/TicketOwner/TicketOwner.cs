namespace TicketSystem.Models
{
	public class TicketOwner
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public int Gender { get; set; }
		public int SeatNumber { get; set; }

		public TicketOwner(string name, string surname, string email, string phoneNumber, int gender, int seatNumber)
		{
			Name = name;
			Surname = surname;
			Email = email;
			PhoneNumber = phoneNumber;
			Gender = gender;
			SeatNumber = seatNumber;
		}
	}
}
