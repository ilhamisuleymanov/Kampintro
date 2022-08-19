using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";  //tbxProductName.Text
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5,
            ProductName = "Kalem", UnitsInStock = 5, UnitPrice = 35};

            //PascalCase     //camelCase
            //ProductManager productManager;     //case sensitive
            //string isim;
            //string isim = "Engin";

            ProductManager productManager = new ProductManager(); //meselen adr=101
            productManager.ADD(product1);  // --> adr=101 -i gonderirik
            Console.WriteLine(product1.ProductName);

           

            //int, double, bool,  = değer tip
            //diziler, class, abstract class, interfeys ... = referarans  tip
            //ref out
        }


  


}
}

