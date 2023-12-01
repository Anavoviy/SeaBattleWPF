using SeaBattleFreeToPlay.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SeaBattleFreeToPlay.Tools
{
	internal class Navigation : BaseVm
	{
		private static Navigation instance;
		private Page currentPage = new GamePage();
		private BaseCommand exit;

		public Window ThisWindow { get; private set; }
		public BaseCommand Exit { get => exit; set { exit = value; Signal(); } }

		public Navigation()
		{ 
			Exit = new BaseCommand(() =>
			{
				Authorise authorise = new Authorise();
				authorise.Show();	

				ThisWindow.Close();
			});

		}


		public static Navigation Instance
		{
			get
			{
				if (instance == null)
					instance = new Navigation();
				return instance;
			}
			set => instance = value;
		}

		public Page CurrentPage { get => currentPage; set { currentPage = value; Signal(); } }

		public void RegisterThisWindow(Window window) => this.ThisWindow = window;
	}
}
