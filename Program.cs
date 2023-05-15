using System;

class Program
{
    static void Main()
    {
        Console.Write("ความจุของถังน้ำ: ");
        double vMax = double.Parse(Console.ReadLine());

        Console.Write("ปริมาตรน้ำเฉลี่ยที่ผู้เข้าร่วมโครงการดื่มในแต่ละช่วงพัก: ");
        double vDrink = double.Parse(Console.ReadLine());

        Console.Write("ปริมาตรน้ำที่เติมได้ในแต่ละรอบเติมน้ำ: ");
        double vFill = double.Parse(Console.ReadLine());

        Console.Write("ระยะเวลาคั่นระหว่างช่วงพัก: ");
        int tDay = int.Parse(Console.ReadLine());

        Console.Write("ระยะเวลาคั่นระหว่างรอบเติมน้ำ: ");
        int tDrink = int.Parse(Console.ReadLine());

        Console.Write("ระยะเวลารวมของกิจกรรมตั้งแต่เริ่มจนจบวัน: ");
        int totalTime = int.Parse(Console.ReadLine());

        double remainingWater = vMax;
        bool enoughWater = true;

        for (int time = 0; time < totalTime; time++)
        {
            if (time % tDay == 0)
            {
                remainingWater -= vDrink;
                if (remainingWater < 0)
                {
                    enoughWater = false;
                    break;
                }
            }

            if (time % tDrink == 0)
            {
                remainingWater += vFill;
                if (remainingWater > vMax)
                    remainingWater = vMax;
            }
        }

        if (enoughWater)
        {
            Console.WriteLine("Enough Water, {remainingWater} left");
        }
        else
        {
            if (remainingWater < 0)
                Console.WriteLine("Not Enough Water");
            else
                Console.WriteLine("Overflow Water");
        }
    }
}

class Program
{
    static void Main()
    {
        double b1, b2, b3;

        Console.Write("ยอดเบ็ดเตล็ดทั้ง 3 ยอดในใบขอรับการสนับสนุนโครงการ (B1, B2, B3): ");
        b1 = double.Parse(Console.ReadLine());
        b2 = double.Parse(Console.ReadLine());
        b3 = double.Parse(Console.ReadLine());

        double totalBalance = b1 + b2 + b3;
        double l = 0;

        while (true)
        {
            Console.Write("ยอดชำระในใบเสร็จหรือใบสำคัญรับเงิน: ");
            double payment = double.Parse(Console.ReadLine());

            if (payment <= 0)
                break;

            if (b1 >= payment)
            {
                b1 -= payment;
            }
            else if (b2 >= payment)
            {
                b2 -= payment;
            }
            else if (b3 >= payment)
            {
                b3 -= payment;
            }
            else
            {
                l += payment - totalBalance;
                b1 = b2 = b3 = 0;
            }
        }

        Console.WriteLine($"Balance 1: {b1}, Balance 2: {b2}, Balance 3: {b3}");
        Console.WriteLine($"Left: {l}");
    }
}


