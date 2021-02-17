using System;
using NUnit.Framework;
using Vision.API.Integration.Pro.Services.ImageRepository;

namespace Vision.API.Integration.Test
{
    [TestFixture]
    public class VisionAPIImageRepositoryTest
    {
        private IImageRepository _imageRepository;
        
        [SetUp]
        public void Setup()
        {
            _imageRepository = new ImageRepository();        
        }
        
        [Test]
        [TestCase("https://cdn.somon.tj/media/cache3/51/b6/51b62be53abd05063a9cdd0842042357.jpg")]
        public void Image_FromUrl_NotNull(string testUrl)
        {
            var result = _imageRepository.FromUrl(testUrl);
            Assert.IsNotNull(result);
        }
        
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Image_FromUrl_ThrowArgumentNullException(string testUrl)
        {
            Assert.Throws<ArgumentNullException>(() => _imageRepository.FromUrl(testUrl));
        }
    }
}