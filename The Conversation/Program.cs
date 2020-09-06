using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Conversation
{
    //  **********************************************************************
    //  Application:    The Conversation
    //  Author:         Smyka, Douglas M.
    //  Description:    An application that has a conversation with the user
    //                  about movies
    //  Date Created:   9.4.20
    //  Last Revisded:  9.6.20
    //  **********************************************************************
    class Program
    {
        static void Main(string[] args)


        // creating a function to call upon that sets the background 



        {
            //
            // variables
            //
            string userName;
            string favoriteGenre;
            string favoriteMovie;
            string userResponse;

            double moviesPerYear;
            double totalHours;
            double yearsAttended;
            double averageHours;
            bool compareHours;


            //      *     Opening Screen    *
            //
            // set cursor invisible, background colors, foreground colors, and clear screen
            //

            Console.CursorVisible = false;
            MakeMeGray();
            Console.Clear();

            // display application name and start program

            Console.WriteLine();
            Console.WriteLine("         The Movie Goers App");
            Console.WriteLine();
            Console.WriteLine("         Press any key to continue");
            Console.ReadKey();

            //  *********************
            //  *   Intro Screen    *
            //  *********************

            // set cursor invisible, background colors, foreground colors, and clear screen

            Console.CursorVisible = true;
            MakeMeGray();
            Console.Clear();

            //  display header

            Console.WriteLine();
            Console.WriteLine("Welcome to the Movie goers App!");
            Console.WriteLine();

            // greet user

            Console.WriteLine("Salutations!");
            Console.WriteLine("My name is Douglas.");

            // get name from user and use it 

            Console.WriteLine();
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("It is nice to meet you {0}", userName);

            // Determine if user is a Movie Goer

            Console.WriteLine();
            Console.WriteLine("Do you like to go the movies {0} ?", userName);
            userResponse = Console.ReadLine().ToLower(); // used ToLower() to fix issues with upper case answers

            // pause app

            // if the user is a moviegoer continue conversation about movies

            if (userResponse == "yes" || userResponse == "y") //added userResponse == "y" in case they type y instead of yes
            {
                // * What kind of Movies do you like *
                // set cursor invisible, background colors, foreground colors, and clear screen

                Console.CursorVisible = true;
                MakeMeGray();
                Console.Clear();

                //get users favorite movie

                Console.WriteLine("It's nice to meet a fellow movie goer!  It is my favorite pastime!");
                Console.WriteLine();
                Console.WriteLine("What is your favorite movie?");
                favoriteMovie = Console.ReadLine().ToLower(); // used ToLower() to fix issues with upper case answers

                // check and see if their favorite movie is Monty Python and the Holy Grail
                if (favoriteMovie == "monty python and the holy grail")
                {
                    Console.WriteLine("Wow {0}! We both have the same favorite Movie!", userName);
                }
                else
                {
                    Console.WriteLine("So {0}, your favorite movie is {1}?", userName, favoriteMovie);
                    Console.WriteLine("My favorite movie is Monty Python and the Holy Grail.");
                }


                //ask for favorite movie genre

                Console.WriteLine();
                Console.WriteLine("I would like to find out what types of movie you like going to the most.");
                Console.WriteLine("{0} do you like action, comedy, sci-fi or romance movies?", userName);
                favoriteGenre = Console.ReadLine();

                if (favoriteGenre == "action")
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} you have a great taste in movies, I also enjoy action flicks", userName);
                    Console.WriteLine("One of my favorite action movies is John Wick");
                }
                else if (favoriteGenre == "comedy")
                {
                    Console.WriteLine();
                    Console.WriteLine("So {0} your favoirte genre is comedy?", userName);
                    Console.WriteLine("One of my favorite comedies is We're the Millers.");
                }
                else if (favoriteGenre == "sci-fi")
                {
                    Console.WriteLine();
                    Console.WriteLine("That's awesome {0}! Sci-fi is also my favorite genre!", userName);
                    Console.WriteLine("My favorite sci-fi movie would have to be Interstellar.");
                }
                else if (favoriteGenre == "romance")
                {
                    Console.WriteLine();
                    Console.WriteLine("So {0}, you're into romance movies? I don't go to see those very often", userName);
                    Console.WriteLine("I did however enjoy going to see the romance movie Last Christmas");
                }
                else // user response invalid
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} I have not heard of the {1} before, I will have to check it out!", userName, favoriteGenre);
                }

                // pause the app

                Console.WriteLine();
                Console.WriteLine("     Press any key to continue.");
                Console.ReadKey();

                // ** Movie Goer frequency **

                //set cursor invisible, background colors, foreground colors, and clear screen

                Console.CursorVisible = true;
                MakeMeGray();
                Console.Clear();

                // display header

                Console.WriteLine();
                Console.WriteLine("     Movie Goer Frequency");
                Console.WriteLine();

                // get info from user

                Console.WriteLine("I'm curious to see how often you go to the movies.");
                Console.WriteLine();

                Console.Write("How many years have you been going to the movies?");
                userResponse = Console.ReadLine();
                yearsAttended = double.Parse(userResponse);
                Console.WriteLine();

                Console.Write("How many movies do you attend in a year?");
                userResponse = Console.ReadLine();
                moviesPerYear = double.Parse(userResponse);
                Console.WriteLine();

                Console.Write("On average how long are the movies you attend? (in hours)");
                userResponse = Console.ReadLine();
                averageHours = double.Parse(userResponse);
                Console.WriteLine();

                // do some math and figure out how many hours they have watched

                totalHours = yearsAttended * moviesPerYear * averageHours;
              
                Console.WriteLine("{0} based on the information you gave me, if my calculations are correct," +
                    "you have spent {1} hours at the Movies over the course of your lifetime!", userName, totalHours);
                
                // using a boolean to see if they've spent as much time as me at the movies

                compareHours = totalHours <= 1200;

                // using an if/else to give a different response if they've spent less time or more than me

                if (compareHours)
                {
                    Console.WriteLine("You need to pump up those numbers kid!");
                    Console.WriteLine("Come back when you've surpassed me!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("That's impressive, you like movies more than I do!");
                    Console.WriteLine();
                }
                // end the conversation

                Console.WriteLine("{0}, it has been a pleasure talking to you about movies!", userName);
                Console.WriteLine("Have a great day!");

                // pause app before closing

                Console.WriteLine();
                Console.WriteLine("     Press any key to exit. ");
                Console.ReadKey();

            }
            //
            // if user is not a movie goer
            //

            else
            {
                // not a movie goer 

                //set cursor invisible, background colors, foreground colors, and clear screen

                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("It's unfortunate that you dont enjoy going to see Movies {0}.  It has been a pleasure meeting you.", userName);

                //pause app

                Console.WriteLine();
                Console.WriteLine("     Press any key to exit");
                Console.ReadKey();

            }

            //  ** Closing screen
            //
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            // closing screen

            Console.WriteLine();
            Console.WriteLine(" So long and thanks for all he fish!");
            Console.WriteLine();
            Console.WriteLine("     \'I never could get the hang of Thursdays\' studios");
            Console.WriteLine();

            // pause app

            Console.WriteLine();
            Console.WriteLine("      Press any key to exit.");
            Console.ReadKey();
        }

        //
        //Method to be called upon throughout the program
        //
        public static void MakeMeGray()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
    }


  
}
