using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Exceptions
{
    public class RepositoryException : ExerciseAppException
    {
        public RepositoryException() { }
        public RepositoryException(string message) : base(message) { }
        public RepositoryException(string message, Exception exception) : base(message, exception) { }
    }
}
