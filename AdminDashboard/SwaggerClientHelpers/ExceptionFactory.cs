﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace AdminDashboard.SwaggerClientHelpers
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}