using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.Data.DataProviders.Repositories.Interfaces;

public interface IImageUploadRepository
{
    public Task<ImageModel> UploadAsync(ImageModel model);
}