namespace TicketSystem.Models.Observers.Login
{
	public interface ILoginSubject
	{
		void AddLoginObservers(ILoginObserver observer);
		void RemoveLoginObservers(ILoginObserver observer);
		void NotifyLoginObservers(User user);
	}
}
