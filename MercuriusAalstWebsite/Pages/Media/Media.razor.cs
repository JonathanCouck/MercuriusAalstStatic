using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using MercuriusAalstWebsite;
using MercuriusAalstWebsite.Shared;
using MudBlazor;
using MercuriusAalstWebsite.Models;

namespace MercuriusAalstWebsite.Pages.Media;

public partial class Media
{

	private Album[] albums = {
		new Album("Halloween Cantus", new DateOnly(2022, 11, 03), "https://photos.app.goo.gl/EpoQUaEXvtZ3T2xp8"),
		new Album("Nadoop", new DateOnly(2022, 04, 24), "https://photos.app.goo.gl/JpTFZJDmtvNGGyEXA"),
		new Album("Mercurius Fuif", new DateOnly(2022, 05, 24), "https://photos.app.goo.gl/JpTFZJDmtvNGGyEXA"),
		new Album("Brouwerijbezoek", new DateOnly(2022, 06, 24), "https://photos.app.goo.gl/JpTFZJDmtvNGGyEXA"),
		new Album("Mercurius On Ice", new DateOnly(2022, 07, 24), "https://photos.app.goo.gl/JpTFZJDmtvNGGyEXA"),
		new Album("Boardgame Clubavond", new DateOnly(2022, 08, 24), "https://photos.app.goo.gl/JpTFZJDmtvNGGyEXA"),
		new Album("Gluhwein Cantus", new DateOnly(2022, 09, 24), "https://photos.app.goo.gl/JpTFZJDmtvNGGyEXA")
	};
}