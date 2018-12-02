using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DayTwo
    {
        [Test]
        public void One()
        {
            var lines = File.ReadAllLines("C:\\Code\\adventofcode2018\\input2.txt");

            var twiceTotal = 0;
            var thriceTotal = 0;
            foreach (var line in lines)
            {
                var dictionary = new Dictionary<char, int>();
                foreach (var character in line)
                {
                    if(!dictionary.ContainsKey(character))
                        dictionary.Add(character, 0);
                    
                    dictionary[character] += 1;
                }

                var twoFound = false;
                var threeFound = false;
                foreach (var pair in dictionary)
                {
                    if (pair.Value == 2 && !twoFound)
                    {
                        twiceTotal += 1;
                        twoFound = true;
                    }
                    if (pair.Value == 3 && !threeFound)
                    {
                        thriceTotal += 1;
                        threeFound = true;
                    }

                    if (twoFound && threeFound)
                        break;
                }
            }


            Console.WriteLine(twiceTotal*thriceTotal);
        }
        [Test]
        public void Two()
        {
            var lines = File.ReadAllLines("C:\\Code\\adventofcode2018\\input2.txt");

            var result = new List<string>();
            foreach (var line in lines)
            {
                foreach (var testLine in lines)
                {
                    var totalDifference = 0;
                    var differenceLocation = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        var character = line[i];
                        var testCharacter = testLine[i];
                        if (character != testCharacter)
                        {
                            totalDifference += 1;
                            differenceLocation = i;
                        }
                    }
                    if(totalDifference == 1)
                    {
                        result.Add(line.Remove(differenceLocation,1));
                        result.Add(line);
                        result.Add(testLine);
                    }
                }
            }


            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
        }
    }
}