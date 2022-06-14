﻿using System;
using Gym_API.Models;

namespace Gym_API.Dto
{
	public class GroupDto
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string TrainerId { get; set; }

		public virtual ICollection<string> CustomerIds { get; set; }
		public virtual ICollection<ScheduleDto> Schedules { get; set; }
	}
}

