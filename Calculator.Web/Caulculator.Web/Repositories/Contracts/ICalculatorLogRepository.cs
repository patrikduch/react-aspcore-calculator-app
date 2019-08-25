//-----------------------------------------------------------------------
// <copyright file="ICalculatorLogRepository.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Repositories.Contracts
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Interface contract for <seealso cref="CalculatorLogRepository"/> class.
    /// </summary>
    public interface ICalculatorLogRepository
    {
        /// <summary>
        /// Get all calculator`s results from database
        /// </summary>
        /// <returns></returns>
        List<Calculations> GetCalculation();

        /// <summary>
        /// Add new result to the database log
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        ICalculatorModel AddCalculation(ICalculatorModel model);
    }
}
