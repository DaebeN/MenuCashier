using System;
namespace uts
{
    public class Transaction
    {
        private Dishes _dishes;

        public Transaction()
        {
        }

        public Transaction(Dishes _dishes)
        {
            this._dishes = _dishes;
        }

        public void PreSales()
        {
            Console.WriteLine(_dishes.Info());
        }
    }
}
