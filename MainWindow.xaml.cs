using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppUtilisationDuViewModel.ViewModel;

namespace WpfAppUtilisationDuViewModel
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClientViewModel clientViewModel = new ClientViewModel();
        
        public MainWindow()
        {
            InitializeComponent();
            // On définit le context du databinding
            this.DataContext = clientViewModel; 
        }
    }
}
