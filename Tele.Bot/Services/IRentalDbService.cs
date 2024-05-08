using Tele.Bot.Models;

namespace Tele.Bot.Services
{
    public interface IRentalDbService
    {
        Task SaveToDb(Rent entityToSave);
    }
}
