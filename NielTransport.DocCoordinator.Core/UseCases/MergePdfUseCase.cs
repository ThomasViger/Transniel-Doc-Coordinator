using System;
using NielTransport.DocCoordinator.Core.ExternalServices;

namespace NielTransport.DocCoordinator.Core.UseCases
{
    public class MergePdfUseCase
    {
        private readonly IPdfService pdfService;

        public MergePdfUseCase(IPdfService pdfService)
        {
            this.pdfService = pdfService;
        }

        public void Execute()
        {
           this.pdfService.Merge();
        }
    }
}