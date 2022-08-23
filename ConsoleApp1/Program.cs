using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello Word");
            //int a = 10, res;
            //int b = 5;
            //res = a++;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a % b);
            //Console.WriteLine(res);
            // int L = 5, M = 10, K = 3;

            //Console.WriteLine(x == y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x);
            //int result = x < y ? x : y;
            //Console.WriteLine(result);
            //for(int i = 0; i < 3; i++)
            //{

            //    Console.WriteLine(" hello word  ");
            //}
            //    if (M >= L * K)
            //    {
            //        Console.WriteLine("Yes");

            //}
            //    else
            //    {
            //        Console.WriteLine("No");
            //        }
            //int num = 30;
            //switch(num)
            //    {
            //    case 0:Console.WriteLine("case 10");
            //        break;
            //    case 10:Console.WriteLine("case 10");
            //        break;
            //    case 20:Console.WriteLine("case 10");
            //        break;
            //    case 30:Console.WriteLine("case 10");
            //        break;
            //        default:Console.WriteLine("None Match");
            //        break;

            //}
            //int x = 1;
            //while (true)
            //{
            //    Console.WriteLine($" c# {x}");
            //    x++;
            //}
            ////for (; ; )
            //Console.WriteLine($"Hello word {x}");
            // int[] intArray = new int[5];
            //  intArray[0] = 10;
            //  intArray[1] = 30;
            //  intArray[2] = 10;
            //  intArray[3] = 10;
            //  intArray[4] = 10;
            //foreach (int i in intArray)
            //      Console.WriteLine(i);
            //int[,] intArray = new int[4, 2];
            //string firstfirend = " ankur";
            //firstfirend = firstfirend.Replace("ankur", "Hello word");

            //    Console.WriteLine(firstfirend.ToUpper());
            //string ap = " you say , and I say hello";
            //Console.WriteLine(ap.Contains("say"));
            //Console.WriteLine(ap.Contains("good bye"));
            //var a = 5.8;
            //var b = 5.2;
            //var c = 5.2;
            //Console.WriteLine((a + b)*c);

            //var a = "1 2 3 4 5 6".Split(' ').
            //Console.WriteLine(a);
            //Console.WriteLine("Enter the value of he radous");
            //var a = Console.ReadLine();
            //var a = Console.ReadLine();
            //Double r = Convert.ToInt32(a.Split(','));
            //Double Areaa = Math.PI * r * r;
            //Console.WriteLine(Areaa);

            //var  sum = 0;
            ////var source = Console.ReadLine("C:\\Personal\\Scala\\Office-Scala-traing\\Problem_Statement\\src\\main\\scala");
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {

            //        sum = sum + i;
            //    }
            //    Console.WriteLine(sum);
            //    Console.WriteLine(sum);

            //}
            //var names = new List <string>{ "Ana ", " Felip" };
            //foreach (var i  in names)
            //    Console.WriteLine(names);
            //  names.Sort();
            //try
            //{
            //    Console.WriteLine(names[1]);
            //}
            //catch
            //{
            //   Console.WriteLine(" Arry out of box ");
            //}
            //decimal a = 5m / 9m;
            //Console.WriteLine(a);
            //var  dice = new Random();
            //var roll = dice.Next();
            //var roll2 = dice.Next(101);
            //var roll3 = dice.Next(50,100);
            //Console.WriteLine(roll);
            //Console.WriteLine(roll2);
            //Console.WriteLine(roll3);
            //var random = new Random();
            //var daysUntilEpiration = random.Next(12);
            //int discountPercentage = 0;
            //if (daysUntilEpiration < 10)
            //{
            //    Console.WriteLine("Your subscription will expire soom.Renew now ");
            //}
            //else if (daysUntilEpiration < 5)
            //{
            //    Console.WriteLine("Your subscription expires in x days Renew now and save 10%!");
            //}
            //else if (daysUntilEpiration < 2)
            //{
            //    Console.WriteLine("Your subscription expires within a day!Renew now and save 20%!");

            //}
            //else
            //{
            //    Console.WriteLine("Your subscription has expired.");
            //}
            var  random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;
            if(daysUntilExpiration <= 10)
            {
                //Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
             else if (daysUntilExpiration <= 5)
            {
               // Console.WriteLine("Your subscription expires in x days.\r\nRenew now and save 10%!");
            }
            else if (daysUntilExpiration <= 1)
            {
               // Console.WriteLine("Your subscription expires within a day!\r\nRenew now and save 20%!");
            }
            else if (daysUntilExpiration >= 10)
            {
               // Console.WriteLine("Nothing");
            }
            else
            {
               //Console.WriteLine("Your subscription has expired.");
            }
            //var  fraud= new string[3];
            //string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
            //foreach (string i in fraudulentOrderIDs)
            //Console.WriteLine(i);
            //string[] names = { "BoB", "Conrad", "Grant" };
            //foreach(string i in names)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] ints = { 1, 5, 8, 9, 5, 8, 8151515, 526, 56158, };
            //List<int> list = ints.ToList();
            //Console.WriteLine(list.Sum());
            //String num = "10,20,30";
            // String[] AuthoreList = num.Split(",");

            // foreach(String s in AuthoreList)
            // Console.WriteLine(s);   


            //foreach (int i in ints)
            //Console.WriteLine(i);
            string[] arr = { "B123", "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
             foreach (string i in arr)
            {
                if (i.StartsWith("B"))

                {
                    Console.WriteLine(i);

                }
              
            }
               Console.ReadLine();

        }
              
            

            
        }
    }


