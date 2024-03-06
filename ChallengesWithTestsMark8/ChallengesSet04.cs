using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }

                if (number % 2 != 0)
                {
                    sum -= number;
                }
                
            }
            return sum;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> {str1.Length, str2.Length, str3.Length, str4.Length};
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var array = objs;
           
            if (array == null || array.Length == 0)
            {
                return false;
            }
            
            int nullCount = array.Count(element => element == null);

            return nullCount > array.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            var array = numbers;

            if (array == null || array.Length == 0)
            {
                return 0;
            }

            var evenNumbers = array.Where(num => num % 2 == 0);
            
            double average = evenNumbers.Any() ? evenNumbers.Average() : 0;

            return average;
        }

        public int Factorial(int number)
        {
            var fact = 1;

            if (number < 0)
            {
                
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                
                fact *= i;
            }


            return fact;
        }
    }
}
