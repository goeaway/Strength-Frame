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
    public class WorkoutDeleteHandler : IRequestHandler<WorkoutDeleteRequest, WorkoutDeleteResponse>
    {
        private readonly IExerciseAppRepository<Workout> _repository;

        public WorkoutDeleteHandler(IExerciseAppRepository<Workout> repository)
        {
            _repository = repository;
        }

        public Task<WorkoutDeleteResponse> Handle(WorkoutDeleteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
