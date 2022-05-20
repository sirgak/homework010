using System;

namespace homework005
{
    class Program
    {
        static void Main(string[] args)
        {
            int zoloto;
            int gems;
            int kolichestvoGems;
            int ostatokZoloto;
            int usersGems;
            Console.Write("Введите количество золото ");
            zoloto = Convert.ToInt32(Console.ReadLine());
            gems = zoloto / 5;
            Console.Write(" 5 золото равно " + gems + " криссталам ");
            Console.Write("Сколько криссталов хотите купить?");
            kolichestvoGems = Convert.ToInt32(Console.ReadLine());
            usersGems = kolichestvoGems;
            ostatokZoloto = Convert.ToInt32(zoloto - usersGems * 5);
            Console.WriteLine("У вас  " + usersGems + " криссталов и " + ostatokZoloto + "золото. ");
        }
    }
}
