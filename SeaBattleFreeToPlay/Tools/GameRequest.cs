using SeaBattleRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleFreeToPlay.Tools
{
	internal static class GameRequest
	{
		public static List<GameDTO> GetFreeGames()
		{
			return Request.Client.GetFromJsonAsync<List<GameDTO>>("GameInfo/ListGame").Result;
		}
		public static GameDTO CreateGame()
		{
			var answer = Request.Client.PostAsJsonAsync<GameDTO>("GameInfo/CreateGame", new GameDTO()).Result;
			GameDTO game = answer.Content.ReadFromJsonAsync<GameDTO>().Result;
			return game;
		}

		public static bool JoinGame(int gameId)
		{
			throw new NotImplementedException();
		}
	}
}
