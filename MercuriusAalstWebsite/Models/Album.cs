namespace MercuriusAalstWebsite.Models;

public class Album
{
	public string Name { get; set; } = default!;
	public DateOnly DateOfEvent { get; set; }
	public string Link { get; set; } = default!;

	//private Album() { }

	public Album(string name, DateOnly dateOfEvent, string link)
	{
		Name = name;
		DateOfEvent = dateOfEvent;
		Link = link;
	}
}
