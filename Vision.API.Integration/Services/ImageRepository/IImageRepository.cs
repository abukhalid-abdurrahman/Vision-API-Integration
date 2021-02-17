using System.Drawing;

namespace Vision.API.Integration.Pro.Services.ImageRepository
{
    public interface IImageRepository
    {
        Image FromUrl(string url);
    }
}