using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Exercise_App.API.Application.Abstractions;
using Exercise_App.API.Application.Models.Entities;
using MediatR;

namespace Exercise_App.API.Application.Commands.Workouts
{
    public class WorkoutCreateHandler : IRequestHandler<WorkoutCreateRequest, WorkoutCreateResponse>
    {
        private readonly IExerciseAppRepository<Workout> _repository;

        public WorkoutCreateHandler(IExerciseAppRepository<Workout> repository)
        {
            _repository = repository;
        }

        public Task<WorkoutCreateResponse> Handle(WorkoutCreateRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
