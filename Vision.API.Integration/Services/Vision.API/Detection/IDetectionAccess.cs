using System.Collections.Generic;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.Detection
{
    public interface IDetectionAccess
    {
        IReadOnlyList<EntityAnnotation> GetTextDetectionResponse(string filePath);
        IReadOnlyList<EntityAnnotation> GetLabelsAnnotationsResponse(string filePath);
        IReadOnlyList<LocalizedObjectAnnotation> GetLocalizedObjectAnnotationsResponse(string filePath);
    }
}