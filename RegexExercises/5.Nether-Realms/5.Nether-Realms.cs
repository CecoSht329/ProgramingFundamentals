using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        string[] demons = Console.ReadLine().
            Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var demonHealths = new SortedDictionary<string, int>();
        var demonDamages = new SortedDictionary<string, double>();

        var pattern = @"-?\d+\.?\d*";
        var regex = new Regex(pattern);

        foreach (var demon in demons)
        {
            var health = demon
                .Where(x => !char.IsDigit(x)
                && x != '+' && x != '-' && x != '*' && x != '/' && x != '.')
                .Sum(x => (int)x);

            demonHealths[demon] = health;

            MatchCollection matches = regex.Matches(demon);

            double damage = 0;

            foreach (Match match in matches)
            {
                string value = match.Value;
                damage += double.Parse(value);
            }

            foreach (var symbol in demon)
            {
                if (symbol == '*')
                {
                    damage *= 2;
                }
                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }

            demonDamages[demon] = damage;

        }

        foreach (var demon in demonDamages)
        {
            string demonName = demon.Key;
            int demonHealth = demonHealths[demonName];
            double demonDamage = demon.Value;

            Console.WriteLine($"{demonName} - {demonHealth} health, {demonDamage:F2} damage");
        }

    }
}