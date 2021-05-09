using System;
using System.Collections.Generic;

namespace THPS.Models
{
	public class GameMap
	{
		private int Id { get; set; }
		private string Name { get; set; }
		private string RWLocation { get; set; }
		private List<Achievement> Achievements = new();
	}
}
