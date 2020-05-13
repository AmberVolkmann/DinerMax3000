using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMax3000Console
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        public double Price
        {
            get { return _price; }
            set {
                if (value > 0)
                {
                    _price = value;
                }
                else
                // we want everything to fail if a price is not higher than zero
                {
                    throw new ApplicationException("You cannot have free of negative valued items.");
                }
            }
        }

        private double _price;
    }
}
