using System;

public class Program
{
    static void Main(string[] args)
    {
        int CountTimes = 0;
        int num;
        Console.WriteLine("Insira um número:");
        num = int.Parse(Console.ReadLine());

        try
        {
           Console.WriteLine("par");
           while(num > 0)
           {
                
               if (num % 2 == 0)
               {
                  num = num / 2;
                    CountTimes++;
                }
               if(num % 2 == 1)
               {
                 num = num - 1;
                    CountTimes++;
                }
           }
            Console.WriteLine(num);
            Console.WriteLine(CountTimes);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}

