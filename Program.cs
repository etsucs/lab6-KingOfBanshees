
System.Console.WriteLine("Method 1? Y||N");
string Method1a = Console.ReadLine();
char Method1b = char.ToUpper(Method1a[0]);

if(Method1b == 'Y')
{
    System.Console.WriteLine("Give me a word!");
    string String2Char = Console.ReadLine();

    System.Console.WriteLine("What numbered letter do you want?");
    int CharNumber = ((Convert.ToInt32(Console.ReadLine())) - 1);

    ShowCharacter(String2Char, CharNumber);
        
    static void ShowCharacter(string String2Char, int CharNumber)
        {
            char ShowCharRes = String2Char[CharNumber];
            System.Console.WriteLine(ShowCharRes);
        }
}



System.Console.WriteLine("Method 2? Y||N");
string Method2a = Console.ReadLine();
char Method2b = char.ToUpper(Method2a[0]);

if(Method2b == 'Y')
{
    System.Console.WriteLine("What is your item's wholesale cost?");
    double Wholesale;
    Double.TryParse(Console.ReadLine(), out Wholesale);

    System.Console.WriteLine("What is its markup percentage?\n Enter as a decimal. Ex: 0.25 or 0.5");
    double MarkUp;
    Double.TryParse(Console.ReadLine(), out MarkUp);

    CalculateRetail(Wholesale, MarkUp);
    
    static void CalculateRetail(double Wholesale, double MarkUp)    
    {
        System.Console.WriteLine($"The total price is ${Wholesale * (MarkUp + 1)}!");
    }   
}



System.Console.WriteLine("Method 3? Y||N");
string Method3a = Console.ReadLine();
char Method3b = char.ToUpper(Method3a[0]);

if(Method3b == 'Y')
{
    for(int FTemp = 80; FTemp < 101; FTemp++)
    {
        Celsius(FTemp);
    }

    static void Celsius(int FTemp)
    {
        double CTemp = ((FTemp - 32) * 0.5555556);
        System.Console.WriteLine(CTemp);   
    }
}




System.Console.WriteLine("Method 4? Y||N");
string Method4a = Console.ReadLine();
char Method4b = char.ToUpper(Method4a[0]);

if(Method4b == 'Y')
{
    System.Console.WriteLine("What is your number?");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (IsPrime(num2))
    {
        System.Console.WriteLine("Your number is prime!");
    }
    else
    {
        System.Console.WriteLine("Your number is not prime!");
    }

    static bool IsPrime(int num2)
    {
        if(num2 <= 2)
        {
            return false;
        }
        else if(num2 == 3 || num2 == 5)
        {
            return true;
        }
        else if(num2 % 2 == 0 || num2 % 3 == 0 || num2 % 5 == 0) 
        {
            return false;
        }

        var boundary = (int)Math.Floor(Math.Sqrt(num2));  // Had to look this up because I had no idea.

        int i = 6;
        while (i <= boundary)
        {
            if(num2 % (i + 1) == 0 || num2 % (i + 5) == 0)
            {
                return false;
            }
            
            i += 6;
        }
        return true;
    }





}












































