using EntityFramework_PIV_Projekt2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Logika interakcji dla klasy EditView.xaml
    /// </summary>
    public partial class AddressEditorView : Window
    {
        AdresViewModel _model { set; get; }
        public AdresModel SelectedItem { get {
                return _model.CurrentAddress;
            } }
        public AddressEditorView()
        {
            _model = new AdresViewModel();
            InitializeComponent();
            DataContext = _model;
        }

        private void NewItemBtnClick(object sender, RoutedEventArgs e)
        {
            _model.AddNewAddress();
        }

        private void SaveEntity(object sender, RoutedEventArgs e)
        {
            _model.SaveCurrentEntity();
        }
    }
}
