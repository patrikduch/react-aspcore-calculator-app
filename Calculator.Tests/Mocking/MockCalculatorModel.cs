namespace Calculator.Tests.Mocking
{
    using Web.Models;

    public class MockCalculatorModel : ICalculatorModel
    {
        public int Id { get; set; }
        public string Expression { get; set; }
        public double Result { get; set; }
    }
}
