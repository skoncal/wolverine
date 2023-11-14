// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_results_static
    public class GET_results_static : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_results_static(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            
            // The actual HTTP request handler execution
            var arithmeticResults_response = WolverineWebApi.TestEndpoints.FetchStaticResults();

            // Writing the response body to JSON because this was the first 'return variable' in the method signature
            await WriteJsonAsync(httpContext, arithmeticResults_response);
        }

    }

    // END: GET_results_static
    
    
}

