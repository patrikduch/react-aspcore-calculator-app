using System.Collections.Generic;
using Calculator.Web.Models;
using Calculator.Web.Repositories.Contracts;namespace Calculator.Tests.Mocking
{
    public class MockCalculatorLogRepository : ICalculatorLogRepository
    {
        public List<Calculations> GetCalculation()
        {
            return  new List<Calculations>
            {
                new Calculations
                {
                    Id = 1,
                    Expression = "1+2",
                    Result = 3
                    
                    
                }
            };
        }

        public ICalculatorModel AddCalculation(ICalculatorModel model)
        {
            if (model.Expression.Equals(string.Empty))
            {
                return null;
            }

            return model;
        }
    }
}
