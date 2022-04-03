using System;

namespace Home_Work
{
    class Program
    {
        static void Main(string[] args)

        {

            string num = Console.ReadLine();
            int a = int.Parse(num);

            Murekkeb(a);
                
                














        }
        static void Murekkeb(int a)

            
        {
            int count = 0;

            for (int i = 1; i <= a; i++)
            {
                

                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.WriteLine("Eded murekkebdi");
            }
            else { Console.WriteLine("eded sadedi"); }


            return;



















        }
    }
    }





















#region task 5
//try
//{
//    string numstr = Console.ReadLine();
//    int num = int.Parse(numstr);
//    int a = num;
//    int b = 0;
//    int count = 0;

//    while (a > 0)
//    {
//        b = a % 10;
//        a = (a - b) / 10;
//        count++;
//    }
//    Console.WriteLine("Ededin meretebe sayi" + count);

//}
//catch (Exception)
//{

//    Console.WriteLine("herif daxil etmek olmaz");
//}

#endregion

#region Task 8

//try
//{
//    string Num1 = Console.ReadLine();
//    int a = int.Parse(Num1);

//    string Num2 = Console.ReadLine();
//    int b = int.Parse(Num2);


//    int sum = 0;
//    int min = 0;
//    int max = 0;


//    if (a > b)
//    {
//        min = b;
//        max = a;
//    }
//    else
//    {
//        max = b;
//        min = a;
//    }


//    for (int i = min; i <= max; i++)
//    {

//        sum = sum + i;
//    }

//    Console.WriteLine(sum);
//}
//catch (FormatException)

//{

//    Console.WriteLine("Herif daxil etmek olmaz");
//}

#endregion

#region task 1

//        try
//            {
//                string num1 = Console.ReadLine();
//        int a = int.Parse(num1);

//        string num2 = Console.ReadLine();
//        int b = int.Parse(num2);

//        string num3 = Console.ReadLine();
//        int c = int.Parse(num3);



//                if (a > b && a > c)
//                {
//                    Console.WriteLine("En boyuk deyer A");
//                }
//                if (b > a && b > c)
//                {
//                    Console.WriteLine("En boyuk deyer B");
//                }
//if (c > a && c > b)
//{
//    Console.WriteLine("En boyuk deyer C");
//}

//            }
//            catch (Exception)

//{

//    Console.WriteLine("Ancaq reqem daxil edin!");
//}

#endregion

#region task 7

//try
//{
//    string nmrstr = Console.ReadLine();
//    int bal = int.Parse(nmrstr);
//    int a = bal;


//    if (a > 100)
//    {
//        Console.WriteLine("Bal duzgun daxil edimiyib");
//    }
//    if (a > 91 && a <= 100)

//    { Console.WriteLine(" Sizin imtahan cavabiniz A"); }
//    if (a > 80 && a <= 90)
//    {
//        Console.WriteLine("Sizin imtahan cavabiniz B");
//    }
//    if (a > 70 && a <= 80)
//    {
//        Console.WriteLine("Sizin imtahan cavabiniz C");
//    }
//    if (a > 60 && a <= 70)
//    {
//        Console.WriteLine("Sizin imtahan cavabiniz D");
//    }
//    if (a > 50 && a <= 60)
//    {
//        Console.WriteLine("Sizin imtahan cavcabiniz E");

//    }
//    else { Console.WriteLine(" KESILDINIZ!!"); }
//}
//catch (Exception)
//{
//    Console.WriteLine("Duzgun daxil edin");

//}


#endregion

#region Task 6
//string strnum = Console.ReadLine();
//int a = int.Parse(strnum);

//try
//{
//    if (a > 1)
//    {
//        if (a % 3 == 0 && a % 7 == 0)
//        {
//            Console.WriteLine(" eded hem 3 hemde 7 bolunur");
//        }
//        else
//        {
//            Console.WriteLine("duzgun daxil edin");
//        }

//    }


//}
//catch (Exception)
//{
//    Console.WriteLine("Herf daxil etme");
//    throw;
#endregion

#region task 3

//task 1 3 ededin en boyuk olanin tapin

//int a = 5;
//int b = 9;
//int c = 43;


//    if  (a > b && a > c)
//{
//    Console.WriteLine("En boyuk deyer A");
//}
//if (b > a && b > c)
//{
//    Console.WriteLine("En boyuk eded B");
//}
//if (c > a && c > b)
//{
//    Console.WriteLine("En boyuk eded C");

#endregion;

#region task 2

//} task2 5 ededin ededi ortasin tapin

// int a = 49;
//     int b = 23;
//     int c = 98;
//     int d = 65;
//     int e = 9;
// int g = 0;


//g = (a + b + c + d + e) / 5;
// Console.WriteLine(g);

#endregion;







































