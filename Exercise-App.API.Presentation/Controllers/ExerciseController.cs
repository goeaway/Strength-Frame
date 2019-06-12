using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise_App.API.Application.Commands.Exercises;
using Exercise_App.API.Application.Models.DTO;
using Exercise_App.API.Application.Queries.Exercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_App.API.Presentation.Controllers
{
    [Route("[controller]")]
    public class ExerciseController : Controller
    {
        private readonly IMediator _mediator;

        public ExerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<ExerciseDTO>> GetForWorkout(int workoutId)
        {
            return _mediator.Send(new GetExercisesRequest() { WorkoutID = workoutId });
        }

        [HttpGet]
        public Task<IEnumerable<ExerciseDTO>> Get()
        {
            return _mediator.Send(new GetExercisesRequest());
        }

        [HttpGet("{id}")]
        public Task<ExerciseDTO> Get(int id)
        {
            return _mediator.Send(new GetExerciseRequest(id));
        }

        [HttpPost]
        public Task<ExerciseCreateResponse> Create(ExerciseDTO exercise)
        {
            return _mediator.Send(new ExerciseCreateRequest(exercise));
        }

        [HttpPatch]
        public Task<ExerciseUpdateResponse> Update(ExerciseDTO exercise)
        {
            return _mediator.Send(new ExerciseUpdateRequest(exercise));
        }

        [HttpDelete("{id}")]
        public Task<ExerciseDeleteResponse> Delete(int id)
        {
            return _mediator.Send(new ExerciseDeleteRequest(id));
        }
    }
}