using System;
using System.Text;
using System.IO;
namespace firstProgram{
    class Program{
        public static void Main(String[] agrs){
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\demo.txt";
            if(!File.Exists(path)){
                File.Create(path);//create file
            }
            FileStream fs = File.Open(path, FileMode.Append);
            byte[] info = new UTF8Encoding(true).GetBytes("hello world!");
            fs.Write(info,0,info.Length);
            fs.Close(); 

            StreamReader sr = new StreamReader(path);
            string fileText = sr.ReadToEnd();

            System.Console.WriteLine(fileText);
        }
    }
}