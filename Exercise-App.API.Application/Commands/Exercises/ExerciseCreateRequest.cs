using Exercise_App.API.Application.Models.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Commands.Exercises
{
    public class ExerciseCreateRequest : IRequest<ExerciseCreateResponse>
    {
        public ExerciseDTO DTO { get; set; }

        public ExerciseCreateRequest(ExerciseDTO dto)
        {
            DTO = dto;
        }
    }
}
