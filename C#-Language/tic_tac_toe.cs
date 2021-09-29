/*
Author : CsJoy
I have been studying C# and decided to make a game of tic tac toe...
First there is a cross, then a zero.
If x wins, it is displayed : X win!
If o wins, it is displayed : O win!
If nobody wins it is displayed : No one won!
If you did not make enough moves, an error is displayed!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int XorO = 1;
            int a;
            bool gameOver = false ;
            char[] game = {'1','2','3','4','5','6','7','8','9'};
            while (!gameOver)
            {
                a = Convert.ToInt32(Console.ReadLine()) - 1;
                if (XorO % 2 == 0)
                    game[a] = 'O';
                else 
                    game[a] = 'X';
                printArr(game);
                if (check(game)) 
                {
                    if(XorO % 2 == 0)
                        Console.WriteLine("O win!");
                    else
                        Console.WriteLine("X win!");  
                    gameOver = true;
                }
                else if (XorO == 9)
                {
                    gameOver = true;
                    Console.WriteLine("No one won!");
                }
                XorO++;                
            }
        }
        static bool check(char[] arr)
        {
            int checkNum = 0;
            for(int i = 0; i < 7; i += 3)
            {
                if(arr[i] == arr[i+1] && arr[i+1] == arr[i+2])
                    checkNum = 1;
            }
            for(int i = 0; i < 3; i++)
            {
                if(arr[i] == arr[i+3] && arr[i+3] == arr[i+6])
                    checkNum = 1;
            }
            if ((arr[0] == arr[4] && arr[4] == arr[8]) || arr[2] == arr[5] && arr[5] == arr[6])
                checkNum = 1;
            if (checkNum == 1)
                return true;
            else
                return false;
        }
        static void printArr(char[] arr)
        {
            for(int i = 0; i < 7; i += 3)
            {
               Console.Write(arr[i] + " | ");
               Console.Write(arr[i + 1] + " | ");
               Console.WriteLine(arr[i + 2]); 
               Console.WriteLine("---------");              
            }
            Console.WriteLine();
        }
    }
}
