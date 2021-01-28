using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TicketSystemWeb.Library.Api;
using TicketSystemWeb.Models;

namespace TicketSystemWeb.Controllers
{
    public class FileHandlerController : Controller
    {
        private APIHelper _apiHelper;
        private FileModel fileModel;

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> AddFile(HttpPostedFileBase UploadedFile)
        {
            if (UploadedFile.ContentLength > 0)
            {
                ReadyHelper();
                ProcessFile(UploadedFile);
                using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("api/FileHandler/AddFileInfoToDB", fileModel))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsAsync<FileModel>();
                        _apiHelper.ApiClient.Dispose();
                        return View(result);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            return View();
        }

        private FileModel ProcessFile(HttpPostedFileBase uploadedFile)
        {
            fileModel = new FileModel();
            fileModel.Name = Path.GetFileName(uploadedFile.FileName);
            fileModel.Path = Path.Combine(Server.MapPath("~/UploadedFiles"), fileModel.Name);
            fileModel.Extension = Path.GetExtension(uploadedFile.FileName);
            fileModel.Type = uploadedFile.ContentType;
            uploadedFile.SaveAs(fileModel.Path);
            return fileModel;
        }

        private void ReadyHelper()
        {
            _apiHelper = new APIHelper();
            //_apiHelper.AddRequestHeaders(Session["accessToken"].ToString());
        }

        private byte[] UploadToBytes(Stream inputStream)
        {
            MemoryStream target = new MemoryStream();
            inputStream.CopyTo(target);
            return target.ToArray();
        }

        private byte[] UrlToFile(string url)
        {
            MemoryStream target = new MemoryStream();
            return target.ToArray();
        }
    }
}
