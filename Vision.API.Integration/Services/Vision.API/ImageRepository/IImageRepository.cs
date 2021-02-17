using System.Drawing;

namespace Vision.API.Integration.Pro.Services.Vision.API.ImageRepository
{
    public interface IImageRepository
    {
        Image FromUrl(string url);
    }
}