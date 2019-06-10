using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Exercise_App.API.Application.Commands.Workouts
{
    public class WorkoutDeleteRequest : IRequest<WorkoutDeleteResponse>
    {
        public int ID { get; set; }

        public WorkoutDeleteRequest(int id)
        {
            ID = id;
        }
    }
}
