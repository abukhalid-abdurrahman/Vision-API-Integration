using System;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.Application
{
    public class ApplicationAccess : IApplicationAccess, IDisposable
    {
        public bool SetAppConfig(string keyPath)
        {
            if(string.IsNullOrEmpty(keyPath))
                throw new ArgumentNullException();
            
            try
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keyPath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ImageAnnotatorClient> CreateApp()
        {
            try
            {
                return await ImageAnnotatorClient.CreateAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task ShutdownApp()
        {
            await ImageAnnotatorClient.ShutdownDefaultChannelsAsync();
        }

        public void Dispose()
        {
            ShutdownApp().GetAwaiter().GetResult();
        }
    }
}