using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Intrinsics.Wasm;
using System.Linq;
namespace Generic
{
    class Gen
    {
        static void Main()
        {
            Dictionary<string, int> stringes = new Dictionary<string, int>();
            string text = File.ReadAllText("C:\\SkillFactory\\Res\\cdev_Texte.txt");
            string TextUpper = text.ToUpper();
            var noPunctuationText = new string(TextUpper.Where(c => !char.IsPunctuation(c)).ToArray());
            string ars = noPunctuationText.ToString();
            string[] TextMassiv = ars.Split();
            HashSet<string> UnicString = new HashSet<string>(TextMassiv);

            foreach (var s in UnicString)
            {
                stringes.Add(s, 0);
            }

            foreach (var s in stringes.Keys)
            {
                foreach (var p in TextMassiv)
                {
                    if (s == p)
                    {
                        stringes[s] += 1;
                    }
                }
              
            }
            Console.WriteLine($"Десять самых часто встречающихся слов");

            foreach (var s in stringes.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{s.Key} - {s.Value}");
            }
        }
    }
}