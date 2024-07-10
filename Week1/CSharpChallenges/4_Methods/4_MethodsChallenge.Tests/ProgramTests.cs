using Xunit;
using System.IO;
using System;
using System.Collections.Generic;
using _4_MethodsChallenge;

namespace _4_MethodsChallenge.Tests
{
    public class ProgramTests{
        public static readonly StringWriter output = new StringWriter();
        public static readonly IEnumerable<object[]> _names = new List<object[]>
        {
            new object[] {"Marielle"},
            new object[] {"Carmina"},
            new object[] {"Tible"},
            new object[] {"Nolasco"}
        };
        public static readonly IEnumerable<object[]> _numbers = new List<object[]>
        {
            new object[] {1.0},
            new object[] {2.0},
            new object[] {3.0},
            new object[] {4}
        };
        public static readonly IEnumerable<object[]> _input = new List<object[]>
        {
            new object[] {0,1, 1},
            new object[] {0,1, 2},
            new object[] {1,1, 3},
            new object[] {1,1, 4}
        };
        [Theory]
        [MemberData(nameof(_names))]
        public void GetNameShouldReturnName(string name)
        {
            var input = new StringReader(name);
            Console.SetIn(input);

            Assert.Equal(Program.GetName(), name);

        }
        [Theory]
        [MemberData(nameof(_names))]
        public void GreetFriendShouldGreet(string name)
        {
            Console.SetOut(output);
            Program.GreetFriend(name);
            Assert.Equal(string.Format("Hello, {0}. You are my friend{1}",name,Environment.NewLine), output.ToString());
            
            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }

        [Theory]
        [MemberData(nameof(_numbers))]
        public void GetNumberShouldGetNumber(double number)
        {
            var input = new StringReader(number.ToString());
            Console.SetIn(input);

            Assert.Equal(number, Program.GetNumber(), 0);
        }

        [Theory]
        [MemberData(nameof(_names))]
        public void GetNumberShouldThrowException(string inp)
        {
            var input = new StringReader(inp);
            Console.SetIn(input);

            Assert.Throws<FormatException>(() => Program.GetNumber());
        }

        [Theory]
        [MemberData(nameof(_numbers))]
        public void GetActionShouldGetAction(double inp)
        {
            var input = new StringReader(inp.ToString());
            Console.SetIn(input);

            Assert.Equal(inp, Program.GetAction(), 0);
        }
        
        [Theory]
        [MemberData(nameof(_input))]
        public void DoActionShouldDoSomething(double x, double y, int z){
            Assert.Equal(1, Program.DoAction(x,y,z), 0);
        }

        [Fact]
        public void DoActionShouldThrowException(){
            Assert.Throws<FormatException>(()=>Program.DoAction(1,1,0));
        }
    }
}