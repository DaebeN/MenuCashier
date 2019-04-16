using System;
namespace uts
{
    public class Transaction2
    {
        private Dishes _dishes;

        public Transaction2()
        {
            _dishes = new Dishes();
        }

        public void PreSales()
        {
            Console.WriteLine(_dishes.Info());
        }

        public void ListDish()
        {
            try
            {
                if (_dishes.Size() <= 0)
                {
                    Console.WriteLine("Tidak ada list makanan");
                }
                else
                {
                    Console.WriteLine(_dishes.getDish());
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
