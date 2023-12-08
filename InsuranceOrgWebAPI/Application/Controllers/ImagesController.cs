using InsuranceOrgWebAPI.Data.DataProviders.Models.DTO;
using InsuranceOrgWebAPI.Data.DataProviders.Repositories.Interfaces;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImagesController(IImageUploadRepository imageUploadRepository): ControllerBase
{
    private const int MaxUploadFileSizeInBytes = 10485760;
        
    [HttpPost]
    [Route("Upload")]
    public async Task<IActionResult> UploadImage([FromForm] ImageVieModel imageDto)
    {
        ValidateFileUpload(imageDto);
        if (ModelState.IsValid)
        {
            var imageModel = new ImageModel()
            {
                File = imageDto.File,
                FileExtentnion = Path.GetExtension(imageDto.File.FileName),
                FileSizeInbytes = imageDto.File.Length,
                FileName = imageDto.FileName,
                FileDescription = imageDto.FileDescription
            };

            await imageUploadRepository.UploadAsync(imageModel);
            return Ok(imageModel);
        }

        return BadRequest(ModelState);
    }

    private void ValidateFileUpload(ImageVieModel fileDto)
    {
        var allowedExtentions = new string[] { ".jpg", ".jpeg", ".png" };

        if (!allowedExtentions.Contains(Path.GetExtension(fileDto.File.FileName)))
        {
            ModelState.AddModelError("file", "Unsupported file extension");
        }

        if (fileDto.File.Length > MaxUploadFileSizeInBytes)
        {
            ModelState.AddModelError("file", "File size more than 10 Mb ");
        }
    }
}