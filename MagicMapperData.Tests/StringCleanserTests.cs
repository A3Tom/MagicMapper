namespace MagicMapper.Tests
{
    using MagicMapperData.Classes;
    using MagicMapperData.Interfaces;
    using Xunit;

    public class StringCleanserTests
    {
        private IStringCleanser Sut;

        public StringCleanserTests()
        {
            Sut = new StringCleanser();
        }

        [Theory]
        [InlineData("From = Lot;", "")]
        [InlineData("Relations.Add(LineListOrder", "")]
        [InlineData("Relations.Add(LineListOrder,", "LineListOrder")]
        [InlineData("Relations.Add(FranchiseeLLOrderCancelled,", "FranchiseeLLOrderCancelled")]
        [InlineData("		FranchiseeLLOrderCancelled.LineListNumber.IsEqualTo(LineListOrder.LineListNumber).And(", "")]
        public void ReturnModelName_FromDirtyLine_ToString(string inputString, string expectedOutput)
        {
            var actual = Sut.Return_SQLModelUsed_ToString(inputString);

            Assert.Equal(expectedOutput, actual);
        }
    }
}
