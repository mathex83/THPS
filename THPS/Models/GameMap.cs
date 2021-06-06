using System;
using System.Collections.Generic;

namespace THPS.Models
{
	public class GameMap
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string RWLocation { get; set; }
		public List<Achievement> Achievements = new();
	}

	public class Achievement
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Achievement(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}

	public class Trophy
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Trophy(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}
