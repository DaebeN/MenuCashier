using System;
namespace responsi
{
    public class Makanan
    {
        private Dishes _dishes;

        public Makanan()
        {
        }

        public Makanan(Dishes _dishes)
        {
            this._dishes = _dishes;
        }

        public void PreSales()
        {
            Console.WriteLine(_dishes.Info());
        }
    }
}
