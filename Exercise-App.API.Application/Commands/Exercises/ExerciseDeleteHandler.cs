using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Exercise_App.API.Application.Commands.Exercises
{
    public class ExerciseDeleteHandler : IRequestHandler<ExerciseDeleteRequest, ExerciseDeleteResponse>
    {
        public Task<ExerciseDeleteResponse> Handle(ExerciseDeleteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
