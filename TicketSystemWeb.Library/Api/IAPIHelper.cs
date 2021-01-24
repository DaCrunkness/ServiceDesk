using System.Net.Http;
using System.Threading.Tasks;
using TicketSystemWeb.Library.Models;

namespace TicketSystemWeb.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        void ClearHeaders();
    }
}