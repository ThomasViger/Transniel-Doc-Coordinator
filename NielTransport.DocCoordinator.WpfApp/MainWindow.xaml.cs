using System.Windows;
using System.Windows.Controls;
using NielTransport.DocCoordinator.Core.UseCases;

namespace NielTransport.DocCoordinator.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        public MainWindow(MergePdfUseCase mergePdfUseCase)
        {
            InitializeComponent();

            Label.Content = "Test Pour voir ";
            mergePdfUseCase.Execute();
        }
    }
}