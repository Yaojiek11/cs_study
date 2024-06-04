using System;

/* 継承を利用したAdapter */
namespace ClassAdapterPattern
{
    // Mainクラス
    class Program
    {
        static void Main(string[] args)
        {
            ProductPrice p1 = new ProductAdapter(100);
            ProductPrice p2 = new ProductAdapter(200);
            int price1 = p1.getPrice();
            int price2 = p2.getPrice();
            Console.WriteLine("price1 = {0}",price1);
            Console.WriteLine("price2 = {0}",price2);
        }
    }

    // Productクラス(Adaptee)
    public class Product
    {
        private int cost;
        public Product(int cost){
            this.cost = cost;
        }
        public int getCost(){
            return cost;
        }
    }

    // ProductPriceインターフェース(Target)
    public interface ProductPrice
    {
        public int getPrice();
    }

    // ProductAdapterクラス(Adapter)
    public class ProductAdapter : Product, ProductPrice
    {
        public ProductAdapter(int num) : base(num) {}
        public int getPrice(){
            return this.getCost();
        }
    }
}