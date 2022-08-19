using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
      //encapsulation
        public void ADD(Product product)       // adr=101 parametr kimi gelir
        {
            Console.WriteLine(product.ProductName + " eklendi.");   //добавить

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi.");  //Обновлять
        }

     
        
    }
}
