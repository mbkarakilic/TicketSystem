namespace TicketSystem.Models.Observers.Payment
{
	public interface IPaymentSubject
	{
		void AddPaymentObservers(IPaymentObserver observer);
		void RemovePaymentObservers(IPaymentObserver observer);
		void NotifyPaymentObservers();
	}
}
