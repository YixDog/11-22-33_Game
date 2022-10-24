using System;
namespace pbl_project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[9] { "Ömer", "Faruk", "Keskin", "Yiğit", "Can", "Halil", "İbrahim", "Kaan", "Yıldız" };
            int[] scores = new int[9] { 300, 290, 270, 250, 230, 200, 190, 180, 10 };
            Console.SetWindowSize(Console.WindowWidth*11/10,Console.WindowHeight*70/100);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(
                                "\n░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  ████████╗░█████╗░\n" +
                                "░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  ╚══██╔══╝██╔══██╗\n" +
                                "░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  ░░░██║░░░██║░░██║\n" +
                                "░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  ░░░██║░░░██║░░██║\n" +
                                "░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  ░░░██║░░░╚█████╔╝\n" +
                                "░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ░░░╚═╝░░░░╚════╝░\n" +
                                "                                                            \n" +
                                "░░███╗░░░░███╗░░░░░░░░██████╗░██████╗░░░░░░░██████╗░██████╗░\n" +
                                "░████║░░░████║░░░░░░░░╚════██╗╚════██╗░░░░░░╚════██╗╚════██╗\n" +
                                "██╔██║░░██╔██║░░█████╗░░███╔═╝░░███╔═╝█████╗░█████╔╝░█████╔╝\n" +
                                "╚═╝██║░░╚═╝██║░░╚════╝██╔══╝░░██╔══╝░░╚════╝░╚═══██╗░╚═══██╗\n" +
                                "███████╗███████╗░░░░░░███████╗███████╗░░░░░░██████╔╝██████╔╝\n" +
                                "╚══════╝╚══════╝░░░░░░╚══════╝╚══════╝░░░░░░╚═════╝░╚═════╝░\n" +
                                "                                    \n" +
                                "░██████╗░░█████╗░███╗░░░███╗███████╗\n" +
                                "██╔════╝░██╔══██╗████╗░████║██╔════╝\n" +
                                "██║░░██╗░███████║██╔████╔██║█████╗░░\n" +
                                "██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░\n" +
                                "╚██████╔╝██║░░██║██║░╚═╝░██║███████╗\n" +
                                "░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝");
                System.Threading.Thread.Sleep(1000 / (i));
              
                Console.Clear();
            }
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                int cursorx = 1, cursory = 1;   // first position of cursor
                int whichLine, score = 0, whichOrder = 1, matches = 1, index, z, temp;
                string temps, selected;
                ConsoleKeyInfo cki;
                char[] GameLine1 = new char[32];
                char[] GameLine2 = new char[32];
                char[] GameLine3 = new char[32];
                Console.WriteLine("     Welcome to 11-22-33 Game ");
                Console.WriteLine("     MENU ");
                Console.WriteLine("     1-) Play the game ");
                Console.WriteLine("     2-) Score table ");
                Console.WriteLine("     3-) How to play the game ");
                Console.WriteLine("     4-) Exit");
                selected = Console.ReadLine();
                switch (selected)
                {
                    case "4":
                   
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine(

"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░▄▄▀▀▀▀▀▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░▄▀░░░░░░░▀▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░▄▀░░░▄▄░░░░▀▀▀▀▀▀▀▄▄▀▀▀▀▀▀▀▀▀▀▀▀▄▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░█░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░▀▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░█░░░░██▄████▄░██▄░░░░▄██░▄████▄░░░░▀▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░█░░░░██▀░░▀██▄░██▄░░██▀░██▀░▄██░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░█░░░░██░░░░███░░█████▀░░██▄█▀▀░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░█░░░░███▄▄███▀░░░▀██▀░░░▀██▄▄▄██░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░▀▄░░░░▀▀▀▀▀▀░░░░░██▀░░░░░░▀▀▀▀▀░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░▀▄░░░░░░░░░░░░░██▀░░░▄▄░░░░░░░░░▄▄▀░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▄░░░▀▀░░░▄▀░▀▀▀▀▀▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▀▄░░░░░░▄▀░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▀▀▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n");
                        System.Threading.Thread.Sleep(1500);
                        Environment.Exit(0);
                        break;
                    case "3":
                        Console.WriteLine("1. The game is played on a 3x30 board.\n\n" +
                            "2.In the beginning, the board is randomly filled with 30 random numbers which are 1, 2 and 3.\n\n" +
                            "3.The arrow keys on the keyboard are used to move the cursor and WASD keys are used to move the number under the cursor.\n\n" +
                            "4. WASD keys can move only the single numbers(the left and right side of the number should be empty).\n\nW : Moves the number one square up.\nS : Moves the number one square down.\nA : Moves the number to the left as much as it can go.\nD : Moves the number to the right as much as it can go.\n\n" +
                            "5. If two identical numbers come together on the same line(by player moves or randomly),\nMatching numbers are deleted from the board\nThe player's score increases by 10 points.  \nNew two random numbers are generated and randomly placed on the board  ");
                        Console.WriteLine("\n\nPress any key to return to the main menu.");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("High Scores Table\n-------------------");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.WriteLine(names[i] + "\t\t" + scores[i]);
                        }
                        Console.WriteLine("\n\nPress any key to return to the main menu.");
                        Console.ReadKey();
                        break;
                    case "1":
                        Console.Clear();
                        for (int j = 0; j < 32; j++)
                        {
                            GameLine1[j] = Convert.ToChar(" ");
                            GameLine2[j] = Convert.ToChar(" ");
                            GameLine3[j] = Convert.ToChar(" ");
                        }
                        //    Static screen parts
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("+------------------------------+");
                        for (int j = 1; j < 4; j++)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.WriteLine("|                              |");
                        }
                        Console.SetCursorPosition(0, 4);
                        Console.WriteLine("+------------------------------+");
                        Console.SetCursorPosition(50, 3);
                        Console.Write("Please press ESC key to return to main menu");
                        //   randomly create numbers part
                        Random rnd = new Random();
                        while (whichOrder < 31)
                        {
                            whichLine = rnd.Next(1, 4);
                            index = rnd.Next(1, 31);
                            if (GameLine1[index] == Convert.ToChar(" ") && whichLine == 1)
                            {
                                GameLine1[index] = Convert.ToChar(rnd.Next(1, 4));
                                Console.SetCursorPosition(index, 1);
                                switch (GameLine1[index])
                                {
                                    case '\u0001':
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case '\u0002':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                    case '\u0003':
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                }
                                Console.Write(Convert.ToInt16(GameLine1[index]));
                                whichOrder++;
                            }
                            else if (GameLine2[index] == Convert.ToChar(" ") && whichLine == 2)
                            {
                                GameLine2[index] = Convert.ToChar(rnd.Next(1, 4));
                                Console.SetCursorPosition(index, 2);
                                switch (GameLine2[index])
                                {
                                    case '\u0001':
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case '\u0002':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                    case '\u0003':
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                }
                                Console.Write(Convert.ToInt16(GameLine2[index]));
                                whichOrder++;
                            }
                            else if (GameLine3[index] == Convert.ToChar(" ") && whichLine == 3)
                            {
                                GameLine3[index] = Convert.ToChar(rnd.Next(1, 4));
                                Console.SetCursorPosition(index, 3);
                                switch (GameLine3[index])
                                {
                                    case '\u0001':
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case '\u0002':
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                    case '\u0003':
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                }
                                Console.Write(Convert.ToInt16(GameLine3[index]));
                                whichOrder++;
                            }
                        }
                        // --- Main game loop   
                        while (true)
                        {
                            for (int j = 1; j < 30; j++)        // place that control whether there is a match.
                            {
                                if (GameLine1[j] == GameLine1[j + 1] && (GameLine1[j] != Convert.ToChar(" ")))
                                {
                                    GameLine1[j] = Convert.ToChar(" ");
                                    GameLine1[j + 1] = Convert.ToChar(" ");
                                    Console.SetCursorPosition(j, 1);
                                    Console.Write("  ");
                                    Console.SetCursorPosition(50, 1);
                                    score += 10;
                                    Console.WriteLine("Score: " + score);
                                    matches += 2;
                                    Console.SetCursorPosition(cursorx, cursory);
                                }
                                if (GameLine2[j] == GameLine2[j + 1] && GameLine2[j] != Convert.ToChar(" "))
                                {
                                    GameLine2[j] = Convert.ToChar(" ");
                                    GameLine2[j + 1] = Convert.ToChar(" ");
                                    Console.SetCursorPosition(j, 2);
                                    Console.Write("  ");
                                    Console.SetCursorPosition(50, 1);
                                    score += 10;
                                    Console.WriteLine("Score: " + score);
                                    matches += 2;
                                }
                                if (GameLine3[j] == GameLine3[j + 1] && GameLine3[j] != Convert.ToChar(" "))
                                {
                                    GameLine3[j] = Convert.ToChar(" ");
                                    GameLine3[j + 1] = Convert.ToChar(" ");
                                    Console.SetCursorPosition(j, 3);
                                    Console.Write("  ");
                                    Console.SetCursorPosition(50, 1);
                                    score += 10;
                                    Console.WriteLine("Score: " + score);
                                    matches += 2;
                                }
                                whichOrder = 1;
                                while (whichOrder < matches)        // place that control whether two number were deleted.
                                {
                                    whichLine = rnd.Next(1, 4);
                                    index = rnd.Next(1, 31);
                                    if (GameLine1[index] == Convert.ToChar(" ") && whichLine == 1)
                                    {
                                        GameLine1[index] = Convert.ToChar(rnd.Next(1, 4));
                                        Console.SetCursorPosition(index, 1);
                                        switch (GameLine1[index])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.Write(Convert.ToInt16(GameLine1[index]));
                                        whichOrder++;
                                    }
                                    else if (GameLine2[index] == Convert.ToChar(" ") && whichLine == 2)
                                    {
                                        GameLine2[index] = Convert.ToChar(rnd.Next(1, 4));
                                        Console.SetCursorPosition(index, 2);
                                        switch (GameLine2[index])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.Write(Convert.ToInt16(GameLine2[index]));
                                        whichOrder++;
                                    }
                                    else if (GameLine3[index] == Convert.ToChar(" ") && whichLine == 3)
                                    {
                                        GameLine3[index] = Convert.ToChar(rnd.Next(1, 4));
                                        Console.SetCursorPosition(index, 3);
                                        switch (GameLine3[index])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.Write(Convert.ToInt16(GameLine3[index]));
                                        whichOrder++;
                                    }
                                }
                                matches = 1;
                            }
                            Console.SetCursorPosition(cursorx, cursory);
                            if (Console.KeyAvailable)
                            {       // true: there is a key in keyboard x
                                cki = Console.ReadKey(true);       // true: do not write character 
                                if (cki.Key == ConsoleKey.RightArrow && cursorx < 30)
                                {   // key and boundary control
                                    cursorx++;
                                    Console.SetCursorPosition(cursorx, cursory);
                                    // delete X (old position)                                    
                                }
                                else if (cki.Key == ConsoleKey.LeftArrow && cursorx > 1)
                                {
                                    cursorx--;
                                    Console.SetCursorPosition(cursorx, cursory);
                                }
                                else if (cki.Key == ConsoleKey.UpArrow && cursory > 1)
                                {
                                    cursory--;
                                    Console.SetCursorPosition(cursorx, cursory);
                                }
                                else if (cki.Key == ConsoleKey.DownArrow && cursory < 3)
                                {
                                    cursory++;
                                    Console.SetCursorPosition(cursorx, cursory);
                                }
                                //wasd
                                //for D 
                                if (cki.Key == ConsoleKey.D && cursorx < 30)
                                {
                                    if (cursory == 1 && GameLine1[cursorx] != Convert.ToChar(" ") && GameLine1[cursorx + 1] == Convert.ToChar(" ") && GameLine1[cursorx - 1] == Convert.ToChar(" "))
                                    {
                                        z = 1;
                                        while (GameLine1[cursorx + z] == Convert.ToChar(" ") && cursorx < 31 - z)
                                        {
                                            z++;
                                        }
                                        GameLine1[cursorx + z - 1] = GameLine1[cursorx];
                                        GameLine1[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine1[cursorx]);
                                        cursorx += z - 1;
                                        switch (GameLine1[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine1[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                    else if (cursory == 2 && GameLine2[cursorx] != Convert.ToChar(" ") && GameLine2[cursorx + 1] == Convert.ToChar(" ") && GameLine2[cursorx - 1] == Convert.ToChar(" "))
                                    {
                                        z = 1;
                                        while (GameLine2[cursorx + z] == Convert.ToChar(" ") && cursorx < 31 - z)
                                        {
                                            z++;
                                        }
                                        GameLine2[cursorx + z - 1] = GameLine2[cursorx];
                                        GameLine2[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine2[cursorx]);
                                        cursorx += z - 1;
                                        switch (GameLine2[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine2[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }

                                    else if (cursory == 3 && GameLine3[cursorx] != Convert.ToChar(" ") && GameLine3[cursorx + 1] == Convert.ToChar(" ") && GameLine3[cursorx - 1] == Convert.ToChar(" "))
                                    {
                                        z = 1;
                                        while (GameLine3[cursorx + z] == Convert.ToChar(" ") && cursorx < 31 - z)
                                        {
                                            z++;
                                        }
                                        GameLine3[cursorx + z - 1] = GameLine3[cursorx];
                                        GameLine3[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine3[cursorx]);
                                        cursorx += z - 1;
                                        switch (GameLine3[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine3[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                }
                                //for A
                                if (cki.Key == ConsoleKey.A && cursorx > 1)
                                {
                                    if (cursory == 1 && GameLine1[cursorx] != Convert.ToChar(" ") && GameLine1[cursorx - 1] == Convert.ToChar(" ") && GameLine1[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        z = -1;
                                        while (GameLine1[cursorx + z] == Convert.ToChar(" ") && cursorx + z > 0)
                                        {
                                            z--;
                                        }
                                        GameLine1[cursorx + z + 1] = GameLine1[cursorx];
                                        GameLine1[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine1[cursorx]);
                                        cursorx += (z + 1);
                                        switch (GameLine1[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine1[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                    else if (cursory == 2 && GameLine2[cursorx] != Convert.ToChar(" ") && GameLine2[cursorx - 1] == Convert.ToChar(" ") && GameLine2[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        z = -1;
                                        while (GameLine2[cursorx + z] == Convert.ToChar(" ") && cursorx + z > 0)
                                        {
                                            z--;
                                        }
                                        GameLine2[cursorx + z + 1] = GameLine2[cursorx];
                                        GameLine2[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine2[cursorx]);
                                        cursorx += (z + 1);
                                        switch (GameLine2[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine2[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                    else if (cursory == 3 && GameLine3[cursorx] != Convert.ToChar(" ") && GameLine3[cursorx - 1] == Convert.ToChar(" ") && GameLine3[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        z = -1;
                                        while (GameLine3[cursorx + z] == Convert.ToChar(" ") && cursorx + z > 0)
                                        {
                                            z--;
                                        }
                                        GameLine3[cursorx + z + 1] = GameLine3[cursorx];
                                        GameLine3[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine3[cursorx]);
                                        cursorx += (z + 1);
                                        switch (GameLine3[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine3[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                }
                                // W
                                if (cki.Key == ConsoleKey.W && cursory > 1)
                                {
                                    if (cursory == 2 && GameLine2[cursorx] != Convert.ToChar(" ") && GameLine1[cursorx] == Convert.ToChar(" ") && GameLine2[cursorx - 1] == Convert.ToChar(" ") && GameLine2[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        GameLine1[cursorx] = GameLine2[cursorx];
                                        GameLine2[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine2[cursorx]);
                                        cursory--;
                                        switch (GameLine1[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine1[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                    else if (cursory == 3 && GameLine3[cursorx] != Convert.ToChar(" ") && GameLine2[cursorx] == Convert.ToChar(" ") && GameLine3[cursorx - 1] == Convert.ToChar(" ") && GameLine3[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        GameLine2[cursorx] = GameLine3[cursorx];
                                        GameLine3[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine3[cursorx]);
                                        cursory--;
                                        switch (GameLine2[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine2[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                }
                                // S
                                if (cki.Key == ConsoleKey.S && cursory < 30)
                                {
                                    if (cursory == 1 && GameLine1[cursorx] != Convert.ToChar(" ") && GameLine2[cursorx] == Convert.ToChar(" ") && GameLine1[cursorx - 1] == Convert.ToChar(" ") && GameLine1[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        GameLine2[cursorx] = GameLine1[cursorx];
                                        GameLine1[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine1[cursorx]);
                                        cursory++;
                                        switch (GameLine2[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine2[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                    else if (cursory == 2 && GameLine2[cursorx] != Convert.ToChar(" ") && GameLine3[cursorx] == Convert.ToChar(" ") && GameLine2[cursorx - 1] == Convert.ToChar(" ") && GameLine2[cursorx + 1] == Convert.ToChar(" "))
                                    {
                                        GameLine3[cursorx] = GameLine2[cursorx];
                                        GameLine2[cursorx] = Convert.ToChar(" ");
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(GameLine2[cursorx]);
                                        cursory++;
                                        switch (GameLine3[cursorx])
                                        {
                                            case '\u0001':
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                break;
                                            case '\u0002':
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                break;
                                            case '\u0003':
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                break;
                                        }
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.Write(Convert.ToInt16(GameLine3[cursorx]));
                                        Console.SetCursorPosition(cursorx, cursory);
                                    }
                                }
                                if (cki.Key == ConsoleKey.Escape)
                                {
                                    if (score > scores[8])
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine(
                                                            "\n\n░█████╗░░█████╗░███╗░░██╗░██████╗░██████╗░░█████╗░████████╗██╗░░░██╗██╗░░░░░░█████╗░████████╗██╗░█████╗░███╗░░██╗░██████╗\n" +
                                                            "██╔══██╗██╔══██╗████╗░██║██╔════╝░██╔══██╗██╔══██╗╚══██╔══╝██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║██╔════╝\n" +
                                                            "██║░░╚═╝██║░░██║██╔██╗██║██║░░██╗░██████╔╝███████║░░░██║░░░██║░░░██║██║░░░░░███████║░░░██║░░░██║██║░░██║██╔██╗██║╚█████╗░\n" +
                                                            "██║░░██╗██║░░██║██║╚████║██║░░╚██╗██╔══██╗██╔══██║░░░██║░░░██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║██║░░██║██║╚████║░╚═══██╗\n" +
                                                            "╚█████╔╝╚█████╔╝██║░╚███║╚██████╔╝██║░░██║██║░░██║░░░██║░░░╚██████╔╝███████╗██║░░██║░░░██║░░░██║╚█████╔╝██║░╚███║██████╔╝\n" +
                                                            "░╚════╝░░╚════╝░╚═╝░░╚══╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝╚═════╝░");
                                        Console.WriteLine("-->You have earned the right to enter the high score table.");
                                        Console.WriteLine("-->Please enter your name");
                                        Console.Write("-->");
                                        names[8] = Console.ReadLine();
                                        scores[8] = score;
                                        for (int i = scores.Length - 1; i >= 1; i--)
                                        {
                                            if (scores[i] > scores[i - 1])
                                            {
                                                temp = scores[i - 1];
                                                scores[i - 1] = scores[i];
                                                scores[i] = temp;
                                                temps = names[i - 1];
                                                names[i - 1] = names[i];
                                                names[i] = temps;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    }

                                    break;
                                }
                            }
                        }
                        break;
                }
            }
        }//main in parantezi.
    }
}