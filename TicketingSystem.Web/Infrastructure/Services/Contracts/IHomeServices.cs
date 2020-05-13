using System.Collections.Generic;
namespace TicketingSystem.Web.Infrastructure.Services.Contracts
{
    
    using TicketingSystem.Web.ViewMoldes.Home;

    public interface IHomeServices
    {
        IList<TicketViewModel> GetIndexViewModel(int numberOfTickets);
    }
}
