using NielTransport.DocCoordinator.Core.ExternalServices;

namespace NielTransport.DocCoordinator.Core.UseCases
{
    public class TranslateDocumentUseCase
    {
        private readonly IOcrService ocrService;

        public TranslateDocumentUseCase(IOcrService ocrService)
        {
            this.ocrService = ocrService;
        }

        public string Execute()
        {
            return ocrService.Translate();
        }
    }
}