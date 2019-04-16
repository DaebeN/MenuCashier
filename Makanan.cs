using System;
namespace responsi
{
    public class Makanan
    {
        private Foods _foods;

        public Makanan()
        {
        }

        public Makanan(Foods _foods)
        {
            this._foods = _foods;
        }

        public void PreSales()
        {
            Console.WriteLine(_foods.Info());
        }
    }
}
