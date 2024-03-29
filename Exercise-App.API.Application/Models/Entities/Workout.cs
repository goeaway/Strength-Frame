﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_App.API.Application.Models.Entities
{
    public class Workout
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        public ICollection<Exercise> Exercises { get; set; }
    }
}
