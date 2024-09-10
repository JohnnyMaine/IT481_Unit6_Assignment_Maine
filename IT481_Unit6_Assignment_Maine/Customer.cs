﻿using System;

namespace IT481_Unit6_Assignment_Maine
{
    class Customer
    {
        int NumberOfItems;

        public Customer()
        {
            NumberOfItems = 6;
        }

        public Customer(int items)
        {
            int ClothingItems = items;

            if (ClothingItems == 0)
            {
                NumberOfItems = GetRandomNumber(1, 20);
            }
            else
            {
                NumberOfItems = ClothingItems;
            }
        }


        public int getNumberOfItems()
        {
            return NumberOfItems;
        }


        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

    }
}
