using Exercise_App.API.Application.Models.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_App.API.Application.Queries.Exercises
{
    public class GetExercisesHandler : IRequestHandler<GetExercisesRequest, IEnumerable<ExerciseDTO>>
    {
        public Task<IEnumerable<ExerciseDTO>> Handle(GetExercisesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
