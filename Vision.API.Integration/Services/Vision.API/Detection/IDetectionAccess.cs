using System.Collections.Generic;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.Detection
{
    public interface IDetectionAccess
    {
        IReadOnlyList<EntityAnnotation> GetTextDetectionResponse(Image image);
        IReadOnlyList<EntityAnnotation> GetLabelsAnnotationsResponse(Image image);
        IReadOnlyList<LocalizedObjectAnnotation> GetLocalizedObjectAnnotationsResponse(Image image);
    }
}