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
        public string? CharFirstName { get; set; } //change to CharacterFirstName in DB
        public string? CharLastName { get; set; } //Change to CharacterLastName in DB
        public string? CharRace { get; set; }
        public string? CharClass { get; set; }
        public string? CharSubClass { get; set; }
        public string? CharBackground { get; set; }
        public int CharSpeed { get; set; }
        public int CharAC { get; set; }
        public int CharLevel { get; set; }
        public int CharMaxHP { get; set; }
    }
}