using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise_App.API.Application.Commands.Workouts;
using Exercise_App.API.Application.Models.DTO;
using Exercise_App.API.Application.Queries.Workouts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_App.API.Presentation.Controllers
{
    [Route("[controller]")]
    public class WorkoutController : Controller
    {
        private readonly IMediator _mediator;

        public WorkoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get")] 
        public Task<IEnumerable<WorkoutDTO>> Get()
        {
            return _mediator.Send(new GetWorkoutsRequest());
        }

        [HttpGet("get/{id}")]
        public Task<WorkoutDTO> Get(int id)
        {
            return _mediator.Send(new GetWorkoutRequest(id));
        }

        [HttpPost("create")]
        public Task<WorkoutCreateResponse> Create(WorkoutDTO workout)
        {
            return _mediator.Send(new WorkoutCreateRequest(workout));
        }

        [HttpPatch("update")]
        public Task<WorkoutUpdateResponse> Update(WorkoutDTO workout)
        {
            return _mediator.Send(new WorkoutUpdateRequest(workout));
        }

        [HttpDelete("delete/{id}")]
        public Task<WorkoutDeleteResponse> Delete(int id)
        {
            return _mediator.Send(new WorkoutDeleteRequest(id));
        }
    }
}