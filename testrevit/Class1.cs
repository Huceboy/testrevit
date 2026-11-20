using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
namespace testRevit
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand

    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            IList<Reference> referenceCollection = uidoc.Selection.PickObjects(Autodesk.Revit.UI.Selection.ObjectType.Edge);
            MessageBox.Show("You have selected total  " + referenceCollection.Count.ToString() + " Edges.");


            return Result.Succeeded;
        }
    }
}