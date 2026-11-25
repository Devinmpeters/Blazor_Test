using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Test.Components.Models
{

    public class PlayerNames
    {
        [Key]
        public int IntPlayerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}