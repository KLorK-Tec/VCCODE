
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your number: ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        int innum = int.Parse(input);
        bool prime = true;//using for later 
        int[] list = new int[innum];    
        for (int i = innum/2; i > 1 ; i--)//going back form inp/2 to 1 (1 dosent need checking)
        {
            if (innum % i == 0)
            {
                Console.WriteLine("The number is not prime");
                Console.WriteLine("The divisors are: ");    
                for (int z = innum/2; z > 1 ; z--)
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
    }
}

