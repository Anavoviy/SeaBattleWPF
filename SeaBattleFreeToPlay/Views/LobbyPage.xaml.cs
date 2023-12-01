using SeaBattleFreeToPlay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeaBattleFreeToPlay.Views
{
	/// <summary>
	/// Логика взаимодействия для LobbyPage.xaml
	/// </summary>
	public partial class LobbyPage : Page
	{
		public LobbyPage(bool iCreator)
		{
			InitializeComponent();
			DataContext = new LoggyVM(iCreator);
			var context = (LoggyVM)DataContext;
			context.RegisterFields(FieldOne, FieldTwo);
		}
	}
}
