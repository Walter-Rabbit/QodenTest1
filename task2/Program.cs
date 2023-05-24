using System.Linq;
using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();

            var words = Console.ReadLine()
                .Split(new char[] { ' ' });

            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            var maxCount = dictionary.Max(pair => pair.Value);
            var maxLength = dictionary.Max(pair => pair.Key.Length);

            dictionary
                .OrderBy(pair => pair.Value)
                .ToList()
                .ForEach(pair =>
                {
                    var underscoresCount = maxLength - pair.Key.Length;
                    var relativePart = (double)pair.Value / maxCount;
                    var dotsCount = (int)Math.Round(relativePart * 10, MidpointRounding.AwayFromZero);

                    Console.WriteLine(
                        $"{new string('_', underscoresCount)}" +
                        $"{pair.Key} " +
                        $"{new string('.', dotsCount)}");
                });
        }
    }
}