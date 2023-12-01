using SeaBattleFreeToPlay.Tools;
using SeaBattleRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleFreeToPlay.ViewModels
{
	internal class GameVM : BaseVm
	{
		private List<GameDTO> listFreeGames;
		private BaseCommand createGame;

		public List<GameDTO> ListFreeGames { get => listFreeGames; set { listFreeGames = value; Signal(); } }
		public BaseCommand CreateGame { get => createGame; set { createGame = value; Signal(); } }

		public GameVM()
        {
            ListFreeGames = GameRequest.GetFreeGames();

			CreateGame = new BaseCommand(() =>
			{
				GameRequest.CreateGame();
			});

		}
    }
}
