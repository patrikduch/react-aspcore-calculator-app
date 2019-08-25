namespace Calculator.Tests
{

    using Mocking;
    using Calculator.Tests.Mocking;
    using Xunit;

    public class CalculatorTests
    {
        [Fact]
        public void CalculationExpressionAttributeIsEmpty_Test()
        {
            MockCalculatorLogRepository calculatorLogRepository = new MockCalculatorLogRepository();

            MockCalculatorModel mockModel = new MockCalculatorModel
            {
                Expression = ""
            };

            var ret = calculatorLogRepository.AddCalculation(mockModel);

            Assert.Null(ret);
        }
    }
}
