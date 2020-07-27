using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class FruitSalad
    {
        public Fruit[] fruits;
        // Apple 22, Banana 33, apple 10, banana 24
        public int GetTotalCalories()
        {
            int sumCalories = 0;
            foreach (Fruit fruit in fruits)
            {
                // 0: apple = 22 cals;
                // 1: banana = 33 cals;
                // 2: apple = 10 cals;
                // 3: banana = 24 cals;
                sumCalories += fruit._calories; // 0: 22, 1: 55, 2: 65, 3: 89
            }
            return sumCalories; //89
        }
        public bool ContainsMyFavoriteFruit()
        {
            // apple, apple, apple, apple
            foreach (Fruit fruit in fruits)
            {
                if (fruit.isThisMyFavorite)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $" [{ base.ToString()}] [FruitSalad]: fruits:{fruits}";
        }
    }
}
