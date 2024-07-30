using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Sayı:");
        double numberone = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("2. Sayı:");
        double numbertwo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("3. Sayı:");
        double numberthree = Convert.ToDouble(Console.ReadLine());

        if (numberone > numbertwo && numbertwo > numberthree)
        {
            Console.WriteLine(numberone + ">" + numbertwo + ">" + numberthree);
        }
        else if (numberone > numberthree && numberthree > numbertwo)
        {
            Console.WriteLine(numberone + ">" + numberthree + ">" + numbertwo);
        }
        else if (numbertwo > numberone && numberone > numberthree)
        {
            Console.WriteLine(numbertwo + ">" + numberone + ">" + numberthree);
        }
        else if (numbertwo > numberthree && numberthree > numberone)
        {
            Console.WriteLine(numbertwo + ">" + numberthree + ">" + numberone);
        }
        else if (numberthree > numberone && numberone > numbertwo)
        {
            Console.WriteLine(numberthree + ">" + numberone + ">" + numbertwo);
        }
        else if (numberthree > numbertwo && numbertwo > numberone)
        {
            Console.WriteLine(numberthree + ">" + numbertwo + ">" + numberone);
        }
        else if (numberone == numbertwo && numbertwo > numberthree)
        {
            Console.WriteLine(numberone + "=" + numbertwo + ">" + numberthree);
        }
        else if (numberone == numberthree && numberthree > numbertwo)
        {
            Console.WriteLine(numberone + "=" + numberthree + ">" + numbertwo);
        }
        else if (numbertwo == numberthree && numberthree > numberone)
        {
            Console.WriteLine(numbertwo + "=" + numberthree + ">" + numberone);
        }
        else if (numberone == numbertwo && numbertwo < numberthree)
        {
            Console.WriteLine(numberthree + ">" + numberone + "=" + numbertwo);
        }
        else if (numberone == numberthree && numberthree < numbertwo)
        {
            Console.WriteLine(numbertwo + ">" + numberone + "=" + numberthree);
        }
        else if (numbertwo == numberthree && numberthree < numberone)
        {
            Console.WriteLine(numberone + ">" + numbertwo + "=" + numberthree);
        }
        else if (numberone == numbertwo && numbertwo == numberthree)
        {
            Console.WriteLine(numberone + "=" + numbertwo + "=" + numberthree);
        }

        Console.ReadLine();
    }
}
