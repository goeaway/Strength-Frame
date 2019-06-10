using System;
using System.Collections.Generic;
using System.Text;
using Exercise_App.API.Application.Models.DTO;
using MediatR;

namespace Exercise_App.API.Application.Queries.Workouts
{
    public class GetWorkoutsRequest : IRequest<IEnumerable<WorkoutDTO>>
    {

    }
}
