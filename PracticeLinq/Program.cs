using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameNames = new List<string>()
            {
                "NBA2K21",
                "Madden 22",
                "MLBTheShow 22",
                "Forza Horizon 3",
            };
            var stringList = videoGameNames.OrderBy(vidgam => vidgam.Length).ToList();
            Console.WriteLine("List of Video Games");
            Console.WriteLine("======================");
            videoGameNames.ForEach(vidgam => Console.WriteLine(vidgam));
            
        }
    }
}
