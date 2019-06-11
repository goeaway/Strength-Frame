using Exercise_App.API.Application.Models.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Queries.Exercises
{
    public class GetExercisesRequest : IRequest<IEnumerable<ExerciseDTO>>
    {
        public int WorkoutID { get; set; }
    }
}
