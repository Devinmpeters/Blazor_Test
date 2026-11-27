using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Test.Components.Models;

public class CharacterImages
{
    [Key]
    public int IntPlayerInfoID { get; set; }
    public byte[] CharacterImage { get; set; } = Array.Empty<byte>();
}