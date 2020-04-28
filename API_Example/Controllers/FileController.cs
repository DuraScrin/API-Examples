using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class FileController : Controller
    {
        [Route("upload/file")]
        [HttpPost]
        public async Task<string> Upload([FromForm]IFormFile testfile)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                await testfile.CopyToAsync(stream);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            //cenvert stream data to anything you need (ex:byteArray to save in DB)
            return stream.Length.ToString();
        }

        [Route("download/file")]
        public async Task<FileResult> Download(string id)
        {
            byte[] byteArray = null;
            switch (id)
            {
                case "t1":
                    byteArray = System.Text.Encoding.UTF8.GetBytes("Text to test - t1");
                    break;
                case "t2":
                    byteArray = System.Text.Encoding.UTF8.GetBytes("Text to test - t2");
                    break;
                default:
                    break;
            }
            return File(byteArray, "application/text", "testFile.text");
        }
    }
}
