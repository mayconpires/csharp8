using CSharp8.NullableReference;
using System;
using System.Linq;

namespace CSharp8
{
    class Program
    {

        static void Main(string[] args)
        {
            // To active Nullable Warning for entire project add <nullable>enable</nullable> in your all your *.csproj. 
            // Example: Change the CSharp8.csproj and add <nullable>enable</nullable> inside <PropertyGroup>

            Console.WriteLine("Exercice: Nullable References Compiler Check");

            var people = new People();

            Console.WriteLine($"The {people.Name} is my frinend and your Address is {people.Addresses?.First()}");

            var person = new Person();
            Print(person);
        }

        static void Print(Person person)
        {
            // The compiler indicates that Addresses can be nullable 
            foreach (var item in person.Addresses)
            {
               
                Console.WriteLine($"The nulber: {item.Number} the word count of street is {item.Street.Length}");

                // The compiler indicates that Street can be nullable, but i add ! to suppress the warning.
                // With that i'm saying for the compiler: I have assurance this don't stary nullable.
                Console.WriteLine($"The nulber: {item.Number} the word count of street is {item.Street!.Length}");
                
                Console.WriteLine($"The nulber: {item.Number} the word count of street is {item.Street?.Length}");
            }
        }
    }
}
