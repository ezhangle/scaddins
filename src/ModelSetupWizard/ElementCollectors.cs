﻿namespace SCaddins.ModelSetupWizard
{
    using System.Collections.Generic;
    using System.Linq;
    using Autodesk.Revit.DB;

    public static class ElementCollectors
    {
        public static IEnumerable<ProjectInformationParameter> GetProjectInformationParameters(Document doc)
        {
            FilteredElementCollector fec = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_ProjectInformation);
            foreach (Element e in fec) {
                foreach (var param in e.GetOrderedParameters()) {
                    yield return new ProjectInformationParameter(param);
                }
            }
        }

        public static IEnumerable<WorksetParameter> GetWorksetParameters(Document doc)
        {
            var worksets = new FilteredWorksetCollector(doc).ToWorksets().Where(w => w.Kind == WorksetKind.UserWorkset);
            foreach (var workset in worksets) {
                    yield return new WorksetParameter(workset.Name, workset.IsVisibleByDefault, workset.Id.IntegerValue);
            }
        }
    }
}
