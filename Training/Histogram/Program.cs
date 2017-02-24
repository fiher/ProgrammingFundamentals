using System;

class Histogram
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var p1 = 0;//ако тук е 0.0 няма нужда после от 100.0
        var p2 = 0;// може и просто да запишем double p2
        var p3 = 0;
        var p4 = 0;
        var p5 = 0;

        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < 200) p1++;
            else if (num < 400) p2++;
            else if (num < 600) p3++;
            else if (num < 800) p4++;
            else p5++;
        }
            var p1Per = p1 * 100.0 / n;
            var p2Per = p2 * 100.0 / n;
            var p3Per = p3 * 100.0 / n;
            var p4Per = p4 * 100.0 / n;
            var p5Per = p5 * 100.0 / n;

            Console.WriteLine("{0:F2}%", p1Per);//може и с Math.Round((double)p1/n*100),2)
            Console.WriteLine("{0:F2}%", p2Per);
            Console.WriteLine("{0:F2}%", p3Per);
            Console.WriteLine("{0:F2}%", p4Per);
            Console.WriteLine("{0:F2}%", p5Per);
        

    }
}

