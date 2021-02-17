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
        
        public IReadOnlyList<EntityAnnotation> GetTextDetectionResponse(Image image)
        {
            if(image == null)
                throw new ArgumentNullException();
            var textDetectionResponse = _imageAnnotatorClient.DetectText(image);
            return textDetectionResponse;
        }

        public IReadOnlyList<EntityAnnotation> GetLabelsAnnotationsResponse(Image image)
        {
            if(image == null)
                throw new ArgumentNullException();
            var labelDetectionResponse = _imageAnnotatorClient.DetectLabels(image);
            return labelDetectionResponse;        
        }

        public IReadOnlyList<LocalizedObjectAnnotation> GetLocalizedObjectAnnotationsResponse(Image image)
        {
            if(image == null)
                throw new ArgumentNullException();
            var localizedObjectDetectionResponse = _imageAnnotatorClient.DetectLocalizedObjects(image);
            return localizedObjectDetectionResponse;
        }
    }
}