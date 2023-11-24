using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleFreeToPlay.Tools
{
	public static class Request
	{
		private static HttpClient http;

		public static HttpClient Client 
		{ 
			get 
			{
				if (http == null)
				{
					http = new HttpClient();
					http.BaseAddress = new Uri("https://localhost:7138");
				}
				return http; 
			} }

		public static void SetBaseAddress(string address) => http.BaseAddress = new Uri(address);

		

	}
}
