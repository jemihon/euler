using System;

public class Euler14
{
    public static void Main()
    {
        ulong longestStarter = 1;
        ulong longestChain = 1;
        ulong currentChain = 1;
        for(ulong i = 1; i < 1000000; i++)
        {
            if((currentChain = ChainLength(i, 1)) > longestChain)
            {
                longestChain = currentChain;
                longestStarter = i;
            }
        }
        Console.WriteLine(longestStarter);
    }
    
    public static ulong ChainLength(ulong num, ulong length)
    {
        //Console.WriteLine(num);
        if(num == 1)
            return length;
        if(num % 2 == 0)
            return ChainLength(num/2, length+1);
        return ChainLength(3*num + 1, length+1);
    }

}

 