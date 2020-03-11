using System;
using System.Diagnostics;
using NielTransport.DocCoordinator.Core.ExternalServices;
using Tesseract;

namespace NielTransport.DocCoordinator.Infrastructure
{
    public class OcrService : IOcrService
    {
        public string Translate()
        { 
            string testImagePath = "C:/Users/conta/Desktop/testocr.jpg";
            
            try
            {
                TesseractEngine engine = new TesseractEngine(@"./tessdata", "fra", EngineMode.Default);
                Pix img = Pix.LoadFromFile(testImagePath);
                Page page = engine.Process(img);
                string text = page.GetText();
                
                return text;
            }
            catch (Exception error)
            {
                Trace.TraceError(error.ToString());
                Console.WriteLine("Unexpected Error: " + error.Message);
                Console.WriteLine("Details: ");
                Console.WriteLine(error.ToString());

                return error.Message;
            }

        }
    }
}