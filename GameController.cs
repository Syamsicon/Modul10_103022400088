using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400088
{
    [ApiController]
    [Route("api/Game")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game { id = "1", nama = "Valorant", developer = "Riot Games", TahunRilis = "2020", Genre = "FPS",
                Rating = 8.5, platform = ["PC"], isOnline = true, Harga = 0 },
            new Game { id = "2", nama = "GTA V", developer = "Rockstar Games", TahunRilis = "2013", Genre = "Open World",
                Rating = 9.5, platform = ["PC", "PS4", "PS5", "Xbox"],Mode = ["Single player", "Multiplayer"] ,isOnline = true, Harga = 300000 },
            new Game { id = "3", nama = "The Witcher 3", developer = "CD Projekt Red", TahunRilis = "2015", Genre = "RPG",
                Rating = 9.7, platform = ["PC", "PS4", "PS5", "Xbox", "Switch"],Mode = ["Single player"] ,isOnline = false, Harga = 250000 },
        };

        [HttpGet]
        public ActionResult<List<Game>> GetGames()
        {
            return Ok(games);
        }

        [HttpPost]
        public ActionResult addGame([FromBody] Game game)
        {
            games.Add(game);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult AddGame(string id)
        {
            var game = games.FirstOrDefault(x => x.id == id);
            if (game == null) 
            {
                return NotFound();
            }
            return Ok(game);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateGame(string id, Game game)
        {
            var idxgame = games.FindIndex(x => x.id == id);
            if (idxgame == -1) 
            {
                return NotFound();
            }
            games[idxgame] = game;
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteGame(string id) 
        {
            var game = games.FirstOrDefault(x => x.id == id);
            if (game == null)
            {
                return NotFound();
            }
            games.Remove(game);
            return Ok(game);
        }
    }
}
