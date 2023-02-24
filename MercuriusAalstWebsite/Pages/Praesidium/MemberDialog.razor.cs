using Microsoft.AspNetCore.Components;
using MercuriusAalstWebsite.Models;

namespace MercuriusAalstWebsite.Pages.Praesidium;

public partial class MemberDialog
{
    [Parameter]
    public PrLid member { get; set; } = default !;
}