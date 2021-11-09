using System;
using System.Collections.Generic;
using System.Linq;

namespace Z_Tata_GC_Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the list of movies
            //animated movies (2)
            Movie ratatouille = new Movie("Ratatouille", MovieCategory.animated);
            Movie shrek = new Movie("Shrek", MovieCategory.animated);

            //drama movies(2)
            Movie casablanca = new Movie("Casablanca", MovieCategory.drama);
            Movie apocalypseNow = new Movie("Apocalypse Now", MovieCategory.drama);

            //horror movies(2)
            Movie psycho = new Movie("Psycho", MovieCategory.horror);
            Movie halloween = new Movie("Halloween", MovieCategory.horror);

            //scifi movies(4)
            Movie alien = new Movie("Alien", MovieCategory.scifi);
            Movie bladeRunner = new Movie("Blade Runner", MovieCategory.scifi);
            Movie starTrek = new Movie("Star Trek", MovieCategory.scifi);
            Movie dune = new Movie("Dune", MovieCategory.scifi);

            //create new sorted dictionary to hold the movie 
            //movie title = key 
            //movie category = value
            SortedDictionary<string, MovieCategory> movieDictionary = new SortedDictionary<string, MovieCategory>();
            movieDictionary.Add(shrek.MovieTitle, shrek.MovieCategory);
            movieDictionary.Add(ratatouille.MovieTitle, ratatouille.MovieCategory);
            movieDictionary.Add(casablanca.MovieTitle, casablanca.MovieCategory);
            movieDictionary.Add(apocalypseNow.MovieTitle, apocalypseNow.MovieCategory);
            movieDictionary.Add(psycho.MovieTitle, psycho.MovieCategory);
            movieDictionary.Add(halloween.MovieTitle, halloween.MovieCategory);
            movieDictionary.Add(alien.MovieTitle, alien.MovieCategory);
            movieDictionary.Add(bladeRunner.MovieTitle, bladeRunner.MovieCategory);
            movieDictionary.Add(starTrek.MovieTitle, starTrek.MovieCategory);
            movieDictionary.Add(dune.MovieTitle, dune.MovieCategory);

            bool doContinue = true;

            Console.WriteLine("Welcome to the movie list application. ");
            Console.WriteLine("This list of movies contains 10 films.");

            do //allows the user to continue if they want to go again 
            {
                //gets user category selection as an enum
                MovieCategory userChoice = (MovieCategory)GetUserChoice();
                
                //uses user selection to execute method displaying each movie type
                switch (userChoice)
                {
                    case MovieCategory.animated:
                        DisplayAnimatedMovie(movieDictionary);
                        break;
                    case MovieCategory.drama:
                        DisplayDramaMovie(movieDictionary);
                        break;
                    case MovieCategory.horror:
                        DisplayHorrorMovie(movieDictionary);
                        break;
                    case MovieCategory.scifi:
                        DisplaySciFiMovie(movieDictionary);
                        break;
                }

                //ask the user whether they would like to continue 
                doContinue = DoContinue();
            } while (doContinue);


            //prevents the application from immediately exiting 
            Console.WriteLine("Please press any key to exit: ");
            Console.ReadKey();
        }
        
        //gets user selection for movie category
        public static MovieCategory GetUserChoice()
        {
            bool isValidNumber = false;
            string userInput = "";
            int userNumber = 0;
            while (isValidNumber == false)
            {
                Console.WriteLine("Please enter the number following the category of movie you would like to view: ");
                Console.WriteLine("Animated = 1");
                Console.WriteLine("Drama = 2");
                Console.WriteLine("Horror = 3");
                Console.WriteLine("Sci-Fi = 4");
                userInput = Console.ReadLine();
                isValidNumber = ValidateNumber(userInput, out userNumber);
            }

            MovieCategory userChoice = (MovieCategory)userNumber;
            return userChoice;
        }

        //validates user choice to see if it is an int and if it is an acceptable int
        public static bool ValidateNumber(string userInput, out int userNumber)
        {
            bool isValidNumber = int.TryParse(userInput, out userNumber);

            if (isValidNumber == false)
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                isValidNumber = false;
                return isValidNumber;
            }
            else if (userNumber > 4 || userNumber < 1)
            {
                Console.WriteLine("Sorry, your selection have to be 1, 2, 3, or 4.");
                isValidNumber = false;
                return isValidNumber;
            }
            else
            {
                Console.WriteLine("Thanks!");
                isValidNumber = true;
                return isValidNumber;
            }
        }

        //prompts the user if they would like to continue and returns the relevant bool 
        public static bool DoContinue()
        {
            string userInput = "";
            Console.WriteLine("Would you like to continue? Enter yes to continue or anything else to exit.");
            userInput = Console.ReadLine();
            if (userInput.Trim().ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //displays animated films from the movie list 
        public static void DisplayAnimatedMovie(SortedDictionary<string, MovieCategory> movieDictionary)
        {
            Console.WriteLine("This list contains the following animated films: ");
            foreach (var movie in movieDictionary)
            {
                if (movie.Value == MovieCategory.animated)
                {
                    Console.WriteLine(movie.Key);
                }
            }
        }

        //displays drama films from the movie list
        public static void DisplayDramaMovie(SortedDictionary<string, MovieCategory> movieDictionary)
        {
            Console.WriteLine("This list contains the following drama films: ");
            foreach (var movie in movieDictionary)
            {
                if (movie.Value == MovieCategory.drama)
                {
                    Console.WriteLine(movie.Key);
                }
            }
        }

        //displays horror films from the movie list
        public static void DisplayHorrorMovie(SortedDictionary<string, MovieCategory> movieDictionary)
        {
            Console.WriteLine("This list contains the following horror films: ");
            foreach (var movie in movieDictionary)
            {
                if (movie.Value == MovieCategory.horror)
                {
                    Console.WriteLine(movie.Key);
                }
            }
        }

        //displays scifi films from the movie list 
        public static void DisplaySciFiMovie(SortedDictionary<string, MovieCategory> movieDictionary)
        {
            Console.WriteLine("This list contains the following scifi films: ");
            foreach (var movie in movieDictionary)
            {
                if (movie.Value == MovieCategory.scifi)
                {
                    Console.WriteLine(movie.Key);
                }
            }
        }

    }
}
