using System;
namespace responsi
{
    public class Minuman
    {
        private Dishes _dishes;

        public Minuman()
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
