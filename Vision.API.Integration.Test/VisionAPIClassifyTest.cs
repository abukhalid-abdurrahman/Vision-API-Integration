using System.Collections.Generic;
using Google.Cloud.Vision.V1;
using Moq;
using NUnit.Framework;
using Vision.API.Integration.Pro.Services.Vision.API.ClassifyEntity;

namespace Vision.API.Integration.Test
{
    [TestFixture]
    public class VisionAPIClassifyTest
    {
        [Test]
        public void StringCollection_ClassifyEntity_ReturnsStringCollection()
        {
            var moqClassifyAccess = new Mock<IClassifyEntityAccess>();
            moqClassifyAccess.Setup(x => x.Classify(new List<EntityAnnotation>()))
                .Returns(new List<string>() { "Buildings", "Home" });
            var result = moqClassifyAccess.Object.Classify(new List<EntityAnnotation>());
            Assert.That(result, Does.Contain("Buildings"));
        }
        
        [Test]
        public void StringCollection_ClassifyObject_ReturnsStringCollection()
        {
            var moqClassifyAccess = new Mock<IClassifyEntityAccess>();
            moqClassifyAccess.Setup(x => x.Classify(new List<LocalizedObjectAnnotation>()))
                .Returns(new List<string>() { "Flower", "Vegetation" });
            var result = moqClassifyAccess.Object.Classify(new List<LocalizedObjectAnnotation>());
            Assert.That(result, Does.Contain("Vegetation"));
        }
    }
}