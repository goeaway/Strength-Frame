using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Models.Entities
{
    public class Exercise
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int WorkoutID { get; set; }

        public Workout Workout { get; set; }
    }
}
