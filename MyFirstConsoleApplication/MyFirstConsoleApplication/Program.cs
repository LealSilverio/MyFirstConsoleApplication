namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sara Leal Silverio", location = "São Paulo, Brazil";
            var currentDate = DateTime.Now;
            DateTime christmas = new DateTime(2023, 12, 25);
            double dateDifference = (christmas - currentDate).TotalDays;
            int number = (int)dateDifference;


            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine($"Today's date is {currentDate.ToString("d")}");
            Console.WriteLine($"There are {number} days until Christmas");

            // example from section 2.1 in the C# Programming Yellow Book by Rob Miles
            Console.WriteLine("\nThis is the example from section 2.1 in the C# Programming Yellow Book by Rob Miles.\n");
            
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("What is the width of the glass in meters? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height of the glass in meters? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            
            Console.WriteLine("\nThe length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

            Console.WriteLine($"\nPress any key to quit...");
            Console.ReadKey(true);
        }
    }
}
