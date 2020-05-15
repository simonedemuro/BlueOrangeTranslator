using System;
using Xunit;

namespace BlueOrange.Test
{
    public class UnitTest1
    {

        int mul(int a, int b)
        {
            int c=0;
            for (int i = 0; i < b; i++)
            {
                c += a;
            }

            return c;
        }

        [Fact]
        public void Test1()
        {
            // SETUP
            int expectedRes = 2*3;

            // OPERATIONS
            int myResult = mul(2, 3);

            // ASSERT 
            Assert.Equal(expectedRes, myResult);
        }
    }
}
