using SeaBattleFreeToPlay.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SeaBattleFreeToPlay.ViewModels
{
	public class AuthoriseVM
	{
		public string Login { get; set; }
		private PasswordBox passwordBox;

		public BaseCommand Authorize { get; set; }

		public AuthoriseVM()
		{
			Authorize = new BaseCommand(() =>
			{
			});
		}



		public void RegisterPasswordBox(PasswordBox passwordBox) => this.passwordBox = passwordBox;
	}
}
