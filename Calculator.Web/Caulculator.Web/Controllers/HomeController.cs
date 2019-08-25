//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

namespace Calculator.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller which is mapped to the SPA view
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Get home index action
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            return View();
        }
    }
}