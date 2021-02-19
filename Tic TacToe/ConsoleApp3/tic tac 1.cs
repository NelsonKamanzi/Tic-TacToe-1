using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            string turn= "player1";
            string move;
            Console.WriteLine("Welecome to Tic-Tac-Toe");
            Console.WriteLine();
            if (turn == "player1")
            {
                turn = "player2";
               
                Console.WriteLine("X's move");
                Console.WriteLine();
                Console.WriteLine($"{A}  | {B} | {C} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"{D}  | {E} | {F} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"{G}  | {H} | {I} ");
                Console.WriteLine();
                Console.WriteLine("Choose your move:");
                move = Console.ReadLine();
                if(move == "1")
                {
                    if(A == "1")
                    {
                        A = "X";
                        Console.WriteLine("X's move > 1");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "2")
                {
                    if (B == "2")
                    {
                        B = "X";
                        Console.WriteLine("X's move > 2");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "3")
                {
                    if (C == "3")
                    {
                        C= "X";
                        Console.WriteLine("X's move > 3");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "4")
                {
                    if (D== "4")
                    {
                        D = "X";
                        Console.WriteLine("X's move > 4");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "5")
                {
                    if (E == "5")
                    {
                        E = "X";
                        Console.WriteLine("X's move > 5");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "6")
                {
                    if (F == "6")
                    {
                        F = "X";
                        Console.WriteLine("X's move > 6");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "7")
                {
                    if (G == "7")
                    {
                        G = "X";
                        Console.WriteLine("X's move > 7");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "8")
                {
                    if (H == "8")
                    {
                        H = "X";
                        Console.WriteLine("X's move > 8");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "9")
                {
                    if (I == "9")
                    {
                        I = "X";
                        Console.WriteLine("X's move > 9");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
            }
            if (turn == "player2")
            {
                turn = "player1";
                Console.Clear();
                Console.WriteLine("O's move");
                Console.WriteLine();
                Console.WriteLine($"{A}  | {B} | {C} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"{D}  | {E} | {F} ");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"{G}  | {H} | {I} ");
                Console.WriteLine();
                Console.WriteLine("Choose your move:");
                move = Console.ReadLine();
                if (move == "1")
                {
                    if (A == "1")
                    {
                        A= "O";
                        Console.WriteLine("O's move > 1");

                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "2")
                {
                    if (B == "2")
                    {
                        B = "O";
                        Console.WriteLine("O's move > 2");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "3")
                {
                    if (C == "3")
                    {
                        C = "O";
                        Console.WriteLine("O's move > 3");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "4")
                {
                    if (D == "4")
                    {
                        D = "O";
                        Console.WriteLine("O's move > 4");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "5")
                {
                    if (E == "5")
                    {
                        E = "O";
                        Console.WriteLine("O's move > 5");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "6")
                {
                    if (F == "6")
                    {
                        F = "O";
                        Console.WriteLine("0's move > 6");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "7")
                {
                    if (G == "7")
                    {
                        G = "O";
                        Console.WriteLine("O's move > 7");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "8")
                {
                    if (H == "8")
                    {
                        H = "O";
                        Console.WriteLine("O's move > 8");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }
                if (move == "9")
                {
                    if (I == "9")
                    {
                        I = "O";
                        Console.WriteLine("O's move > 9");
                    }
                    else
                    {
                        Console.WriteLine("Illegal move please try again");
                    }
                }


            }


        }
    }
}
