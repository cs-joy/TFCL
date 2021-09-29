using System;
using System.Threading;

namespace TIC_TAC_TOE {
    class Program {
        //making array and
        //by default i am providing 0-9 where no use of zero
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is setbuf
        static int choice; //This hold the choice at which position user want to make_reverse_iterator

        //The flag variable checks who has own if it's value 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running
        static int flag = 0;

        static void Main(string[] args) {
            do {
                Console.Clear(); //Whenever loop will be again start then screen will be clear
                Console.WriteLine("------TIC TAC TOE------");
                Console.WriteLine("@Develop by CsJoy");
                Console.WriteLine("-----INFO-----");
                Console.WriteLine("Player1: X");
                Console.WriteLine("Player2: O");
                Console.WriteLine("---------------\n");

                //Checking the chance of the player
                if (player % 2 == 0) {
                    Console.WriteLine("--Second User---");
                    Console.WriteLine("Now Your Chance");
                    Console.WriteLine("-----------------");
                } else {
                    Console.WriteLine("--First User-----");
                    Console.WriteLine("Now Your Chance");
                    Console.WriteLine("-----------------");
                }
                Console.WriteLine("\n");
                Board(); //Calling the board function
                choice = int.Parse(Console.ReadLine()); //Taking users choice

                //Checking that position where user want to run is marked (With X or O) or not
                if (arr[choice] != 'X' && arr[choice] != 'O') {

                //If chance is of player 2 then mark O else mark X
                    if (player % 2 == 0) {
                        arr[choice] = 'O';
                        player++;
                    } else {
                        arr[choice] = 'X';
                        player++;
                    }
                } else { //If there is any position where user want to run and that is already marked then show message and load board again
                    Console.WriteLine(" _______________________NOTE_________________");
                    Console.WriteLine("Sorry the row {0} is already marked with {1}  ", choice, arr[choice]);
                    Console.WriteLine("Please wait 2 second, board is loading again..");
                    Console.WriteLine("______________________________________________");
                    Thread.Sleep(4000);
                }
                flag = CheckWin(); //Calling of check win
            } while (flag != 1 && flag != -1); //This loop will be run until all cell of the grid is not marked with X and O or some player is not won

            Console.Clear(); //Clearing the console
            Board(); //getting filled board again

            //If flag value is 1 then some one has win or means who players marked last time which has win
            if (flag == 1) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Result : Player {0} has won the game", (player % 2) + 1);
                Console.WriteLine("-----------------------------------");
            } else { //If flag value -1 the match will be draw and no one is winner
                Console.WriteLine("_________________");
                Console.WriteLine("Result : Draw");
                Console.WriteLine("_________________");
            }
            Console.ReadLine();
        }

        //Board method which creates board
        private static void Board() {
            Console.WriteLine("_________________ ");
            Console.WriteLine("|    |     |    |");

            Console.WriteLine("| {0}  |  {1}  |  {2} |", arr[1], arr[2], arr[3]);

            Console.WriteLine("|____|_____|____| ");

            Console.WriteLine("|    |     |    | ");

            Console.WriteLine("| {0}  |  {1}  |  {2} |", arr[4], arr[5], arr[6]);

            Console.WriteLine("|____|_____|____| ");

            Console.WriteLine("|    |     |    | ");

            Console.WriteLine("| {0}  |  {1}  |  {2} |", arr[7], arr[8], arr[9]);

            Console.WriteLine("|    |     |    | ");
            Console.WriteLine("|____|_____|____| ");
        }

        //Checking that any player has won or not
        private static int CheckWin() {
            #region Horizontal Winner Condition
            //Winner condition for first row
            if (arr[1] == arr[2] && arr[2] == arr[3]) {
                return 1;
            } else if (arr[4] == arr[5] && arr[5] == arr[6]) { //Winning condition for second row
                return 1;
            } else if (arr[6] == arr[7] && arr[7] == arr[8]) { //Winning condition for third row
                return 1;
            }
            #endregion

            #region vertical Winning Condition
            //Winning condition for first column
            else if (arr[1] == arr[4] && arr[4] == arr[7]) {
                return 1;
            }
            //Winning condition for second column
            else if (arr[2] == arr[5] && arr[5] == arr[8]) {
                return 1;
            }
            //Winning condition for third column
            else if (arr[3] == arr[6] && arr[6] == arr[9]) {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9]) {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7]) {
                return 1;
            }
            #endregion

            #region Checking For Draw
            //If the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] == '2' && arr[3] == '3' && arr[4] == '4' && arr[5] == '5' && arr[6] == '6' && arr[7] == '7' && arr[8] == '8' && arr[9] == '9') {
                return -1;
            }
            #endregion

            else {
                return 0;
            }
        }
    }
}
