namespace FileUploadTutorial.FileUploadService
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}
