namespace Cmuna2 {
    class Program
    {
        static void Main()
        {
            #region
            //value Datatype
            Console.WriteLine("hello muna");
            int age;
            string FirstName = "Muna Said ";
            string LastName = "alfarqani";
            string FullTimeJob = "Training";
            age = 24;
            #endregion
            #region
            Console.WriteLine( age );
            Console.WriteLine(" My Firstname is :"+ FirstName + "\n my age is "+ age );
            //age = 30;
            //Console.WriteLine(age);
            //age = 24;
            //Console.WriteLine(age);
            //age = 44;
            //Console.WriteLine(age);

            #endregion

            long ssn = 123445677;
            // decimal 
            double payment = 55.6;
            float money = 34.44f;
            decimal salary = 4.55m;
            Console.WriteLine(money);

            int x= 5;
            int y = x;
            Console.WriteLine(y);
            x = 6;
            Console.WriteLine(y);
            string grrting = "hello world";
            string Cgrating = grrting;
            Console.WriteLine(Cgrating);
            grrting = "muna";
            Console.WriteLine(Cgrating);
            Console.WriteLine("----------------OLD------------");

            Object obj1 = new Object(); // 
            Object obj2 = new Object(); // 
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("-------------old-----------");
            obj2 = obj1;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());







        }




    }





}
