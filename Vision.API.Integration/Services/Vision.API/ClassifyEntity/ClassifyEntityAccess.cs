using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using Google.Cloud.Vision.V1;

namespace Vision.API.Integration.Pro.Services.Vision.API.ClassifyEntity
{
    public class ClassifyEntityAccess : IClassifyEntityAccess
    {
        public List<string> Classify(IReadOnlyList<EntityAnnotation> annotations)
        {
            if (annotations == null)
                throw new ArgumentNullException();
            return annotations
                .OrderBy(x => x.Score)
                .TakeWhile(x => (x.Score * 100) > 85)
                .Select(x => x.Description)
                .ToList();
        }

        public List<string> Classify(IReadOnlyList<LocalizedObjectAnnotation> annotations)
        {
            if (annotations == null)
                throw new ArgumentNullException();
            return annotations
                .OrderBy(x => x.Score)
                .TakeWhile(x => (x.Score * 100) >= 85)
                .Select(x => x.Name)
                .ToList();
        }
    }
}