using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Millionaire_Game
{
    static class Save
    {        
        internal static void SaveFile(string userName)
        {            
            string savePath = MainGame.SaveLocation + @"\" + userName + ".mil";
            FileInfo userSave = new FileInfo(savePath);
            if (userSave.Exists)
            {                
                userSave.Delete();
            }
            FileStream saveDataStream = userSave.OpenWrite();
            StreamWriter myStream = new StreamWriter(saveDataStream, Encoding.Default);
            myStream.WriteLine(Player.UserData[0]);
            myStream.WriteLine(Player.UserData[1]);
            myStream.WriteLine(Player.UserData[2]);
            myStream.Dispose();
            //File.WriteAllLines(savePath, Player.UserData, Encoding.Default);
        }
    }
}
