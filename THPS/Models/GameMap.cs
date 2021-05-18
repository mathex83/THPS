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
}
