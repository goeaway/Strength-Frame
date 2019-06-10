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
    public class GetWorkoutHandler : IRequestHandler<GetWorkoutRequest, WorkoutDTO>
    {
        private readonly IExerciseAppRepository<Workout> _repository;

        public GetWorkoutHandler(IExerciseAppRepository<Workout> repository)
        {
            _repository = repository;
        }

        public Task<WorkoutDTO> Handle(GetWorkoutRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
