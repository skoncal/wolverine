// <auto-generated/>
#pragma warning disable
using FluentValidation;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Http.FluentValidation;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_validate_customer
    public class POST_validate_customer : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Http.FluentValidation.IProblemDetailSource<WolverineWebApi.Validation.CreateCustomer> _problemDetailSource;
        private readonly FluentValidation.IValidator<WolverineWebApi.Validation.CreateCustomer> _validator;

        public POST_validate_customer(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Http.FluentValidation.IProblemDetailSource<WolverineWebApi.Validation.CreateCustomer> problemDetailSource, FluentValidation.IValidator<WolverineWebApi.Validation.CreateCustomer> validator) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _problemDetailSource = problemDetailSource;
            _validator = validator;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            // Reading the request body via JSON deserialization
            var (customer, jsonContinue) = await ReadJsonAsync<WolverineWebApi.Validation.CreateCustomer>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            
            // Execute FluentValidation validators
            var result1 = await Wolverine.Http.FluentValidation.Internals.FluentValidationHttpExecutor.ExecuteOne<WolverineWebApi.Validation.CreateCustomer>(_validator, _problemDetailSource, customer).ConfigureAwait(false);

            // Evaluate whether or not the execution should be stopped based on the IResult value
            if (!(result1 is Wolverine.Http.WolverineContinue))
            {
                await result1.ExecuteAsync(httpContext).ConfigureAwait(false);
                return;
            }


            
            // The actual HTTP request handler execution
            var result_of_Post = WolverineWebApi.Validation.ValidatedEndpoint.Post(customer);

            await WriteString(httpContext, result_of_Post);
        }

    }

    // END: POST_validate_customer
    
    
}

