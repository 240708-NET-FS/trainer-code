using System;
using Xunit;
using System.Collections.Generic;
namespace _3_DataTypeAndVariablesChallenge.Tests
{
    public class ProgramTest
    {
        public static readonly IEnumerable<object[]> _numbers = new List<object[]>
        {
            new object[] {"1"},
            new object[] {"2"},
            new object[] {"3"},
            new object[] {"4"}
        };
        [Theory]
        [MemberData(nameof(_numbers))]
        public void Text2NumShouldParse(string numText)
        {
            Assert.IsType<int>(Program.Text2Num(numText));
        }
    }
}
