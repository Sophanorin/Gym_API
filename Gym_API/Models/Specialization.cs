﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Gym_API.Models.Base;

namespace Gym_API.Models
{
	public class Specialization: BaseModel
	{
        
        public Specialization():base()
        {
        }

        public Specialization(string Name) : base(Name)
        {

        }
    }
}

