using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceOrgWebAPI.Models;

public class ImageModel
{
    public Guid Id { get; set; }
    [NotMapped]
    public IFormFile File { get; set; }

    public string FileName { get; set; }
    public string? FileDescription { get; set; }
    public string FileExtentnion { get; set; }
    public long FileSizeInbytes { get; set; }
    public string FilePath { get; set; }
}