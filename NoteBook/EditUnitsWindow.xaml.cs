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
using System.Windows.Shapes;

namespace NoteBook
{
    /// <summary>
    /// Logique d'interaction pour EditUnitsWindow.xaml
    /// </summary>
    public partial class EditUnitsWindow : Window
    {
        public EditUnitsWindow()
        {
            InitializeComponent();
        }

        private void EditUE(object sender, RoutedEventArgs e)
        {
            EditEducationalElementWindow editEducationalElementWindow = new EditEducationalElementWindow();
            editEducationalElementWindow.Show();
        }
    }
}
