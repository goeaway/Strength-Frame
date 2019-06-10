using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;

namespace Exercise_App.API.Application.Exceptions
{
    public class RequestValidationFailureException : ExerciseAppException
    {
        public IEnumerable<ValidationFailure> Failures { get; }

        public RequestValidationFailureException(IEnumerable<ValidationFailure> failures)
        {
            Failures = failures;
        }

        public RequestValidationFailureException() { }
        public RequestValidationFailureException(string message) : base(message) { }
        public RequestValidationFailureException(string message, Exception exception) : base(message, exception) { }
    }
}
