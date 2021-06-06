using System;
using System.IO;

namespace THPS.Models
{
	public static class FileSaver
	{
		public static void SaveFile(string myGame)
		{
			string myfolder= AppDomain.CurrentDomain.BaseDirectory.ToString() + "SavedFiles/";
			string myFile = "";
			if (!Directory.Exists(myfolder))
			{
				Directory.CreateDirectory(myfolder);
			}
			switch (myGame)
			{
				case "THPS 1+2":
					myFile = myfolder + "thps12.txt";
					break;
			}
			if (!File.Exists(myFile) && myFile != string.Empty)
				File.Create(myFile);
		}
	}
}
