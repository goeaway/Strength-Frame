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
    public class WorkoutUpdateHandler : IRequestHandler<WorkoutUpdateRequest, WorkoutUpdateResponse>
    {
        private readonly IExerciseAppRepository<Workout> _repository;

        public WorkoutUpdateHandler(IExerciseAppRepository<Workout> repository)
        {
            _repository = repository;
        }

        public Task<WorkoutUpdateResponse> Handle(WorkoutUpdateRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
