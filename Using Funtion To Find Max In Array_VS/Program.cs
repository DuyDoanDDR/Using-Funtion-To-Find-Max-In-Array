class Program
{
    public static int MaxValue(int[] numbers)
    {
        int max = numbers[0];
        int index = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                index = i;
            }
        }
        return index;
    }

    public static void Main(string[] args)
    {

        {
            Console.WriteLine("Enter your list (Each number has space between them): ");
            Console.WriteLine("Press 0 to exit: ");
            while (true)
            {
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int exitvalue) && exitvalue == 0 )
                    {
                        Environment.Exit(exitvalue);
                        break;
                    }
                    else
                    {
                        bool IsInt = input.Replace(" ", "").All(char.IsDigit);
                        if (IsInt)
                        {
                            int[] numbers = input.Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();
                            int index = MaxValue(numbers);
                            Console.WriteLine("The greatest's position is: " + index);
                            Console.WriteLine("Check more list ? (Press 0 to exit) : ");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("List has invalid value / Please enter again: ");
                        }
                    }
                    
                }
                
            }
           
            
        }
    }
}

