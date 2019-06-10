using System;
using System.Collections.Generic;
using System.Text;
using Exercise_App.API.Application.Models.DTO;
using MediatR;

namespace Exercise_App.API.Application.Commands.Workouts
{
    public class WorkoutUpdateRequest : IRequest<WorkoutUpdateResponse>
    {
        public WorkoutDTO DTO { get; set; }

        public WorkoutUpdateRequest(WorkoutDTO dto)
        {
            DTO = dto;
        }
    }
}
