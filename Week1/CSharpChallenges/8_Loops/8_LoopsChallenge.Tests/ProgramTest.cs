using System;
using System.IO;
using Xunit;
using _8_LoopsChallenge;

namespace _8_LoopsChallenge.Tests
{
    public class ProgramTest
    {
        public static readonly StringWriter output = new StringWriter();

        [Fact]
        public void UseForShouldPrintOddTill50()
        {
            Console.SetOut(output);

            Program.UseFor();
            int i = 1;
            while (i < 50)
            {
                Assert.Contains($"{i} ", output.ToString());
                i += 2;
            }

            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }

        [Fact]
        public void UseDoWhileShouldPrintEvenTill50()
        {
            Console.SetOut(output);

            Program.UseDoWhile();
            int i = 0;
            while (i < 51)
            {
                Assert.Contains($"{i} ", output.ToString());
                i += 2;
            }

            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }

        [Fact]
        public void UseWhilehouldPrintMultiplesOf3()
        {
            Console.SetOut(output);

            Program.UseWhile();
            int i = 0;
            while (i < 100)
            {
                if(i%3==0 && i%5==0 )Assert.Contains("Skipping this number", output.ToString());
                else Assert.Contains($"{i}", output.ToString());
                i += 3;
            }

            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }
    }
}
