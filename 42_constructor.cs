using System;
namespace firstProgram{
    class exampleProgram{
        int userNum;
        string userName;
        string userResult;
        public exampleProgram(int num, string name, string result="pass"){
            userNum=num;
            userName=name;
            userResult=result;
        }
        public static void Main(String[] args){
            exampleProgram ep = new exampleProgram(9,"tushar");
            Console.WriteLine(ep.userNum+" "+ep.userName+" "+ep.userResult);
            Console.WriteLine(ep.userNum);
            Console.WriteLine(ep.userName);
            exampleProgram ep1 = new exampleProgram(9,"rocky","fail");
            Console.WriteLine(ep1.userNum+" "+ep1.userName+" "+ep1.userResult);
        }
    }
}