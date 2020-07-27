using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Fruit
    {
        //Data
        public string _name;
        public int _calories;
        internal bool isThisMyFavorite;

        //functionallty
        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return "$ Fruit: name:{_name} calories:{_calories}";
        }
    }
}
