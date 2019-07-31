﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Basket
    {

        private List<Fruits> BasketContents;
        public Basket()
        {
            BasketContents = new List<Fruits>();//create a new empty basket
        }

        public void AddBasket(string fruitToBuy)
        {
            Fruits f = new Fruits(fruitToBuy);
            BasketContents.Add(f);//add to the basket list
        }

         public double calcBasketTotal()
         {
             double basketTotal = 0.0d;
             foreach (Fruits eachFruit in BasketContents)
             {
                 basketTotal += eachFruit.Fprice;
             }

             return basketTotal;
         }

        
}
}
