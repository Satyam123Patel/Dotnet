namespace TestQuestion2
{
    public interface IProduct {
        public void countProduct();
        public void countPrice();
        public void soldProduct();
    }

    public class Electronics
    {
        public int id;
        public string name;
        public float price;

        public Electronics(int id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public void showDetails()
        {
            Console.WriteLine("Electronics ID: " + id);
            Console.WriteLine("Electronics Name: " + name);
            Console.WriteLine("Electronics Price: " + price);
        }

    }


    class Laptop : Electronics, IProduct 
    {

        public Laptop(int id, string name, float price) : base(id, name, price)
        {

        }

        void IProduct.countProduct() { 
            Console.WriteLine(id);
        }
        void IProduct.countPrice(){
            Console.WriteLine(price);
        }
        void IProduct.soldProduct()
        {
            Console.WriteLine("Laptop " + name + " sold.");

        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Laptop l = new Laptop(1, "Dell XPS 13", 999.99f);
            Laptop l2 = new Laptop(2, "MacBook Pro", 1299.99f);
            Laptop l3 = new Laptop(3, "HP Spectre x360", 1099.99f);

            ((IProduct)l).soldProduct();
            ((IProduct)l2).soldProduct();
            ((IProduct)l3).soldProduct();
            ((IProduct)l).countPrice();
            ((IProduct)l2).countPrice();
            ((IProduct)l3).countPrice();
            ((IProduct)l).countProduct();
            ((IProduct)l2).countProduct();
            ((IProduct)l3).countProduct();



        }
    }
}
