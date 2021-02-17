using System;
using System.Collections.Generic;
using Google.Cloud.Vision.V1;
using Moq;
using NUnit.Framework;
using Vision.API.Integration.Pro.Services.Vision.API.Detection;

namespace Vision.API.Integration.Test
{
    [TestFixture]
    public class VisionAPIDetectTest
    {
        [Test]
        public void EntityAnnotation_GetTextDetectionResponse_NotNull()
        {
            var moqDetectionAccess = new Mock<IDetectionAccess>();
            moqDetectionAccess.Setup(x => x.GetTextDetectionResponse(new Image())).Returns(new List<EntityAnnotation>());
            Assert.IsNotNull(moqDetectionAccess.Object.GetTextDetectionResponse(new Image()));
        }
        
        [Test]
        public void EntityAnnotation_GetTextDetectionResponse_ThrowsArgumentNullException()
        {
            var moqDetectionAccess = new Mock<IDetectionAccess>();
            moqDetectionAccess.Setup(x => x.GetTextDetectionResponse(null)).Throws<ArgumentNullException>();
            Assert.Throws<ArgumentNullException>(() => moqDetectionAccess.Object.GetTextDetectionResponse(null));
        }
        
        [Test]
        public void EntityAnnotation_GetLabelsAnnotationsResponse_NotNull()
        {
            var moqDetectionAccess = new Mock<IDetectionAccess>();
            moqDetectionAccess.Setup(x => x.GetLabelsAnnotationsResponse(new Image())).Returns(new List<EntityAnnotation>());
            Assert.IsNotNull(moqDetectionAccess.Object.GetLabelsAnnotationsResponse(new Image()));
        }
        
        [Test]
        public void EntityAnnotation_GetLabelsAnnotationsResponse_ThrowsArgumentNullException()
        {
            var moqDetectionAccess = new Mock<IDetectionAccess>();
            moqDetectionAccess.Setup(x => x.GetLabelsAnnotationsResponse(null)).Throws<ArgumentNullException>();
            Assert.Throws<ArgumentNullException>(() => moqDetectionAccess.Object.GetLabelsAnnotationsResponse(null));
        }
        
        [Test]
        public void EntityAnnotation_GetLocalizedObjectAnnotationsResponse_NotNull()
        {
            var moqDetectionAccess = new Mock<IDetectionAccess>();
            moqDetectionAccess.Setup(x => x.GetLocalizedObjectAnnotationsResponse(new Image())).Returns(new List<LocalizedObjectAnnotation>());
            Assert.IsNotNull(moqDetectionAccess.Object.GetLocalizedObjectAnnotationsResponse(new Image()));
        }
        
        [Test]
        public void EntityAnnotation_GetLocalizedObjectAnnotationsResponse_ThrowsArgumentNullException()
        {
            var moqDetectionAccess = new Mock<IDetectionAccess>();
            moqDetectionAccess.Setup(x => x.GetLocalizedObjectAnnotationsResponse(null)).Throws<ArgumentNullException>();
            Assert.Throws<ArgumentNullException>(() => moqDetectionAccess.Object.GetLocalizedObjectAnnotationsResponse(null));
        }
    }
}