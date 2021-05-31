using System;


class Lab_3
{
    // сумму элементов массива с нечетными номерами;
    public void task_1()
    {
        var array = new double[5];

        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.NextDouble();
        }

        foreach (var item in array)
        {
            Console.WriteLine(item.ToString());
        }

        double sum = 0;

        for (int i = 0; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine("Sum: " + sum.ToString());
    }

    //сумму элементов массива, расположенных между первым и последним отрицательными элементами.
    public void task_2()
    {
        var array = new double[10];

        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.NextDouble() - 0.5;
        }

        foreach (var item in array)
        {
            Console.WriteLine(item.ToString());
        }

        double sum = 0;
        bool negativeFinded = false;
        int lastNegativeIndex = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (!negativeFinded && array[i] < 0)
            {
                negativeFinded = true;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < 0) lastNegativeIndex = j;
                }

                continue;
            }
            if (i >= lastNegativeIndex)
            {
                break;
            }
            if (negativeFinded)
            {
                sum += array[i];
                continue;
            }
        }

        Console.WriteLine("Sum: " + sum.ToString());
    }

    //Сжать массив, удалив из него все элементы, модуль которых не превышает единицу.
    //Освободившиеся в конце массива элементы заполнить нулями.
    public void task_3()
    {
        var array = new int[10];

        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(0, 10) - 5;
        }

        foreach (var item in array)
        {
            Console.WriteLine(item.ToString());
        }

        int removedCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) <= 1)
            {
                array[i] = 0;
                removedCount++;
                continue;
            }
            array[i - removedCount] = array[i];
            if (i != i-removedCount) { 
                array[i] = 0;
            }
        }

        Console.WriteLine("result: ");
        foreach (var item in array)
        {
            Console.WriteLine(item.ToString());
        }
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        var lab_3 = new Lab_3();
        lab_3.task_3();
        Console.ReadLine();
    }
}
