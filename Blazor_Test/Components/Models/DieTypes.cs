using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Test.Components.Models;

public class DieTypes
{
    [Key]
    public int IntDieTypeID { get; set; }
    public string DieText { get; set; }
    public int MaxDieValue { get; set; }
}