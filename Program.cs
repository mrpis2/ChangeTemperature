class Program
{
    private static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Nhap lua chon");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        FahrenheitToCelsius();

                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(CelsiusToFahrenheit());

                    }
                    break;
                case 0:
                    {
                        Environment.Exit(0);

                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nhap Lai");
                    }
                    break;
            }

        }
        
    }

    static void FahrenheitToCelsius()
    {
        Console.WriteLine("Nhap do C");
        int celsius = int.Parse(Console.ReadLine());
        double fahrenheit = (9.0 / 5) * celsius + 32;
        Console.WriteLine(fahrenheit);
    }

    static double CelsiusToFahrenheit()
    {
        Console.WriteLine("Nhap do F");
        int fahrenheit = int.Parse(Console.ReadLine());
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;

    }
}