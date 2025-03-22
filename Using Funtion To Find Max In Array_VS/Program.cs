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
            
            while (true) //Tao vong lap sao cho user chi ra duoc ket qua khi nhap gia tri dung
            {
                {
                    //Truong hop user nhan 0 de thoat chuong trinh
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int exitvalue) && exitvalue == 0 )
                    {
                        Environment.Exit(exitvalue);
                        break;
                    }
                    //Truong hop user nhap day ky tu
                    else
                    {
                        //Kiem tra xem day ki tu co dung la chi co dau cach va so nguyen khong
                        bool IsInt = input.Replace(" ", "").All(char.IsDigit);
                        //Neu dung chi co dau cach va so nguyen => Chay phuong thuc tinh toan
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

