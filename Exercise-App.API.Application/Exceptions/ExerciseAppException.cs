using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Exceptions
{
    public class ExerciseAppException : Exception
    {
        public ExerciseAppException() { }
        public ExerciseAppException(string message) : base(message) { }
        public ExerciseAppException(string message, Exception exception) : base(message, exception) { }
    }
}
