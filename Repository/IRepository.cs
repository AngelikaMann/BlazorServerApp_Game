using BlazorApp_Game.Models;

namespace BlazorApp_Game.Repository
{
    public interface IRepository
    {

        List<Game> GetAllGames();
    }
}
