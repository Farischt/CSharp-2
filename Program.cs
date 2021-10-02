using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_TP3
{
    class Program
    {

        static void Main(string[] args)
        {
            // Exercice 1
            MovieCollection moviesCollec = new MovieCollection();
            List<MovieCollection.WaltDisneyMovies> waltMovies = moviesCollec.Movies;

            // Q1
            Console.WriteLine("Number of movies : " + waltMovies.Count());

            // Q2
            Console.WriteLine("Number of movies containing the letter e : " + waltMovies.Count(movie => movie.Title.Contains('e')));

            // Q3
            // Console.WriteLine("How many times the letter f is in all movies : " + waltMovies.Count(movie => movie.Title.Contains('e')));

            // Q4
            Console.WriteLine("Movie with the highest budget : " + waltMovies.First(movie => movie.Budget == waltMovies.Max(movie => movie.Budget)).Title);

            // Q5
            Console.WriteLine("Movie with the lowest box office : " + waltMovies.First(movie => movie.BoxOffice == waltMovies.Min(movie => movie.BoxOffice)).Title);

            // Q6
            // Order the movies by reversed alphabetical order and print the first 11 of the list

            // Q7
            Console.WriteLine("Number of movies released before 1980 : " + waltMovies.Count(movie => movie.ReleaseDate.Year < 1980));

            // Q8
            // Console.WriteLine(waltMovies.Count(movie => movie.Title.ToLower().StartsWith("c")));

            // Q9
            var queryNine = from movie in waltMovies        
                            where (movie.Title.Contains("H") | movie.Title.Contains("W")) & (!movie.Title.Contains("I") | !movie.Title.Contains("T"))
                            select movie;
            Console.WriteLine("\n List of movies with the letter H or W in the title, but not the letter I or T : \n ");
            foreach(MovieCollection.WaltDisneyMovies movie in queryNine) {
                Console.WriteLine(" - " + movie.Title);

            }
            Console.WriteLine("\n END OF list of movies with the letter H or W in the title, but not the letter I or T : \n ");

            // Q10 
            Console.WriteLine("\nBudget average : " + waltMovies.Average(movie => movie.Budget ));
            Console.WriteLine("BoxOffice average : " + waltMovies.Average(movie => movie.BoxOffice ));
            Console.WriteLine("Budget / Box Office : " + (waltMovies.Average(movie => movie.Budget ) / (waltMovies.Average(movie => movie.BoxOffice) )));

            // Exercice 2
            //! La fonction n'est pas terminé et tourne à l'inifinie !
            Threads.Run();
   
        }

    }
}
