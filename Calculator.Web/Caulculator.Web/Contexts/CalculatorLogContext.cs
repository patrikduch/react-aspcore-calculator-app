//-----------------------------------------------------------------------
// <copyright file="CalculatorLogContext.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Contexts
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Database context to store and manipulate with calculator`s results
    /// </summary>
    public class CalculatorLogContext : DbContext
    {

        /// <summary>
        /// Initializes a new instance of the <seealso cref="CalculatorLogContext"/> class.
        /// </summary>
        /// <param name="options">Db configuration options</param>
        public CalculatorLogContext(DbContextOptions<CalculatorLogContext> options) : base(options)
        {
        }

        /// <summary>
        /// Db set of all possible stored calculations
        /// </summary>
        public DbSet<Calculations> Calculations { get; set; }

    }
}
