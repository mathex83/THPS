namespace THPS.Models
{
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
}
