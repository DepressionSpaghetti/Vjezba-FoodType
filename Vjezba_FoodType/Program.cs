using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_FoodType
{
    class FoodType
    {
        private string name;
        private int protein, carbs, fat;
        static int counter = 0;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;

            counter++;
        }

        public string Name { get => name; }
        public int Protein { get => protein; }
        public int Carbs { get => carbs; }
        public int Fat { get => fat; }

        public override string ToString() { return "{0}: p - {1}%, c - {2}%, f - {3}%" + name + protein + carbs + fat; }

        static int GetNumberOfCreatedInstances() { return counter; }
    }

    class Food
    {
        FoodType type;
        int weight;

        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        FoodType Type { get => type; }
        int Weight { get => weight; }

        public double ProteinD { get => type.Protein;  }
        public double CarbsD { get => type.Carbs; }
        public double FatD { get => type.Fat; }

        public override string ToString()
        {
            return type.ToString() + ", w - {0}g" + weight;
        }

        public string toStringInGrams()
        {
            double proteinG = weight * (type.Protein / 100);
            double CarbsG = weight * (type.Carbs / 100);
            double FatG = weight * (type.Fat / 100);

            return "{0}: p - {1}g, c - {2}g, f - {3}g" + proteinG + CarbsG + FatG;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);

            Console.WriteLine("protein: " + food.ProteinD + "\ncarbs: " +
                food.CarbsD + "\nfat: " + food.FatD);

            Console.ReadKey();
        }
    }
}
