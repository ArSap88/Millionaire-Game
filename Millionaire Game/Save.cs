using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Millionaire_Game
{
    class Save
    {
        private const string SaveLocation = @"C:\Games\Millionaire";
        internal void SaveFile(string userName, int userScore, int lastQuestionNumber)
        {
            Directory.CreateDirectory(SaveLocation);
            string savePath = SaveLocation + @"\" + userName + ".mil";
            FileInfo userSave = new FileInfo(savePath);
            if (userSave.Exists)
            {                
                userSave.Delete();
            }
            FileStream saveDataStream = userSave.OpenWrite();
            StreamWriter myStream = new StreamWriter(saveDataStream, Encoding.Default);
            myStream.WriteLine(userName);
            myStream.WriteLine(userScore);
            myStream.WriteLine(lastQuestionNumber);
            myStream.Dispose();            
        }
    }
}
