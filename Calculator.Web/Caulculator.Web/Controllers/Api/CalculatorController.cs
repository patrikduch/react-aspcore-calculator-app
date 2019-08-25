//-----------------------------------------------------------------------
// <copyright file="CalculatorController.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Controllers.Api
{
    using System.Collections.Generic;
    using Contexts;
    using Models;
    using Repositories;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    ///  REST API controller to handle calculator`s results
    /// </summary>
    public class CalculatorController : Controller
    {
        /// <summary>
        /// Injectable reference to the  <seealso cref="CalculatorLogRepository"/> repository class.
        /// </summary>
        private readonly CalculatorLogRepository _calculatorLogRepository;

        /// <summary>
        /// Initializes a new instance of the <seealso cref="CalculatorController"/> class.
        /// </summary>
        /// <param name="context">Db context for handling calculator`s results</param>
        public CalculatorController(CalculatorLogContext context)
        {
            _calculatorLogRepository = new CalculatorLogRepository(context);
        }

        /// <summary>
        /// Get calculations
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [Route("/Calculator/GetHistory")]
        [HttpGet]
        public List<Calculations> Get()
        {
            return _calculatorLogRepository.GetCalculation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("/Calculator/New")]
        public Calculations PostMethod1([FromBody]Calculations model)
        {

            if (model.Expression.Equals(string.Empty))
                return null;

            _calculatorLogRepository.AddCalculation(model);

            return model;
        }


    }
}