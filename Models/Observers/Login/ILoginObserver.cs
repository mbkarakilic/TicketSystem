namespace TicketSystem.Models.Observers.Login
{
	public interface ILoginObserver
	{
		void OnLoginNotify(User user);
	}
}
