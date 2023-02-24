namespace MercuriusAalstWebsite.Models;

public class Activiteit
{
	public string Name { get; set; } = default!;
	public string Location { get; set; } = default!;
	public DateTime Start { get; set; }
	public bool Open { get; set; }
	public string ImageUrl { get; set; } = default!;
	public string LinkUrl { get; set; } = default!;

	//private Activiteit() { }

	public Activiteit(string name, string location, DateTime start, bool open, string imageUrl, string linkUrl)
	{
		Name = name;
		Location = location;
		Start = start;
		Open = open;
		ImageUrl = imageUrl;
		LinkUrl = linkUrl;
	}
}
