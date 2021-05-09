using System.Collections.Generic;

namespace THPS.Models.Maps
{
	//class THPS12THPS1
	//{
	//}

	public class Warehouse : GameMap
	{
		public int Id = 100;
		public string Name = "Warehouse";
		public string RWLocation = "Albany, NY";
		public List<Achievement> Achievements = new()
		{
			new(10001, "High Score - 10,000"),
			new(10002, "Pro Score - 50,000"),
			new(10003, "Sick Score - 100,000"),
			new(10004, "High Combo - 7,500"),
			new(10005, "Collect S-K-A-T-E"),
			new(10006, "Collect 5 Hydrants"),
			new(10007, "Smash the Boxes"),
			new(10008, "50-50 the Big Rail Gap"),
			new(10009, "Ollie a Channel Gap"),
			new(10010, "Get the secret tape"),
			new(10011, "Stat point 1"),
			new(10012, "Stat point 2"),
			new(10013, "Get Vigorous Visions (VV)"),
			new(10014, "Hit to explode the Alien Plushy"),
			new(10015, "Wallride the Monkey tag")
		};
	}

	public class School : GameMap
	{
		int Id = 101;
		string Name = "School";
		string RWLocation = "Miami";
		List<Achievement> Achievements = new()
		{
			new(10101, "High Score - 15,000"),
			new(10102, "Pro Score - 70,000"),
			new(10103, "Sick Score - 125,000"),
			new(10104, "High Combo - 10,000"),
			new(10105, "Collect S-K-A-T-E"),
			new(10106, "Collect 5 Textbooks"),
			new(10107, "Grind 5 Tables"),
			new(10108, "Wallride 5 Bells"),
			new(10109, "Heelflip the Kicker Gap"),
			new(10110, "Get the secret tape"),
			new(10111, "Stat point 1"),
			new(10112, "Stat point 2"),
			new(10113, "Stat point 3"),
			new(10114, "Get Vigorous Visions (VV)"),
			new(10115, "Hit to explode the Alien Plushy"),
			new(10116, "Wallride the Monkey tag")
		};
	}

	public class Mall : GameMap
	{
		int Id = 102;
		string Name = "Mall";
		string RWLocation = "New York";
		List<Achievement> Achievements = new()
		{
			new(10201, "High Score - 20,000"),
			new(10202, "Pro Score - 80,000"),
			new(10203, "Sick Score - 150,000"),
			new(10204, "High Combo - 15,000"),
			new(10205, "Get S-K-A-T-E"),
			new(10206, "Collect 5 Toy Robots"),
			new(10207, "Destroy 5 Directories"),
			new(10208, "Nose Grind the Coffee Grind Gap"),
			new(10209, "AirWalk the Flying Leap Gap"),
			new(10210, "Get the secret tape"),
			new(10211, "Stat point 1"),
			new(10212, "Stat point 2"),
			new(10213, "Stat point 3"),
			new(10214, "Get Vigorous Visions (VV)"),
			new(10215, "Hit to explode the Alien Plushy"),
			new(10216, "Wallride the Monkey tag")
		};
	}

	public class SkatePark : GameMap
	{
		int Id = 103;
		string Name = "Skate Park";
		string RWLocation = "Chicago";
		List<Achievement> Achievements = new()
		{
			new(10301, "Bronze Medal"),
			new(10302, "Silver Medal"),
			new(10303, "Gold Medal"),
			new(10304, "Stat point 1"),
			new(10305, "Stat point 2"),
			new(10306, "Stat point 3"),
			new(10307, "Get Vigorous Visions (VV)"),
			new(10308, "Hit to explode the Alien Plushy"),
			new(10309, "Wallride the Monkey tag")
		};
	}

	public class Downtown : GameMap
	{
		int Id = 104;
		string Name = "Downtown";
		string RWLocation = "Minneapolis";
		List<Achievement> Achievements = new()
		{
			new(10401, "High Score - 25,000"),
			new(10402, "Pro Score - 90,000"),
			new(10403, "Sick Score - 175,000"),
			new(10404, "High Combo - 18,000"),
			new(10405, "Get S-K-A-T-E"),
			new(10406, "Collect 5 Popcorn Buckets"),
			new(10407, "Break 5 \"No Skating\" Signs"),
			new(10408, "Complete the Rooftop Gaps"),
			new(10409, "Ollie the Parked Cars"),
			new(10410, "Get the secret tape"),
			new(10411, "Stat point 1"),
			new(10412, "Stat point 2"),
			new(10413, "Stat point 3"),
			new(10414, "Stat point 4"),
			new(10415, "Get Vigorous Visions (VV)"),
			new(10416, "Hit to explode the Alien Plushy"),
			new(10417, "Wallride the Monkey tag")
		};
	}
	
	public class DownhillJam : GameMap
	{
		int Id = 105;
		string Name = "Downhill Jam";
		string RWLocation = "Phoenix";
		List<Achievement> Achievements = new()
		{
			new(10501, "High Score - 40,000"),
			new(10502, "Pro Score - 100,000"),
			new(10503, "Sick Score - 200,000"),
			new(10504, "High Combo - 20,000"),
			new(10505, "Get S-K-A-T-E"),
			new(10506, "Open 5 Valves"),
			new(10507, "Collect 5 Hard Hats"),
			new(10508, "Madonna the Huge Water Hazard Gap"),
			new(10509, "Air Walk the Hydrophobic Gap"),
			new(10510, "Get the secret tape"),
			new(10511, "Stat point 1"),
			new(10512, "Stat point 2"),
			new(10513, "Stat point 3"),
			new(10515, "Get Vigorous Visions (VV)"),
			new(10516, "Hit to explode the Alien Plushy"),
			new(10517, "Wallride the Monkey tag")
		};
	}

	public class Burnside : GameMap
	{
		int Id = 106;
		string Name = "Burnside";
		string RWLocation = "Portland";
		List<Achievement> Achievements = new()
		{
			new(10601, "Bronze Medal"),
			new(10602, "Silver Medal"),
			new(10603, "Gold Medal"),
			new(10604, "Stat point 1"),
			new(10605, "Stat point 2"),
			new(10606, "Stat point 3"),
			new(10607, "Get Vigorous Visions (VV)"),
			new(10608, "Hit to explode the Alien Plushy"),
			new(10609, "Wallride the Monkey tag")
		};
	}
	
	public class Streets : GameMap
	{
		int Id = 107;
		string Name = "Streets";
		string RWLocation = "San Francisco";
		List<Achievement> Achievements = new()
		{
			new(10701, "High Score - 50,000"),
			new(10702, "Pro Score - 125,000"),
			new(10703, "Sick Score - 250,000"),
			new(10704, "High Combo - 40,000"),
			new(10705, "Get S-K-A-T-E"),
			new(10706, "Wreck 5 Cop Cars"),
			new(10707, "Collect 5 Life Preservers"),
			new(10708, "Nosegrab the Hubba Gap"),
			new(10709, "5-0 Around the Fountain"),
			new(10710, "Get the secret tape"),
			new(10711, "Stat point 1"),
			new(10712, "Stat point 2"),
			new(10713, "Stat point 3"),
			new(10714, "Stat point 4"),
			new(10715, "Get Vigorous Visions (VV)"),
			new(10716, "Hit to explode the Alien Plushy"),
			new(10717, "Wallride the Monkey tag")
		};
	}

	public class Roswell : GameMap
	{
		int Id = 108;
		string Name = "Roswell";
		string RWLocation = "New Mexico";
		List<Achievement> Achievements = new()
		{
			new(10801, "Bronze Medal"),
			new(10802, "Silver Medal"),
			new(10803, "Gold Medal"),
			new(10804, "Stat point 1"),
			new(10805, "Stat point 2"),
			new(10806, "Stat point 3"),
			new(10807, "Get Vigorous Visions (VV)"),
			new(10808, "Hit to explode the Alien Plushy"),
			new(10809, "Wallride the Monkey tag")
		};
	}
}
