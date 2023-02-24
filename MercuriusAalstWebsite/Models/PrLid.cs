namespace MercuriusAalstWebsite.Models;

public class PrLid
{
	public string FirstName { get; set; } = default!;
	public string LastName { get; set; } = default!;
	public string NickName { get; set; } = default!;
	public string Function { get; set; } = default!;
	public string ImageUrl { get; set; } = default!;
	public string Study { get; set; } = default!;
	public string BaptiseYear { get; set; } = default!;
	public string PetMet { get; set; } = default!;
	public string Quote { get; set; } = default!;
	public string QuoteBy { get; set; } = default!;
	public string Song { get; set; } = default!;

	//private PrLid() { }

	public PrLid(
		string firstName,
		string lastName,
		string nickName,
		string function,
		string imageUrl,
		string study,
		string baptiseYear,
		string petMet,
		string quote,
		string quoteBy,
		string song
		)
	{
		FirstName = firstName;
		LastName = lastName;
		NickName = nickName;
		Function = function;
		ImageUrl = imageUrl;
		Study = study;
		BaptiseYear = baptiseYear;
		PetMet = petMet;
		Quote = quote;
		QuoteBy = quoteBy;
		Song = song;
	}
}