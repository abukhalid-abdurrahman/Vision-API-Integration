using System.Threading.Tasks;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.Application
{
    public interface IApplicationAccess
    {
        bool SetAppConfig(string keyPath);
        Task<ImageAnnotatorClient> CreateApp();
        Task ShutdownApp();
    }
}