using System;
using System.Collections.Generic;
using System.Text;

namespace lessons.ClassWork
{
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if(numbers.Count > 0)
            {
                int min = numbers[0];
                foreach (int b in numbers)
                {
                    if (b < min)
                    {
                        min = b;
                    }
                }
                numbers.Remove(min);
            }
            return numbers;
        }  
    }
}
