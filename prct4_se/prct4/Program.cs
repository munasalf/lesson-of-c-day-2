using static System.Collections.Specialized.BitVector32;

namespace prct4
{
    internal class Program
    {
        static void Main()
        {
            // short circle
            /* string s1 = "hello there ";
             string s2 = s1;
             s1 = "muna";
             Console.WriteLine("s1 value :" + s1);
             Console.WriteLine("s1 place : " + s1.GetHashCode());
             Console.WriteLine(" s2 value : " + s2);
             Console.WriteLine("s2 place : " + s2.GetHashCode());
             //Ternary operater 
             int x = 10;
             string retned = (x % 3 == 0) ? "even" : "old ";
             Console.WriteLine(retned);
            int y = 9;
            string dev = (y % 3 == 0) ? "divisible by " : "divisible";
            Console.WriteLine(dev);*/

            //postfix 
            /* int u = 2;
            Console.WriteLine(u++);
            Console.WriteLine(u);
            u++;
            Console.WriteLine(u);*/


            // solving the programming 
            // 1- Write a program that allows the user to enter a number then print it.
             Console.Write("enter the number:  ");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("the out put is :"+ num);

            //2- Write a program that takes a number from the user
            //then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.Write(" user enter number : ");
             int n = Convert.ToInt32(Console.ReadLine());
             string div =(n %  3 == 0 && n % 3 == 0)? "yes" : "no";
             Console.WriteLine(div);

            //3- Write a program that allows the user to insert 2 integers then print the max.

            Console.Write("First Number = ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second Number = ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max of two: " + Math.Max(first, second));

            /* 4- Write a program that allows the user to insert an integer then
            print negative if it is negative number otherwise print positive.*/

            Console.Write("enter the number : ");
            int numm1 = Convert.ToInt32(Console.ReadLine());
            string dirr = (numm1 < 0) ? "the number is nagative "  : " the number is positive " ;
            Console.WriteLine(dirr);

            /* 5- Write a program that takes 3 integers from
             the user then prints the max element and the min element.*/
             int f;
             int s;
             int th;

              f = Convert.ToInt32(Console.ReadLine());
              s = Convert.ToInt32(Console.ReadLine());
              th = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Max of three: " +(Math.Max(f , s ),th ));
             Console.WriteLine("Min of three: " + (Math.Min(f, s ), th));

            //6- Write a program that allows the user to insert
            //an integer number then check If a number is even or odd.
            Console.Write("enter the number : ");
             int f15 = Convert.ToInt32(Console.ReadLine());
             string retned1 = (f15 %2  == 0) ? "even" : "old ";
             Console.WriteLine(retned1);

            // 7- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then
            // print (vowel) otherwise print (consonant).
            char a, e, i, o, u;
            Console.Write("enter the  character : ");
            char f14 = Convert.ToChar(Console.ReadLine());
            string ret = (f14  == 'a' || f14 =='e' || f14 == 'i'|| f14=='o' ||  f14=='u') ? "vowel" : "consonant ";
            Console.WriteLine(ret);

            // 8- Write a program that allows the user to insert an integer
            // then print all numbers between 1 to that number.
            Console.Write(" enter the number : ");
             int f11 = Convert.ToInt32(Console.ReadLine());
             int i3 = 1;
             while (i3 <= f11)
             {


                 Console.Write("{0}",i3++);
             }

             
            //9- Write a program that allows the user to
            //insert an integer then print a multiplication table up to 12.
             int num12, mult;
             Console.Write("enter the number : ");
             num12 = Convert.ToInt32(Console.ReadLine());
             for (mult = 1 ;  mult <= 12; mult++)
             {
                 Console.WriteLine("{0} * {1} ={2} ",num12,mult,(num12 * mult));
             }

            //10- Write a program that allows to user to insert
            //number then print all even numbers between 1 to this number
            int r=1;

            Console.Write("please enter the number : ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", r2);
           
            
                
                for ( r = 1; r <= r2 ; r++)
                {
                if (r2 % 2 == 0)
                {
                    Console.WriteLine( r);
                }
                    
                }

            


        }
    }
}