using InsuranceOrgWebAPI.Data.DataProviders.Repositories.Interfaces;
using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.Data.DataProviders;

public class LocalSystemImageRepository(IWebHostEnvironment webHostEnvironment,
    IHttpContextAccessor httpContextAccessor) : IImageUploadRepository
{
    private const string StoreFolderName = "ImagesStore";
    
    public async Task<ImageModel> UploadAsync(ImageModel model)
    {
        var localFielPath = Path.Combine(webHostEnvironment.ContentRootPath,
            StoreFolderName,
            model.FileName + model.FileExtentnion);

        using var stream = new FileStream(localFielPath, FileMode.Create);
        await model.File.CopyToAsync(stream);
        //path example https://localhost:7145/ImagesStore/SomeImage.jpg
        var urlFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}" +
                          $"://{httpContextAccessor.HttpContext.Request.Host}" +
                          $"{httpContextAccessor.HttpContext.Request.PathBase}" +
                          $"/{StoreFolderName}/{model.FileName}" +
                          $"{model.FileExtentnion}";
        model.FilePath = urlFilePath;
        //Save file name and path to Database
        return model;
    }
}