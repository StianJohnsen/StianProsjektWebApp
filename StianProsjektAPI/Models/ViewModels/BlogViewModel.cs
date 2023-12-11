using StianProsjektAPI.Models.Entities;

namespace StianProsjektAPI.Models.ViewModels;

public class BlogViewModel
{
    public ApplicationUser? Owner { get; set; }
    public int BlogId { get; set; }
    public string BlogName { get; set; }
    public string BlogDescription { get; set; }
    public bool isOpenForExternalWriters { get; set; }
}