using DesignPatterns.Builder;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallBuilderCode();
        }

        static void CallBuilderCode()
        {
            // Builder code
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            // Basic Product
            Console.WriteLine("Standard basic product");
            director.BuildMinialViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Full Product
            Console.WriteLine("Standard full featured product");
            director.BuildFullFeatureProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Custom Product
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}