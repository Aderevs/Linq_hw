using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_hw
{
    internal class Vocabulary
    {
        public Vocabulary()
        {
            dynamic dictionary = new ExpandoObject();

            dictionary.Apple = "Яблуко";
            dictionary.Banana = "Банан";
            dictionary.Car = "Автомобіль";
            dictionary.Dog = "Собака";
            dictionary.Elephant = "Слон";
            dictionary.Flower = "Квітка";
            dictionary.Guitar = "Гітара";
            dictionary.House = "Будинок";
            dictionary.Orange = "Апельсин";
            dictionary.Pencil = "Олівець";

            PrintDictionary(dictionary);
        }

        static void PrintDictionary(dynamic dictionary)
        {
            foreach (var property in dictionary)
            {
                Console.WriteLine($"{property.Key}: {property.Value}");
            }
        }
    }
}
