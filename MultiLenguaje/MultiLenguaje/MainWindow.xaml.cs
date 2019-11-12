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
using System.Resources;

namespace MultiLenguaje
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string strLenguage = "";
        Boolean boolInt = true;
        public MainWindow()
        {
            InitializeComponent();
            boolInt = false;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Set_Language();
        }
        private void ddlLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Set_Language();
        }
        private void Set_Language()
        {
            strLenguage = "Multilenguaje.Lenguajes" + ((ComboBoxItem)ddLanguage.SelectedItem).Name.ToString();
            ResourceManager locRM = new ResourceManager(strLenguage, typeof(MainWindow).Assembly);
            lblFirstName.Text = LocRM.GetString("strFirsName");
        }
    }
}
