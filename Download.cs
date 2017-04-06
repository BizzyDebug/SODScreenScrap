using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SODScreenScrap
{
	public class Download
	{
		Configuration _configuration;

		public Download()
		{
			_configuration = new Configuration();
			Download3(DownloadWebPage());
		}

		private void Download3(string html)
		{
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(html);

			var t = doc.DocumentNode.SelectNodes("//tbody//tr//td");
			var x1 = from x in t.Nodes() where x.Name == "#text" select new Member { Name = x.InnerText };
			foreach (var c in x1)
			{
				if (c.Name != "span")
				{
					Console.WriteLine(c.Name);
				}
			}

			//var t = doc.DocumentNode.SelectNodes("//tbody//tr");

			//var x1 = from x in t select new Member { Name = x.InnerHtml };

			//foreach (var c in x1)
			//{
			//	if (c.Name != "span")
			//	{
			//		Console.WriteLine(c.Name);
			//	}
			//}
		}

		private void Download2()
		{
			string web = @"http://squadsofdeath.com/squad/bc4e94b4-41b5-11e4-9998-0659f6004fae/members";

			WebRequest request = WebRequest.Create(web);

			var stream = request.GetRequestStream();
			byte[] xx = new byte[10000];
			stream.Write(xx, 0, xx.Length);

			stream.Close();

			WebResponse response = request.GetResponse();


		}

		private string DownloadWebPage()
		{
			string web = _configuration.QRise;

			WebClient client = new WebClient();
			return client.DownloadString(web);
			//HttpClient clint = new HttpClient();

			//using (var response = await clint.GetAsync(web))
			//{
			//	Console.WriteLine(response.Content);
			//}

			//StreamReader reader = new StreamReader(request.GetRequestStream());
			//string line;
			//while (reader.Peek()  >= 0)
			//{
			//	Console.WriteLine(reader.ReadLine());
			//}

			//Console.ReadLine();
		}
	}
}
