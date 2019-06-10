using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Exercise_App.API.Application.Abstractions;
using Exercise_App.API.Application.Models.DTO;
using Exercise_App.API.Application.Models.Entities;
using MediatR;

namespace Exercise_App.API.Application.Queries.Workouts
{
    public class GetWorkoutsHandler : IRequestHandler<GetWorkoutsRequest, IEnumerable<WorkoutDTO>>
    {
        private readonly IExerciseAppRepository<Workout> _repository;

        public GetWorkoutsHandler(IExerciseAppRepository<Workout> repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<WorkoutDTO>> Handle(GetWorkoutsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
