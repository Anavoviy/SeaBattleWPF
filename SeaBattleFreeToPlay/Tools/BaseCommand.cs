using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeaBattleFreeToPlay.Tools
{
	public class BaseCommand : ICommand
	{
		private Action action;
		private Func<bool> func;

		public BaseCommand(Action action, Func<bool> func = null)
		{
			this.action = action;
			this.func = func;
		}

		public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return func == null ? true : func.Invoke();
		}

		public void Execute(object? parameter)
		{
			action?.Invoke();
		}
	}
}
