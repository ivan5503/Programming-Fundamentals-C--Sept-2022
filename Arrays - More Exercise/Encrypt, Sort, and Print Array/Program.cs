using System;

namespace Encrypt__Sort__and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string vowels = "AaOoUuEeIi";
            for (int j = 0; j < n; j++)
            {
                string name = Console.ReadLine();
                int length = name.Length;
                int sum = 0;
                
                for (int i = 0; i < name.Length; i++)
                {
                    char currChar = name[i];

                    if (vowels.Contains(currChar))
                    {
                        int vowel = (int)currChar;
                        sum += vowel * length;
                        
                    }
                    else
                    {
                        int consonant = (int)currChar;
                        sum += consonant / length;
                    }
                }
                    arr[j] = sum;
            }
            
            int minValue = int.MaxValue;
            int currNumber = 0;
            int index = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                for (int m = 0; m < arr.Length; m++)
                {
                    if (arr[m] < minValue)
                    {
                        minValue = arr[m];
                        currNumber = minValue;
                        index = m;
                    }
                   
                    
                }
                arr[index] = int.MaxValue;
                Console.WriteLine(currNumber);
                minValue = int.MaxValue;
                
           
            }
     
        }
    }
}
