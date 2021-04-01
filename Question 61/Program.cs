using System;

namespace Question_61
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part a
            /*
            int a=10,b=20,c=15,d=8,e=40,n;
            n=(a+b/(c-5))/((d+7)/(e-37)%3);
            Console.WriteLine(n);
            */
            //Part b
            /*
            int a=10,b=20,c=15,d=8,e=40,n;
            n=a+b/c-5/d+7/e-37%3;
            Console.WriteLine(n);
            */
            //Part c
            int a=10,b=20,c=15,d=8,n;
            n=a*(b*b)-(c*b)+d;
            Console.WriteLine(n);
        }
    }
}
