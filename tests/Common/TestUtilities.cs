﻿using Autodesk.Revit.DB;
using RTF.Applications;

namespace SCaddins.Tests.Common
{
    public static class TestUtilities
    {
       public static  bool OpenView(View view)
        {
            var uapp = RevitTestExecutive.CommandData.Application;
            if (view != null)
            {
                uapp.ActiveUIDocument.ActiveView = view;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
