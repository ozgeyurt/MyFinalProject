using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}



            //ProductManager productManager = new ProductManager(new EFProductDal());
            //foreach (var product in productManager.GetProductDetails())
            //{
            //    Console.WriteLine(product.ProductName+"/" + product.CategoryName);

            //}


            ProductManager productManager = new ProductManager(new EFProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName+"/"+product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EFProductDal());
        //    foreach (var product in productManager.GetByUnitPrice(50, 100))
        //    {
        //        Console.WriteLine(product.ProductName);

        //    }
        //}
    }
}
