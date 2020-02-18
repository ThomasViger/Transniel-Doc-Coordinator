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
        public MainWindow()
        {
            InitializeComponent();

            
            
            MergePdfUseCase mergePdf = new MergePdfUseCase();
            mergePdf.Execute();
        }
    }
}