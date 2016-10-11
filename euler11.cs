using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IO;

/// @author Jere
/// @version ..2015
/// <summary>
/// 
/// </summary>
public class euler11
{
    public const int ARRAY_SIZE = 20;
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        int multipSum = euler1();
        Console.WriteLine(multipSum);
        Console.ReadKey();
        int largest = Int32.MinValue;
        int current = Int32.MinValue;

        int[,] numgrid = new int[ARRAY_SIZE, ARRAY_SIZE];
        numgrid = gridMaker(numgrid);

        // HORIZONTAL
        for (int i = 0; i < ARRAY_SIZE; i++)
        {
            for (int j = 3; j < ARRAY_SIZE; j += 4)
            {
                if ((current = currentCombo(numgrid, j, i)) > largest)
                {
                    largest = current;
                }
            }
        }

        // VERTICAL




        Console.WriteLine(largest);
        Console.ReadKey();

    }

    public static int currentCombo(int[,] array, int num, int row)
    {
        int product = 1;
        for (int i = num - 3; i <= num; i++)
        {
            product *= array[row, i];
        }
        return product;
    }

    public static int[,] gridMaker(int[,] array)
    {
        String s = "";
        String[] splitted = new String[ARRAY_SIZE];
        StreamReader sr = new StreamReader("C:\\MyTemp\\csharpstuff\\numgrid.txt");
        for (int i = 0; i < ARRAY_SIZE; i++)
        {
            s = sr.ReadLine();
            splitted = s.Split();

            for (int j = 0; j < ARRAY_SIZE; j++)
            {
                array[i, j] = Int32.Parse(splitted[j]);
            }
        }
        sr.Close();
        return array;
    }

    public static int euler1()
    {

        return 0;
    }
}
