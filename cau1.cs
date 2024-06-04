using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập vào một số: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Số {0} là số dương.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("Số {0} là số âm.", number);
        }
        else
        {
            Console.WriteLine("Số {0} là số 0.", number);
        }
    }
}