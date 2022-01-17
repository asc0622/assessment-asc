using Xunit;
using Assessment1NS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assessment1.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 100, 6)]
        public void AssessmentTest1(int min, int max, int missingNum)
        {
            var expected = Enumerable.Range(min, max).Count() - 1; // 1 = missing number
            Numbers numbers = new Numbers(min, max);
            numbers.NumbersAssessment1(missingNum);
            
            int resultSorted = numbers.Sorted.Trim().Split(' ').ToList().Count();
            int resultNotSorted = numbers.Sorted.Trim().Split(' ').ToList().Count();
            
            Assert.Equal(expected, resultSorted);
            Assert.Equal(expected, resultNotSorted);
        }
    }
}