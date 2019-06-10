using System;
using System.Collections.Generic;
using System.Text;
using Exercise_App.API.Application.Commands.Workouts;
using FluentValidation;

namespace Exercise_App.API.Application.Validators.Workouts
{
    public class WorkoutDeleteValidator : AbstractValidator<WorkoutDeleteRequest>
    {
        public WorkoutDeleteValidator()
        {
            RuleFor(model => model.ID).GreaterThan(-1);
        }
    }
}
