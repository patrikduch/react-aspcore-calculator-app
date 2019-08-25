//-----------------------------------------------------------------------
// <copyright file="CalculatorLogRepository.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Contexts;
    using Models;
    using Contracts;

    /// <summary>
    /// Repository for managing calculator`s results
    /// </summary>
    public class CalculatorLogRepository : ICalculatorLogRepository
    {
        /// <summary>
        /// Injectable reference to the CalculatorLogContext
        /// </summary>
        private readonly CalculatorLogContext _context;

        /// <summary>
        /// Initializes a new instance of the <seealso cref="CalculatorLogRepository"/> class.
        /// </summary>
        /// <param name="context">Db context for handling calculator`s results</param>
        public CalculatorLogRepository(CalculatorLogContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all calculator`s results
        /// </summary>
        /// <returns></returns>
        public List<Calculations> GetCalculation()
        {
           return _context.Calculations.ToList();
        }

        /// <summary>
        /// Add new calculator`s result
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ICalculatorModel AddCalculation(ICalculatorModel model)
        {
            _context.Calculations.Add((Calculations)model);
            _context.SaveChanges();

            return model;
        }
    }
}
