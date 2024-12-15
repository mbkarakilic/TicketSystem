namespace TicketSystem.Models
{
	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string PhoneNumber { get; set; }

		public bool IsAdmin { get; set; }

		public User(int id, string name, string surname, string email, bool isAdmin)
		{
			Id = id;
			Name = name;
			Surname = surname;
			Email = email;
			IsAdmin = isAdmin;
		}

	}
}
