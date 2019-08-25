//-----------------------------------------------------------------------
// <copyright file=" Calculations.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Calculator`s result model
    /// </summary>
    public class Calculations: ICalculatorModel
    {
        /// <summary>
        /// Gets or sets calculator`s result identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets calculator`s expression.
        /// </summary>
        [Required]
        public string Expression { get; set; }

        /// <summary>
        /// Gets or sets  calculator`s result.
        /// </summary>
        [Required]
        public Double Result { get; set; }
    }
}
