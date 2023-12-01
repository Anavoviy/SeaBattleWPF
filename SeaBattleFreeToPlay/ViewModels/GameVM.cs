using SeaBattleFreeToPlay.Tools;
using SeaBattleFreeToPlay.Views;
using SeaBattleRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SeaBattleFreeToPlay.ViewModels
{
	internal class GameVM : BaseVm
	{
		private List<GameDTO> listFreeGames;
		private BaseCommand createGame;
		private GameDTO selectedGameDTO;

		public List<GameDTO> ListFreeGames { get => listFreeGames; set { listFreeGames = value; Signal(); } }
		public GameDTO SelectedGameDTO { get => selectedGameDTO; set { selectedGameDTO = value; Signal(); } }

		public BaseCommand CreateGame { get => createGame; set { createGame = value; Signal(); } }
		public BaseCommand JoinGame { get => createGame; set { createGame = value; Signal(); } }

		public GameVM()
        {
            ListFreeGames = GameRequest.GetFreeGames();

			CreateGame = new BaseCommand(() =>
			{
				Navigation.Instance.CurrentPage = new LobbyPage(true);
			});

			JoinGame = new BaseCommand(() =>
			{
				if(GameRequest.JoinGame(SelectedGameDTO.Id))
				Navigation.Instance.CurrentPage = new LobbyPage(false);
			});

		}
    }
}
