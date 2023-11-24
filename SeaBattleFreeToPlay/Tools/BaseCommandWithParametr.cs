using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeaBattleFreeToPlay.Tools
{
	public class BaseCommandWithParametr<T> : ICommand
	{
		private Action<T> action;
		private Func<T,bool> func;

		public BaseCommandWithParametr(Action<T> action, Func<T, bool> func = null)
		{
			this.action = action;
			this.func = func;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return func == null ? true : func.Invoke((T)parameter);
		}

		public void Execute(object? parameter)
		{
			action?.Invoke((T)parameter);
		}
	}
}
