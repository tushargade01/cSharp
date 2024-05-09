using System;
namespace firstProgram{
    class Program{
        static char[] spaces = new char[] {'1','2','3','4','5','6','7','8','9'};
        static int player = 1;
        static int choice;
        static int flag;
        /// <summary>
        /// draws the game board
        /// </summary>
        static void DrawBoard(){
            Console.WriteLine("      |     |     ");
            Console.WriteLine("   {0}  |  {1}  |  {2}  ",spaces[0],spaces[1],spaces[2]);
            Console.WriteLine("______|_____|_____");
            Console.WriteLine("      |     |     ");
            Console.WriteLine("      |     |     ");
            Console.WriteLine("   {0}  |  {1}  |  {2}  ",spaces[3],spaces[4],spaces[5]);
            Console.WriteLine("      |     |     ");
            Console.WriteLine("______|_____|_____");
            Console.WriteLine("      |     |     ");
            Console.WriteLine("   {0}  |  {1}  |  {2}  ",spaces[6],spaces[7],spaces[8]);
            Console.WriteLine("      |     |     ");

        }
        /// <summary>
        /// cheak if game was win, tie or Should continue
        /// </summary>
        /// <param name="agrs"></param>
        static int checkWin(){
            if(spaces[0]==spaces[1] && spaces[1]==spaces[2] ||
            spaces[3]==spaces[4] && spaces[4]==spaces[5] ||
            spaces[6]==spaces[7] && spaces[7]==spaces[8] ||
            spaces[0]==spaces[3] && spaces[3]==spaces[6] ||
            spaces[1]==spaces[4] && spaces[4]==spaces[7] ||
            spaces[2]==spaces[5] && spaces[5]==spaces[8] ||
            spaces[0]==spaces[4] && spaces[4]==spaces[8] ||
            spaces[2]==spaces[4] && spaces[4]==spaces[6]){
                return 1;
            }
            else if(spaces[0] != '1' &&
            spaces[1] != '2' &&
            spaces[2] != '3' &&
            spaces[3] != '4' &&
            spaces[4] != '5' &&
            spaces[5] != '6' &&
            spaces[6] != '7' &&
            spaces[7] != '8' &&
            spaces[8] != '9'){
                return -1;
            }
            else{
                return 0;
            }
        }
        /// <summary>
        /// draw an x on the game board
        /// </summary>
        
        static void DrawX(int pos){
            spaces[pos]='X';
        }
        static void DrawO(int pos){
            spaces[pos]='O';
        }
        public static void Main(String[] agrs){
            do{
                Console.Clear();
                Console.WriteLine("player1:X player 2:O"+"\n");
                if(player % 2==0){
                    Console.WriteLine("Player 2 turn");
                }
                else{
                    Console.WriteLine("Player 1 turn");
                }
                Console.WriteLine("\n");
                DrawBoard();
                choice = int.Parse(Console.ReadLine())-1;

                if(spaces[choice] != 'X' &&
                spaces[choice] != 'O'){
                    if(player % 2==0){
                        DrawO(choice);
                    }
                    else{
                        DrawX(choice);
                    }
                    player++;
                }
                else{
                    Console.WriteLine("sorry the row{0} marked with {1}\n",choice,spaces[choice]);
                    Console.WriteLine("Please wait 2 sec board is loding again...");
                    Thread.Sleep(2000);
                }
                flag=checkWin();
            }while(flag != 1 && flag != -1);
            Console.Clear();
            DrawBoard();
            if(flag==1){
                Console.WriteLine("Pleayer {0} has Won", (player%2)+1);
            }else{
                Console.WriteLine("Tie Game.");
            }
        }
    }
}