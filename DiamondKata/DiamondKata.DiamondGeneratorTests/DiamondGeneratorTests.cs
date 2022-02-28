using DiamondKata.DiamondGenerator;
using Xunit;


namespace DiamondKataTests
{
    public class DiamondGeneratorTests
    {
        //Test for userinput is valid:  (not all testcase, just some testcase)
        [Theory]
        [InlineData("H")]
        [InlineData("Z")]
        public void UserInput_IsValid(string input)
        {
            DiamondGenerator dg = new DiamondGenerator();
            bool result = dg.IsValidLetter(char.Parse(input));
            Assert.Equal(true, result);
        }
        [Theory]
        [InlineData(" ")]
        public void UserInput_IsInvalid(string input)
        {
            DiamondGenerator dg = new DiamondGenerator();
            bool result = dg.IsValidLetter(char.Parse(input));
            Assert.Equal(false, result);
        }

        //Created some tests for input char: (not all)
        [Fact]
        public void InputChar_B_should_be_addcorrect_array()
        {
            DiamondGenerator tasks = new DiamondGenerator();
            string result = tasks.GenerateHalfDiamond(1);
            Assert.Equal(" AB B", result);
        }
        [Fact]
        public void InputChar_C_should_be_addcorrect_array()
        {
            DiamondGenerator tasks = new DiamondGenerator();
            string result = tasks.GenerateHalfDiamond(2);
            Assert.Equal("  A B BC   C", result);
        }
    }
}