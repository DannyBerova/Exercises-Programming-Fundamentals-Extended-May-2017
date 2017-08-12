
namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var sortedDemons = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var healthSymbols = demon.Where(s => 
                !char.IsDigit(s) &&
                s != '+' && s != '-' && 
                s != '*' && s != '/' && 
                s != '.');

                var health = 0;

                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }

                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var number = double.Parse(match.Value);
                    damage += number;
                }

                var specialSymbols = demon.Where(s => s == '*' || s == '/');

                foreach (var symbol in specialSymbols)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                sortedDemons.Add(demon, new Demon{
                    Name = demon,
                    Health = health,
                    Damage = damage
                });
                
            }
            foreach (var sortedDemon in sortedDemons)
            {
                var demon = sortedDemon.Value;
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}
