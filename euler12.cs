using System;

/// Euler project problem 12 solution
/// @author Jere Honka

public class euler12
{
    /// The main program. 
    public static void Main()
    {
        int i = 3;
        int tri = triangular(i);
        
        while(divisors(tri) <= 500)
        {
            i++;
            tri = triangular(i);
        }
        
        Console.WriteLine(tri);
    }
    
    /// Finds the nth triangular number
    public static int triangular(int n)
    {
        int result = 0;
        for(int i = n; i > 0; i--)
        {
            result += i;
        }
        return result;
    }
    
    /// Finds the amount of divisors num has and returns the count.
    public static int divisors(int num)
    {
        int count = 2;
        
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0) {                
                count++;
                if(i*i != num)
                    count++;
            }                              
        }
        return count;
    }
}
        