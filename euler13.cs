using System;

public class Euler13
{
    public static void Main()
    {
        string[] input = System.IO.File.ReadAllLines(@"C:\MyTemp\euler\input.txt");
        string result = CountTheSum(input);
        Console.WriteLine(result);
    }
    
    public static string CountTheSum(string[] input)
    {
        int[] result = new int[300];
        int resInd = result.Length - 1; // mitä kohtaa taulukossa käsitellään
        
        for(int i = 0; i < input.Length; i++) // rivi jota käydään läpi
        {
            for(int j = input[i].Length - 1; j >= 0; j--) // lisätään rivi resulttiin
            {
                if((result[resInd] += Convert.ToInt32(char.GetNumericValue(input[i][j]))) >= 10)
                {                    
                    AddCheck(result, resInd);
                }            
                resInd--;                
            }
            resInd = result.Length - 1;
        }
        
        for(int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }

        return "wew";
    }
    
    public static void AddCheck(int[] result, int resInd)
    {
        if(result[resInd] >= 10)
        {
            result[resInd] = result[resInd] % 10;
            result[resInd-1]++;
            AddCheck(result, resInd-1);
        }
        
    }
}