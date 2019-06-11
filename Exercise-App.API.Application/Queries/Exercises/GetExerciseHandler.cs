using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_App.API.Application.Queries.Exercises
{
    public class GetExerciseHandler : IRequestHandler<GetExerciseRequest, GetExerciseResponse>
    {
        public Task<GetExerciseResponse> Handle(GetExerciseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
