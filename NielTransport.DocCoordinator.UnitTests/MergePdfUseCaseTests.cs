using Moq;
using NielTransport.DocCoordinator.Core.ExternalServices;
using NielTransport.DocCoordinator.Core.UseCases;
using NUnit.Framework;

namespace NielTransport.DocCoordinator.UnitTests
{
    [TestFixture]
    public class MergePdfUseCaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MergePdf_WhenCalled_PdfIsMerged()
        {
            Mock<IPdfService> pdfService = new Mock<IPdfService>();
            MergePdfUseCase mergePdfUseCase = new MergePdfUseCase(pdfService.Object);

            mergePdfUseCase.Execute();

            pdfService.Verify(p => p.Merge());
        }

        [Test]
        public void MergePdf()
        {
            
        }
    }
}