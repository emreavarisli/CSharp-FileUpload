using FileUploadTutorial.FileUploadService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FileUploadTutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFileUploadService fileUploadService;

        public string FilePath;

        public IndexModel(ILogger<IndexModel> logger, IFileUploadService fileUploadService)
        {
            _logger = logger;
            this.fileUploadService = fileUploadService;
        }

        public void OnGet()
        {

        }

        public async void OnPost(IFormFile file) 
        {
            if(file != null)
            {
                FilePath = await fileUploadService.UploadFileAsync(file);
            }
              
        }
    }
}
