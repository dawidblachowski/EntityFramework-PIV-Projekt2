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
    /// Logika interakcji dla klasy ClientEditorView.xaml
    /// </summary>
    public partial class ClientEditorView : Window
    {
        KlientViewModel _model { set; get; }
        public ClientEditorView()
        {
            InitializeComponent();
            _model = new KlientViewModel();
            DataContext = _model;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _model.UpdateDatabase();
        }

        private void NewItemBtnClick(object sender, RoutedEventArgs e)
        {
            _model.AddNewClient();
        }

        private void PickAddressBtnClick(object sender, RoutedEventArgs e)
        {
            var picker = new AddressEditorView();
            picker.ShowDialog();
            _model.CurrentAdres = picker.SelectedItem;
        }

        private void DeleteClientBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                _model.RemoveClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd usuwania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveEntity(object sender, RoutedEventArgs e)
        {
            _model.SaveCurrentEntity();
        }
    }
}
