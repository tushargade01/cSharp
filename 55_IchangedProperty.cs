using System;
using System.ComponentModel;
namespace firstProgram{
    class Program:INotifyPropertyChanged{
        private string name;
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Name{
            get{
                return name;
            }
            set{
                name=value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }

        public static void Main(string[] args){
            Program p = new Program();
            p.Name = "tushar";
            Console.WriteLine(p.Name);
        }
    }
}