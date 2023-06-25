using EntityFramework_PIV_Projekt2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModel
{
    public class KlientViewModel : INotifyPropertyChanged
    {
        private SystemBiletContext _context = new SystemBiletContext();
        private ObservableCollection<KlientModel> _klienci { get; set; }
        public ObservableCollection<KlientModel> Klienci
        {
            get
            {
                return _klienci;
            }
            set
            {
                _klienci = value;
                OnPropertyChanged();
            }
        }
        private KlientModel _currentClient { set; get; }
        public KlientModel CurrentClient
        {
            set
            {
                _currentClient = value;
                CurrentImie = value.Imie;
                CurrentNazwisko = value.Nazwisko;
                CurrentPlec = value.Plec;
                CurrentDataUrodzenia = value.DataUrodzenia;
                CurrentHaslo = value.Haslo;
                CurrentMail = value.Mail;
                CurrentTelefon = value.Telefon;
                CurrentAdres = value.Adres;
                OnPropertyChanged();
            }
            get
            {
                return _currentClient;
            }
        }

        private string _currentImie { set; get; }
        private string _currentNazwisko { set; get; }
        private string _currentPlec { set; get; }
        private DateTime _currentDataUrodzenia { set; get; }
        private string _currentHaslo { set; get; }
        private string _currentMail { set; get; }
        private string _currentTelefon { set; get; }
        private AdresModel _currentAdres { set; get; }

        public string CurrentImie
        {
            set
            {
                _currentImie = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentImie;
            }
        }

        public string CurrentNazwisko
        {
            set
            {
                _currentNazwisko = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentNazwisko;
            }
        }

        public string CurrentPlec
        {
            set
            {
                _currentPlec = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentPlec;
            }
        }

        public DateTime CurrentDataUrodzenia
        {
            set
            {
                _currentDataUrodzenia = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentDataUrodzenia;
            }
        }

        public string CurrentHaslo
        {
            set
            {
                _currentHaslo = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentHaslo;
            }
        }

        public string CurrentMail
        {
            set
            {
                _currentMail = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentMail;
            }
        }

        public string CurrentTelefon
        {
            set
            {
                _currentTelefon = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentTelefon;
            }
        }

        public AdresModel CurrentAdres
        {
            set
            {
                _currentAdres = value;
                OnPropertyChanged();
            }
            get
            {
                return _currentAdres;
            }
        }

        public KlientViewModel()
        {
            CurrentClient = new KlientModel();
            try
            {
                Klienci = new ObservableCollection<KlientModel>(_context.Klienci.Include("Adres"));
                if (Klienci.Count != 0)
                    CurrentClient = Klienci.First();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd ładowania danych z bazy", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void SaveCurrentEntity()
        {
            CurrentClient.Imie = CurrentImie;
            CurrentClient.Nazwisko = CurrentNazwisko;
            CurrentClient.Plec = CurrentPlec;
            CurrentClient.DataUrodzenia = CurrentDataUrodzenia;
            CurrentClient.Haslo = CurrentHaslo;
            CurrentClient.Mail = CurrentMail;
            CurrentClient.Telefon = CurrentTelefon;
            CurrentClient.Adres = CurrentAdres;
            UpdateDatabase();
        }

        public void UpdateDatabase()
        {
            try
            {
                _context.SaveChanges();
                Klienci = new ObservableCollection<KlientModel>(_context.Klienci.Include("Adres"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd zapisu", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddNewClient()
        {
            CurrentClient = new KlientModel() {DataUrodzenia = DateTime.Today};
            Klienci.Add(CurrentClient);
            _context.Klienci.Add(CurrentClient);
        }

        public void RemoveClient()
        {
            _context.Klienci.Remove(CurrentClient);
            _context.SaveChanges();
            Klienci.Remove(CurrentClient);

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
