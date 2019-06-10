using System;
using System.Collections.Generic;
using System.Text;
using Exercise_App.API.Application.Models;
using Exercise_App.API.Application.Models.DTO;
using MediatR;

namespace Exercise_App.API.Application.Commands.Workouts
{
    public class WorkoutCreateRequest : IRequest<WorkoutCreateResponse>
    {
        public WorkoutDTO DTO { get; set; }

        public WorkoutCreateRequest(WorkoutDTO dto)
        {
            DTO = dto;
        }
    }
}
