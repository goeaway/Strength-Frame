using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_App.API.Application.Commands.Exercises
{
    public class ExerciseCreateHandler : IRequestHandler<ExerciseCreateRequest, ExerciseCreateResponse>
    {
        public Task<ExerciseCreateResponse> Handle(ExerciseCreateRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
