using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveFlexyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing Tools class
            Console.WriteLine("testing tools -- turns into: " + Tools.ReverseString("testing tools"));
            Console.WriteLine("is 'palin' a palindrome? " + Tools.IsPalindrome("palin"));
            Console.WriteLine("Is 'abcba' a palindrome? " + Tools.IsPalindrome("abcba"));
            Console.WriteLine("Is 'aabbaa' a palindrome? " + Tools.IsPalindrome("aabbaa"));
            int[] arr = new int[] { 1, 2, 3, 5, 7, 12 };
            Console.WriteLine("Missing elements from array: " + string.Join(",", arr));
            
            // testing InstanceServiec class
            InstanceService<Data.Vehicle> instanceService = new InstanceService<Data.Vehicle>();
            foreach (var type in instanceService.GetInstances())
            {
                // every vehicle gets a max speed of 150 and max passengers of 5
                object activator = Activator.CreateInstance(type, 150, 5);

                Console.WriteLine("Class: " + type.Name);
                foreach (var prop in type.GetProperties())
                {
                    if (prop.Name == "MaxSpeed") // max speed has public set so we can have some fun
                    {
                        prop.SetValue(activator, 75); // changing the MaxSpeed property.. for fun..
                    }
                    Console.WriteLine(prop.Name + ": " + prop.GetValue(activator));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
