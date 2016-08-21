using BotManager.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace BotManager.Helpers
{
	public class IO
	{
		public static string AppData = MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\\BotManager\\";

		public static string CopyFolder(string sourcePath)
		{
			string randomFileName = Path.GetRandomFileName();
			string text = IO.AppData + randomFileName;
			Directory.CreateDirectory(text);
			string[] directories = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
			checked
			{
				for (int i = 0; i < directories.Length; i++)
				{
					string text2 = directories[i];
					Directory.CreateDirectory(text2.Replace(sourcePath, text));
				}
				string[] files = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);
				for (int j = 0; j < files.Length; j++)
				{
					string text3 = files[j];
					File.Copy(text3, text3.Replace(sourcePath, text), true);
				}
				return text;
			}
		}

		public static void DeleteFilesFromFolder(string sourcePath)
		{
			checked
			{
				try
				{
					if (Directory.Exists(sourcePath))
					{
						string[] files = Directory.GetFiles(sourcePath);
						for (int i = 0; i < files.Length; i++)
						{
							string path = files[i];
							File.Delete(path);
						}
						string[] directories = Directory.GetDirectories(sourcePath);
						for (int j = 0; j < directories.Length; j++)
						{
							string sourcePath2 = directories[j];
							IO.DeleteFilesFromFolder(sourcePath2);
						}
					}
					Directory.Delete(sourcePath);
				}
				catch (Exception arg_5D_0)
				{
					ProjectData.SetProjectError(arg_5D_0);
					ProjectData.ClearProjectError();
				}
			}
		}

		public static object DirectoryIsEmpty(string directory)
		{
			object result;
			try
			{
				result = (Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories).Count<string>() == 0 && Directory.GetDirectories(directory, "*", SearchOption.AllDirectories).Count<string>() == 0);
			}
			catch (DirectoryNotFoundException expr_33)
			{
				ProjectData.SetProjectError(expr_33);
				result = true;
				ProjectData.ClearProjectError();
			}
			catch (Exception expr_48)
			{
				ProjectData.SetProjectError(expr_48);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public static void Unzip(string fileName, string destination)
		{
			ZipFile.ExtractToDirectory(fileName, destination);
		}
	}
}
