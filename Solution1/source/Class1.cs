using System;
using System.Security.Authentication.ExtendedProtection;

namespace source
{
    public class Class1
    {
        
        

        public static void Main()
        {
            
            int count_limit = 10;
            
            for (int i = 1; i < count_limit; i++)
            {
                for (int k = 0 ; k < count_limit-i; k++)
                {
                    Console.Write(" ");
                }
                

                for (int j = 0; j < 2*i-1 ; j++)
                {

                    if (i - j <= 0)
                    {
                        Console.Write(j-i+2);
                    }
                    else
                    {
                        Console.Write(i - j);
                    }
                    
                }

                Console.Write("\n");
            }
            

            
            

        } 
        
    }
    
}