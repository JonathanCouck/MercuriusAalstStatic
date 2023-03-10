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

namespace MercuriusAalstWebsite.Pages.Geschiedenis;

public partial class Geschiedenis
{
    private string[][] _timelineItems = new string[][]
    {
        new string[] {"1970", "Title #1", "This will be the text of the item on our timeline. These will explain whatever happened in this year."},
        new string[] {"1971", "Title #2", "This will be the text of the item on our timeline. These will explain whatever happened in this year."},
        new string[] {"1972", "Title #3", "This will be the text of the item on our timeline. These will explain whatever happened in this year."},
        new string[] {"1973", "Title #4", "This will be the text of the item on our timeline. These will explain whatever happened in this year."},
        new string[] {"1974", "Title #5", "This will be the text of the item on our timeline. These will explain whatever happened in this year."},
    };

    private string[][] _proseniorItems = new string[][]
    {
        new string[] {"2021-22", "Sven Pepermans", "Duivenmelker"},
        new string[] {"2020-21", "Julie Deboel", ""},
        new string[] {"2018-20", "Elien De Backer", "Backie"},
        new string[] {"2017-18", "Kristof van Moorter", "Krissie"},
        new string[] {"2016-17", "Sander Vonck", ""},
        new string[] {"2015-16", "Anke De Spiegeleer", ""},
        new string[] {"2014-15", "Ken Roosens", ""},
        new string[] {"2013-14", "Brigitte Bauwens", "B"},
        new string[] {"2012-13", "Ignace De Brucker", "Lowie"},
        new string[] {"2010-12", "Micha?l De Corte", "Ketten"},
        new string[] {"2009-10", "Sarah De Mesmaeker", "Facteur"},
        new string[] {"2008-09", "Kenneth De Meyer", "Filiep"},
        new string[] {"2007-08", "Lindsay Van Den Bremt", "Linsken"},
        new string[] {"2006-07", "Jonas De Bruyn", "Jones"},
        new string[] {"2005-06", "Koen De Spiegeleir", "Ludo"},
        new string[] {"2004-05", "Joris De Groot", "Jak"},
        new string[] {"2003-04", "Sabrina Van Hauwe", "Triplex"},
        new string[] {"2002-03", "Stijn De Brucker", "Zwerver"},
        new string[] {"2001-02", "Dimitri Dubois", "Pinky"},
        new string[] {"2000-01", "Gwendy Van Ransbeek", "Tandje"},
        new string[] {"1999-00", "Frederik Van Hecke", "Fred"},
        new string[] {"1998-99", "Kim Schollaert", "El Lankour"},
        new string[] {"1997-98", "David Vermeir", "De Kont"},
        new string[] {"1995-97", "Pascal Claessens", "Scalle"},
        new string[] {"1994-95", "Tony Mouton", "Den Bleeken"},
        new string[] {"1993-94", "Geert Bruyneel", "Den Broinen"},
        new string[] {"1992-93", "Tom Van Pelt", ""},
        new string[] {"1991-92", "Wim Wachtelaer", "Badmoesj"},
        new string[] {"1990-91", "Dirk De Munter", ""},
        new string[] {"1989-90", "Katrien De Neve", ""},
        new string[] {"1987-89", "Patrick Van Waeyenbergh", ""},
        new string[] {"1986-87", "Peter Van Accolyen", ""},
    };
}