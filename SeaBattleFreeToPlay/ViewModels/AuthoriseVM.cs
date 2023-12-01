using SeaBattleFreeToPlay.Models;
using SeaBattleFreeToPlay.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SeaBattleFreeToPlay.ViewModels
{
	public class AuthoriseVM : BaseVm
	{
		public string Login { get; set; }
		private PasswordBox passwordBox;

		public BaseCommand Authorize { get; set; }
		public BaseCommand Registration { get; set; }
		public Window ThisWindow { get; private set; }

		public AuthoriseVM() 
		{
			Authorize = new BaseCommand(async () =>
			{
				var answer = await Request.Client.PostAsJsonAsync("Auth/GetToken", new AuthData { Login = this.Login, Password = this.passwordBox.Password.ToString() });
				if (answer.StatusCode == System.Net.HttpStatusCode.NotFound)
					MessageBox.Show("Неправильный логин или пароль!");
				else
				{
					var token = answer.Content.ReadAsStringAsync().Result;
					Request.SetToken(token);

					new MainWindow().Show();
					ThisWindow.Close();
				}
			});

			Registration = new BaseCommand(async () =>
			{
				var answer = await Request.Client.PostAsJsonAsync("Auth/Registration", new AuthData { Login = this.Login, Password = this.passwordBox.Password.ToString() });
				
				if(answer.StatusCode == System.Net.HttpStatusCode.BadRequest)
					MessageBox.Show(answer.Content.ReadAsStringAsync().Result);
				else
					MessageBox.Show("Вы зарегистрировались");

			});
		}



		public void RegisterPasswordBox(PasswordBox passwordBox) => this.passwordBox = passwordBox;
		public void RegisterThisWindow(Window window) => this.ThisWindow = window;
	}
}
