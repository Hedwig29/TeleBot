using Tele.Bot.Models;

namespace Tele.Bot.Services
{
    public interface IRentService
    {
        Task<Root> GetRentals();
    }
}
