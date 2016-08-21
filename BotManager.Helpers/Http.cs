using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Net;

namespace BotManager.Helpers
{
	public class Http
	{
		public static void DownloadRepository(string fileUrl, string fileName)
		{
			HttpWebResponse httpWebResponse;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(fileUrl);
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			catch (Exception expr_1C)
			{
				ProjectData.SetProjectError(expr_1C);
				ProjectData.ClearProjectError();
				return;
			}
			long arg_30_0 = httpWebResponse.ContentLength;
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			checked
			{
				while (true)
				{
					byte[] array = new byte[4096];
					int num = httpWebResponse.GetResponseStream().Read(array, 0, 4096);
					int num2;
					num2 += num;
					if (num == 0)
					{
						break;
					}
					fileStream.Write(array, 0, num);
				}
				httpWebResponse.GetResponseStream().Close();
				fileStream.Close();
			}
		}
	}
}
