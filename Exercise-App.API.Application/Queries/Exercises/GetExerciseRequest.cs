using Exercise_App.API.Application.Models.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Queries.Exercises
{
    public class GetExerciseRequest : IRequest<ExerciseDTO>
    {
        public int ID { get; set; }

        public GetExerciseRequest(int id)
        {
            ID = id;
        }
    }
}
