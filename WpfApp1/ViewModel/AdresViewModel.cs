using EntityFramework_PIV_Projekt2;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp1.ViewModel
{
    public class AdresViewModel : INotifyPropertyChanged
    {
        private SystemBiletContext _context = new SystemBiletContext();
        private ObservableCollection<AdresModel> _adresy { get; set; }

        public ObservableCollection<AdresModel> Adresy
        {
            get
            {
                return _adresy;
            }
            set
            {
                _adresy = value;
                OnPropertyChanged();
            }
        }

        private AdresModel _currentAddress { set; get; }
        public AdresModel CurrentAddress {
            set{
                _currentAddress = value;
                CurrentKodPocztowy = value.KodPocztowy;
                CurrentKraj = value.Kraj;
                CurrentMiasto = value.Miasto;
                CurrentUlica = value.Ulica;
                CurrentNumerBudynku = value.NumerBudynku;
                OnPropertyChanged();
            }
            get{
                return _currentAddress;
            }
        }


        private string _currentKodPocztowy { set; get; }
        private string _currentKraj { set; get; }
        private string _currentMiasto { set; get; }
        private string _currentUlica { set; get; }
        private string _currentNumerBudynku { set; get; }

        public string CurrentKodPocztowy
        {
            set
            {
                _currentKodPocztowy = value;
                OnPropertyChanged();
                }
            get
            {
                return _currentKodPocztowy;
            }
        }

        public string CurrentKraj
        {
            set
            {
                _currentKraj = value;
                OnPropertyChanged();
                }
            get
            {
                return _currentKraj;
            }
        }

        public string CurrentMiasto
        {
            set
            {
                _currentMiasto = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentMiasto;
            }
        }

        public string CurrentUlica
        {
            set
            {
                _currentUlica = value;
                OnPropertyChanged();
                }
            get
            {
                return _currentUlica;
            }
        }

        public string CurrentNumerBudynku
        {
            set
            {
                _currentNumerBudynku = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentNumerBudynku;
            }
        }

        public void SaveCurrentEntity()
        {

            _currentAddress.KodPocztowy = CurrentKodPocztowy;
            _currentAddress.Kraj = CurrentKraj;
            _currentAddress.Miasto = CurrentMiasto;
            _currentAddress.Ulica = CurrentUlica;
            _currentAddress.NumerBudynku = CurrentNumerBudynku;
            UpdateDatabase();
        }


        public AdresViewModel()
        {
            CurrentAddress = new AdresModel();
            try
            {
                //Adresy = context.Adresy.ToList();
                Adresy = new ObservableCollection<AdresModel>(_context.Adresy);
                if (Adresy.Count!=0)
                {
                    CurrentAddress = Adresy.First();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd ładowania danych z bazy", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }

        public void UpdateDatabase()
        {
            try
            {
                _context.SaveChanges();
                Adresy = new ObservableCollection<AdresModel>(_context.Adresy);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd zapisu", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddNewAddress()
        {
            CurrentAddress = new AdresModel();
            _context.Add(CurrentAddress);
            Adresy.Add(CurrentAddress);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

