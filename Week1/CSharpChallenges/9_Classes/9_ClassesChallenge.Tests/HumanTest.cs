using System;
using Xunit;
using System.Collections.Generic;
using System.IO;
using _9_ClassesChallenge;
namespace _9_ClassesChallenge.Tests
{
    public class HumanTest
    {
        public static Human testHuman = new Human();
        public static readonly IEnumerable<object[]> _humans = new List<object[]>()
        {
            new object[]{new Human("Marielle", "Nolasco", "Brown", 21)},
            new object[]{new Human("Marielle", "Nolasco", "Brown")},
            new object[]{new Human("Marielle", "Nolasco", 21)},
            new object[]{new Human("Marielle", "Nolasco")}
        };
        public static readonly StringWriter output = new StringWriter();
        [Fact]
        public void HumanShouldSetDefaultNames()
        {
            Assert.Equal("Pat", testHuman.firstName);
            Assert.Equal("Smyth", testHuman.lastName);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(500)]
        public void HumanShouldVerifyWeight(int weight)
        {
            Assert.Throws<Exception>(() => testHuman.Weight = weight);
        }

        [Fact]
        public void HumanShouldSetWeight()
        {
            testHuman.Weight = 100;
            Assert.Equal(100, testHuman.Weight);
        }

        [Theory]
        [MemberData(nameof(_humans))]
        public void AboutMeShouldPrintAppropriateMessage(Human human)
        {
            Console.SetOut(output);
            human.AboutMe();
            
            if (human.age == 0 && human.eyeColor == null)
                Assert.Contains($"My name is {human.firstName} {human.lastName}.", output.ToString());
            else if (human.age == 0)
                Assert.Contains($"My name is {human.firstName} {human.lastName}. My eye color is {human.eyeColor}.", output.ToString());
            else if (human.eyeColor == null)
                Assert.Contains($"My name is {human.firstName} {human.lastName}. My age is {human.age}.", output.ToString());
            else
                Assert.Contains($"My name is {human.firstName} {human.lastName}. My eye color is {human.eyeColor} and my age is {human.age}.", output.ToString());

            //clear console output
            output.GetStringBuilder().Remove(0, output.GetStringBuilder().Length);
        }
    }
}
