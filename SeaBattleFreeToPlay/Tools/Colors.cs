using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SeaBattleFreeToPlay.Tools
{
	public static class Colors
	{
		public static SolidColorBrush Bordoviy { get; set; } = new SolidColorBrush(Color.FromRgb(144, 12, 63));
		public static SolidColorBrush Blood { get; set; } = new SolidColorBrush(Color.FromRgb(199, 0, 57));
		public static SolidColorBrush Lava { get; set; } = new SolidColorBrush(Color.FromRgb(249, 76, 16));
		public static SolidColorBrush Sun { get; set; } = new SolidColorBrush(Color.FromRgb(248, 222, 34));
		public static SolidColorBrush Metall { get; set; } = new SolidColorBrush(Color.FromRgb(49, 48, 77));
	}
}
