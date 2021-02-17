using System;
using System.Collections.Generic;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.Detection
{
    public class DetectionAccess : IDetectionAccess
    {
        private readonly ImageAnnotatorClient _imageAnnotatorClient;
        
        public DetectionAccess(ImageAnnotatorClient imageAnnotatorClient)
        {
            _imageAnnotatorClient = imageAnnotatorClient ?? throw new ArgumentNullException();
        }
        
        public IReadOnlyList<EntityAnnotation> GetTextDetectionResponse(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
                throw new ArgumentNullException();
            var sourceImage = Image.FromFile(filePath);
            var textDetectionResponse = _imageAnnotatorClient.DetectText(sourceImage);
            return textDetectionResponse;
        }

        public IReadOnlyList<EntityAnnotation> GetLabelsAnnotationsResponse(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
                throw new ArgumentNullException();
            var sourceImage = Image.FromFile(filePath);
            var labelDetectionResponse = _imageAnnotatorClient.DetectLabels(sourceImage);
            return labelDetectionResponse;        
        }

        public IReadOnlyList<LocalizedObjectAnnotation> GetLocalizedObjectAnnotationsResponse(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
                throw new ArgumentNullException();
            var sourceImage = Image.FromFile(filePath);
            var localizedObjectDetectionResponse = _imageAnnotatorClient.DetectLocalizedObjects(sourceImage);
            return localizedObjectDetectionResponse;
        }
    }
}