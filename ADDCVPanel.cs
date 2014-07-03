using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Reflection;
using System.Windows.Media.Imaging;


namespace AddCVPanel
{



    public class AddCVPanel : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("NewRibbonPanel");

            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData buttonData = new PushButtonData("cmdViewCreator", "Project Startup", thisAssemblyPath, "ViewCreator");
            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;

            Uri uriImage = new Uri(@"C:\Users\jay.dunn\Documents\Visual Studio 2013\Projects\ViewCreator - Copy\TLC.jpg");
            BitmapImage largeImage = new BitmapImage(uriImage);
            pushButton.LargeImage = largeImage;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}


               