using System;
using System.Collections;
using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
