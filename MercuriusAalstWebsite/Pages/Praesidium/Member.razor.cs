using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using MercuriusAalstWebsite.Models;

namespace MercuriusAalstWebsite.Pages.Praesidium;

public partial class Member
{
	[Parameter]
	public PrLid PrLid { get; set; } = default!;

	[Inject]
	public IDialogService Dialog { get; set; } = default!;

	private async void OpenDialog()
	{
		var parameters = new DialogParameters { { "Member", PrLid } };
		var options = new DialogOptions()
		{ CloseButton = true, CloseOnEscapeKey = true, MaxWidth = MaxWidth.Medium, FullWidth = true };
		Dialog.Show<MemberDialog>("", parameters, options);
	}
}