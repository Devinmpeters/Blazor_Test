using System.ComponentModel.DataAnnotations;

namespace Blazor_Test.Components.Models
{
    public class PlayerInfo
    {
        [Key]
        public int IntPlayerInfoID { get; set; }
        public int CampaignID { get; set; }
        public string? CampaignDescrip { get; set; }
        public string? PlayerName { get; set; }
        public string? PlayerFirstName { get; set; } //change to CharacterFirstName in DB
        public string? PlayerLastName { get; set; } //Change to CharacterLastName in DB
        public string? PlayerRace { get; set; }
        public string? PlayerClass { get; set; }
        public string? PlayerSubClass { get; set; }
        public string? PlayerBackground { get; set; }
        public int PlayerSpeed { get; set; }
        public int PlayerAC { get; set; }
        public int PlayerLevel { get; set; }
        public int PlayerMaxHP { get; set; }
    }
}