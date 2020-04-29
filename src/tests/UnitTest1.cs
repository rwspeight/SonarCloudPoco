using System;
using Xunit;
using library;
using System.Diagnostics;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

          var c = new Class1();
          Assert.Equal(2, c.Add(1, 1));

        }
    }
}
