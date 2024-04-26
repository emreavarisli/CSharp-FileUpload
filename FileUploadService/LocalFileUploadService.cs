
namespace FileUploadTutorial.FileUploadService
{
    public class LocalFileUploadService : IFileUploadService
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        public LocalFileUploadService(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\images", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return filePath;
        }
    }
}
