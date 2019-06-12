using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Exercise_App.API.Application.Commands.Exercises
{
    public class ExerciseUpdateHandler : IRequestHandler<ExerciseUpdateRequest, ExerciseUpdateResponse>
    {
        public Task<ExerciseUpdateResponse> Handle(ExerciseUpdateRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
