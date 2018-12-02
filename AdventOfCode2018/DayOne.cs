using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DayOne
    {
        [Test]
        public void One()
        {
            var lines = File.ReadAllLines("C:\\Code\\adventofcode2018\\input1.txt");
            var total = 0;

            foreach (var line in lines)
            {
                var value = int.Parse(line);
                total += value;
            }

            Console.WriteLine(total);
        }
        
        [Test]
        public void Two()
        {
            var lines = File.ReadAllLines("C:\\Code\\adventofcode2018\\input1.txt");
            var total = 0;
            var numbersSeen = new HashSet<int>();

            while (true)
            {
                foreach (var line in lines)
                {
                    var value = int.Parse(line);
                    total += value;
                    if(numbersSeen.Contains(total))
                    {
                        throw new Exception(total.ToString());
                    }

                    numbersSeen.Add(total);
                }
            }
        }
    }
}