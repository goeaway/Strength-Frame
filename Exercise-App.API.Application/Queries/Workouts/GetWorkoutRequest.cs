using System;
using System.Collections.Generic;
using System.Text;
using Exercise_App.API.Application.Models.DTO;
using MediatR;

namespace Exercise_App.API.Application.Queries.Workouts
{
    public class GetWorkoutRequest : IRequest<WorkoutDTO>
    {
        public int ID { get; set; }

        public GetWorkoutRequest(int id)
        {
            ID = id;
        }
    }
}
