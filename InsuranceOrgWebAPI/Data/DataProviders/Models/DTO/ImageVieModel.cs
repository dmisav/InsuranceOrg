using System.ComponentModel.DataAnnotations;

namespace InsuranceOrgWebAPI.Data.DataProviders.Models.DTO;

public class ImageVieModel
{
    [Required]
    public IFormFile File { get; set; }
    [Required]
    public string FileName { get; set; }

    public string FileDescription { get; set; }
}