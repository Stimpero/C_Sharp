using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {   enum gradus:int
        {
            min=0,
            krit=72,
            max=100,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            int i = 10;	//объявление и инициализация целочисленной переменной i
            Console.WriteLine(i);		//просмотр значения переменной
            i = 100;		//изменение значение переменной
            Console.WriteLine(i);
        
            //int i;
            //Console.WriteLine(i);

            //const int i=10;	//объявление целочисленной константы i
            //Console.WriteLine(i);		//просмотр значения константы
            //i=100;		//ошибка
            //Console.WriteLine(i);



            Console.WriteLine("минимальная температура=" + (int)gradus.min);
            Console.WriteLine("критическая температура=" + (int)gradus.krit);
            Console.WriteLine("максимальная температура=" + (int)gradus.max);

            Console.WriteLine("Ура!\nСегодня \"понедельник\"!!!");

            double x = Math.E;
            Console.WriteLine("E={0,20}", x);
            Console.WriteLine("E={0,10}", x);

            double y = Math.E;
            Console.WriteLine("E={0:##.######}", y);
            Console.WriteLine("E={0:.######}", y);

            Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
            Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
            Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
            Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
            Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
            Console.WriteLine("X Format:{0,14:X} ", 1234);
            Console.WriteLine("P Format:{0,14:P} ", 0.9);

            string s = Console.ReadLine();
            int xx = int.Parse(s); //преобразование строки в число
            Console.WriteLine(xx);

            int x_1 = int.Parse(Console.ReadLine()); //преобразование введенной строки в число
            Console.WriteLine(x_1);

            float x2 = float.Parse(Console.ReadLine()); //преобразование введенной строки в число
            Console.WriteLine("{0,14:f3}",x2);

            //1
            Console.Write("1\n");
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            Console.Write("\n");

            //2
            Console.Write("2\n");
            Console.Write("a= ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={1}+{0}", a1, b1);
            Console.Write("\n");

            //3
            Console.Write("3\n");
            Console.Write("a= ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}", a2, b2,c2, a2+b2+c2);
            Console.Write("\n");

            //4
            Console.Write("4\n");
            Console.Write("a= ");
            float af = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float bf = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f1}*{1:f1}={2:f1}", af, bf, af*bf);
            Console.Write("\n");

            //5
            Console.Write("5\n");
            Console.Write("a= ");
            float ad = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float bd = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f3}/{1:f3}={2:f3}", ad, bd, ad / bd);
            Console.Write("\n");

            //6
            Console.Write("6\n");
            Console.Write("a= ");
            float add = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float bdd = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float cdd = float.Parse(Console.ReadLine());
            Console.WriteLine("({0:f2}+{1:f2})+{2:f2}={0:f2}+({1:f2}+{2:f2})", add, bdd, cdd ,add, bdd, cdd); 

        }
    }
}
