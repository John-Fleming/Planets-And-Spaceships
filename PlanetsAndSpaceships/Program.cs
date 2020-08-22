using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

    

            var spaceProbes = new Dictionary<string, List<string>>
            {
                {
                    "Viking",
                    new List<string> {"Earth", "Mars", "Venus"}
                },
                {
                    "Opportunity",
                    new List<string> {"Earth", "Jupiter", "Venus"}
                },
                {
                    "Curiosity",
                    new List<string> {"Earth", "Saturn", "Uranus"}
                },
                {
                    "Mariner",
                    new List<string> {"Earth", "Mars", "Mercury"}
                },
                {
                    "Messenger",
                    new List<string> {"Earth", "Mercury", "Saturn"}
                },
                {
                    "Venera",
                    new List<string> {"Earth", "Jupiter", "Neptune"}
                },
                {
                    "Maven",
                    new List<string> {"Earth", "Venus", "Saturn"}
                },
                {
                    "Pioneer",
                    new List<string> {"Earth", "Saturn", "Jupiter"}
                },

                {
                    "Juno",
                    new List<string> {"Earth", "Mars", "Neptune"}
                },
            };


            foreach (var planet in planetList)
            {
                var probes = spaceProbes
                    .Where(probe => probe.Value.Contains(planet))
                    .Select(probe => probe.Key);

                Console.WriteLine($"{planet}: {String.Join(", ", probes)}");
            }


        }
    }
}
