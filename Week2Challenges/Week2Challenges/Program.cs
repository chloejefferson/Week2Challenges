using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Program
    {
        //5 - New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.
        //Note: the main method below was already here, just empty.
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.TimeGreeting();
            Console.WriteLine("Please, type your name.");
            string name = Console.ReadLine();
            greeter.Hello(name);
            greeter.Goodbye(name);
            Console.ReadLine();
        }
    }
    //1 - Build a class called Greeter. This class will hold our next few methods.
    public class Greeter
    {
        
        //2 - Inside our new class, build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
        public void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        
        //3 - Build another method that outputs (writes to the Console) some sort of farewell to the name it is given as a parameter.
        public void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }

        //4 - Build a method that outputs (writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
        public void TimeGreeting()
        {
            int time = DateTime.Now.Hour;

            if (time >= 0 && time < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (time >= 12 && time < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (time >= 18 && time <= 23);
            {
                Console.WriteLine("Good evening!");
            }
            
        }
    }
}
