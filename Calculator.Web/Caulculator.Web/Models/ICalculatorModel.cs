//-----------------------------------------------------------------------
// <copyright file=" ICalculatorModel.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Models
{
    using System;

    /// <summary>
    /// Interface for model that handles calculator`s results manipulation.
    /// </summary>
    public interface ICalculatorModel
    {
        /// <summary>
        /// Gets or sets calculator`s result identifier.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets calculator`s expression.
        /// </summary>
        string Expression { get; set; }

        /// <summary>
        /// Gets or sets  calculator`s result.
        /// </summary>
        Double Result { get; set; }

    }
}
