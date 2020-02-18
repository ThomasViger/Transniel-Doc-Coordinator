using System;
using NielTransport.DocCoordinator.Core.ExternalServices;

namespace NielTransport.DocCoordinator.Core.UseCases
{
    public class MergePdfUseCase
    {
        private IPdfService pdfService;
        
        public MergePdfUseCase(IPdfService pdfService)
        {
            this.pdfService = pdfService;
        }

        public void Execute()
        {
            return;
        }
    }
}