using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Helpers
{
    public class ImageHelper
    {
        private readonly IWebHostEnvironment _webhost;
        public ImageHelper(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }
        public string SaveFile(IFormFile file)
        {
            var saveimg = Path.Combine(_webhost.WebRootPath, "images", file.FileName);
            string imgText = Path.GetExtension(file.FileName);
            using (var img = new FileStream(saveimg, FileMode.Create))
            {
                file.CopyTo(img);
            }
            return file.FileName;
        }
    }
}
