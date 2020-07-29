using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Coin.Application.Helpers
{
    public static class FileUploadHelper
    {
        public static string ImageUploader(IFormFile image, IWebHostEnvironment webHostEnvironment)
        {
            string uniqueFileName = null;
  
            if (image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {  
                    image.CopyTo(fileStream);
                }  
            }  
            return uniqueFileName;
        }
    }
}