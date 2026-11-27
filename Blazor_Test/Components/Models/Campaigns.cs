using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Test.Components.Models;

public class Campaigns
{
    [Key]
    public int IntCampaignID { get; set; }
    public string CampaignDescrip { get; set; }
    public string Players { get; set; }
    public string GameMaster { get; set; }
    public string GameSystem { get; set; }
}