using System;
using System.Collections.Generic;

namespace CodeChallenge
{
    public class Changer
    {
        public Dictionary<double,int> Change(double price,double paid)
        {
            if (paid < price || paid == price)
            {
                return null;
            }

            var change = paid - price;
            Dictionary<double, int> result = new Dictionary<double, int>();
            var notes = new List<double>
            {
                1000D,500D,100D,50D,20D,10D,5D,2D,1D,0.5D,0.25D
            };

            foreach (var value in notes)
            {
                var d = change / value;

                if (d >= 1)
                {
                    result.Add(value, (int)d);
                    change -= (int)d * value;
                }

                if (change < 0.25 )
                {
                    break;
                }
            }

            return result;
        }
    }
}
