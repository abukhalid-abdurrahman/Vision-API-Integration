using System.Collections.Generic;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.ClassifyEntity
{
    public interface IClassifyEntityAccess
    {
        List<string> Classify(IReadOnlyList<EntityAnnotation> annotations);
        List<string> Classify(IReadOnlyList<LocalizedObjectAnnotation> annotations);
    }
}