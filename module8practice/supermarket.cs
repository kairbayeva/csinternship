using System;
namespace module8practice
{
    public class Supermarket
    {
        List<Product> products = null;
        public Supermarket()
        {
            products = new List<Product>();
        }
        public double this[int Category]
        {
            get
            {
                TimeSpan startTime = new TimeSpan(8, 0, 0);
                TimeSpan endDay = new TimeSpan(12, 0, 0);
                var t = DateTime.Now.TimeOfDay;
                double sum = 0;
                foreach (Product iteam in products)
                {
                    sum += iteam.Price;
                }
                if (t < startTime && t < endDay)
                {
                    return sum * 0.95;
                }
                else
                {
                    return sum;
                }
            }
        }
    }
}