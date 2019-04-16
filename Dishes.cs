using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace uts
{
    public class Dishes
    {

        private List<string> dish = new List<string>();

        public Dishes()
        {
        }

        public string Info()
        {
            return "Ini Info Dishes";
        }

        public void Create(string n)
        {
            dish.Add(n);
        }

        public List<string> getDish()
        {
            return dish;
        }

        public int Size()
        {
            return dish.Count;
        }

        public void Update() { }

        public void Delete() { }
    }
}
