using SeaBattleFreeToPlay.Tools;
using SeaBattleRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace SeaBattleFreeToPlay.ViewModels
{
	public class LoggyVM : BaseVm
	{
		Canvas Field1 { get; set; }
		Canvas Field2 { get; set; }

		GameDTO Game { get; set; }

		public LoggyVM(bool iCreator) {
			if(iCreator) 
				Game = GameRequest.CreateGame();
		}

		void FillField(byte[] bytes, bool isLeft)
		{
			int j = 0;

			for(int i = 0; i < bytes.Length; i++)
			{
				if ((i - 9) == 0 || (i - 9) % 10 == 0)
					j++;

                Rectangle rec = new Rectangle();
				rec.Height = 45;
				rec.Width = 45;
				rec.RadiusX = 3;
				rec.RadiusY = 3;
				switch (bytes[i])
				{
					case 0:
						rec.Fill = Colors.Lava;
						break;
					case 1:
						rec.Fill = Colors.Metall;
						break;
					case 2:
						rec.Fill = Colors.Blood;
						break;
					case 3:
						rec.Fill = Colors.Sun;
						break;
				}
				if(i != 0)
					rec.SetValue(Canvas.LeftProperty, (45 * i));
				if(j != 0)
					rec.SetValue(Canvas.TopProperty, (45 * j));

				if (isLeft)
					Field1.Children.Add(rec);
				else
					Field2.Children.Add(rec);
				
			}
		}

		public void RegisterFields(Canvas filed1,  Canvas filed2)
		{
			Field1 = filed1;
			Field2 = filed2;

			FillField(Game.FieldUser1, true);
			FillField(Game.FieldUser2, false);
		} 
	}
}
