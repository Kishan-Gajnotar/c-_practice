using System;
using System.Runtime.ConstrainedExecution;

namespace HelloWorld
{
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        static int MyMethod2(int x, int y)
        {
            return x + y;
        }
        static void MyMethod3(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            string name = "John";
            Console.WriteLine("Hello " + name);
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            Console.WriteLine("Hello " + name);
            Console.WriteLine(myNum);

            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);

            int myInt = 10;
            double myDouble = 5.25;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            string lastName = "Doe";
            string name1 = $"My full name is: {name} {lastName}";
            Console.WriteLine(name);

            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("e"));


            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }


            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            for (int i = 0; i < 7; i++)
            {
                if (i == 4)
                {
                    break;
                }
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int k = 0; k < numbers.GetLength(1); k++)
                {
                    Console.WriteLine(numbers[i, k]);
                }
            }

            MyMethod("Anja", 31);
            int sum = MyMethod2(5, 3);
            Console.WriteLine(sum);

            MyMethod3(child3: "John", child1: "Liam", child2: "Liam");


            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);


            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            myObj.fullThrottle();

            Car Ford = new Car("Mustang", "Yellow", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);


            Person myObj1 = new Person();
            myObj1.Name = "Liam";
            Console.WriteLine(myObj1.Name);

            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}