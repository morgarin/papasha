using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Class1
    {
        

        [DllImport("winmm.dll")] //импорт какой то библиотеки
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public void open(string File) //создание метода на открытие файла
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play() //метод проигрывание открытого файла
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void pause()
        {
            string command = "pause MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void stop() //метод остановки открытого файла
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void skip() //метод остановки открытого файла
        {
            string command = "skip MediaFile";
            mciSendString(command, null, 0, 0);
        }

    }
}
