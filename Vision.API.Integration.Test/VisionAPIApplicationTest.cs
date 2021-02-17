using System;
using NUnit.Framework;
using Vision.API.Integration.Pro.Services.Vision.API.Application;

namespace Vision.API.Integration.Test
{
    [TestFixture]
    public class Tests
    {
        private IApplicationAccess _applicationAccess;
        
        [SetUp]
        public void Setup()
        {
            _applicationAccess = new ApplicationAccess();
        }

        [Test]
        public void Boolean_SetupApplicationConfiguration_ReturnTrue()
        {
            var result = _applicationAccess.SetAppConfig(@"E:\Faridun's Projects\Faridun's\Back-End\Google Cloud Platform\Vision.API.Integration\Vision.API.Integration\ServiceAccountKey.json");
            Assert.That(result, Is.EqualTo(true));
        }
        
        [Test]
        public void Boolean_SetupApplicationConfiguration_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _applicationAccess.SetAppConfig(string.Empty));
        }

        [Test]
        public void ImageAnnotatorClient_CreateApplication_ReturnNotNull()
        {
            var result = _applicationAccess.CreateApp().GetAwaiter().GetResult();
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Method_ShutdownApplication_ThrowsException()
        {
            Assert.Throws<Exception>(() => _applicationAccess.ShutdownApp());
        }
    }
}