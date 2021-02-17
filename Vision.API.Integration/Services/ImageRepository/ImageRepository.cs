using System;
using System.Drawing;
using System.Net;

namespace Vision.API.Integration.Pro.Services.ImageRepository
{
    public class ImageRepository : IImageRepository
    {
        public Image FromUrl(string url)
        {
            if(string.IsNullOrEmpty(url))
                throw new ArgumentNullException();
            var request = WebRequest.Create(url);
            using var response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            return responseStream == null ? null : Image.FromStream(responseStream);
        }
    }
}