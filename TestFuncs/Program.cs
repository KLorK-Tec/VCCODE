class Kiomars
{
    public static void Main()
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();   
        Console.WriteLine("Hello " + name.ToUpper() + "!");
        Menu();
    }
    public static void Menu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. PRIME\n2. FIBONACCI\n3. FizzBuzzBazz\n4. TriangleDrawer\n5. Factorial\n6. UniqueNumInArray\n7. Collatz\n8. ReapetCounter\n9. Exit");
        string inp = Console.ReadLine();
        switch (inp)//using switch was more practical here
        {
            case "1":
                PRIME();
                break;
            case "2":
                FIBONACCI();
                break;
            case "3":
                FizzBuzzBazz();
                break;
            case "4":
                Triangle();
                break;
            case "5":
                Factor();
                break;
            case "6":
                UnuminArr();
                break;
            case "7":
                Collatz();
                break;     
            case "8":
                TheRepeatCounter();
                break;
            case "9":
                Environment.Exit(0);
                break;

             
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
    static void PRIME()
    {
        Console.WriteLine("Enter your number: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }//temp fix for the yellow error
        int innum = int.Parse(input);
        bool prime = true;//using for later    
        for (int i = innum/2; i > 1 ; i--)//going back form inp/2 to 1 (1 dosent need checking)
        {
            if (innum % i == 0)
            {
                Console.WriteLine("The number is not prime");
                Console.WriteLine("The divisors are: ");    
                for (int z = innum/2; z > 1 ; z--)//when a loop dosent work its probly the parameters
                {
                    if (innum % z == 0)//checking for the divisors here
                    {
                        Console.WriteLine(z);
                    }
                }

                prime = false;
                break;

            }
            else
            {
                prime = true;
            }
        } 
        if (prime)
        {
            Console.WriteLine("The number is prime");
        }
        Menu();
    }
    static void FIBONACCI()
    {
        Console.WriteLine("Enter your number: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        int innum = int.Parse(input);
        int a = 0;//first number in series
        int b = 1;//secound num in series
        int c = 0;//the passive one to store the sum of a and b
        for (int i = 0; i < innum; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.Write(Convert.ToString(c + ", "));
        }
        Console.WriteLine();
        Menu();
    }
    static void FizzBuzzBazz() 
    {
        Console.WriteLine("Enter your number: ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i < x; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine("FizzBuzzBazz");
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                }
                else
                {
                    Console.WriteLine("Fizz");
                }
            }
            else if (i % 5 == 0)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("BuzzBazz");
                }
                else
                {
                    Console.WriteLine("Buzz");
                }
            }
            else if (i % 7 == 0)
            {
                Console.WriteLine("Bazz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Menu();
    }
    static void Triangle()
    {
        Console.WriteLine("Enter the size: ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Menu();
    }
    static void Factor()
    {
        Console.WriteLine("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int f = 1;
        for (int i = 2; i <= n ; i++)
        {
            f *= i;
        }
        Console.WriteLine("N! = " + f); 
        Menu();

    }
    static void UnuminArr()
    {
        int p=10, c=0 , n;
        int[] arr = new int[p];
        for (int i = 0; i < p; i++)
        {
            Console.Write("Num:");
            n = int.Parse(Console.ReadLine());  
            bool v = false;
            for (int j = 0; j < c; j++)
            {
                if (arr[j] == n)
                {
                    v = true;
                    break;
                }
            }
            if (!v)
            {
                arr[c] = n;
                c++;
            }
        }
        for (int k = 0; k < c; k++)
        {
            Console.Write(arr[k] + ",");
        }        
    }
    static void Collatz()
    {
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());
        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3*n+1;
            }
            Console.Write(n + ",");
        }
        Console.Write("Loop");
        Menu();
    }
    static void NumReverse()
    {
        Console.Write("Num:");
        char[] arr = (Console.ReadLine()).ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
    static void ThemovingAperatas()
    {
        Console.WriteLine("heyfuck0");
    }
    static void TheRepeatCounter()
    {
        Console.Write("Enter your desierd sequance:");
        string inp = Console.ReadLine();
        char[] lis = (inp.ToUpper().ToCharArray());
        Array.Sort(lis);
        char o = ' ';
        int i = 1;
        Console.Write("The Repeats are:");
        foreach (char x in lis)
        {

            if (x.CompareTo(o) == 0)
            {
                i++;
            }
            else 
            {
                if (o == ' ')
                {
                }
                else
                {
                Console.Write(i + $"[{o}],");
                i = 1;
                }
            }
            o = x;
            
        }
        Console.WriteLine(i + $"[{o}]");
        Menu();
    }
}   