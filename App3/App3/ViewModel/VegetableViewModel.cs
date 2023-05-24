using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using App3.Data;

namespace App3.ViewModels
{
    public class VegetableViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Vegetable> _vegetables;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Vegetable> Vegetables
        {
            get { return _vegetables; }
            set
            {
                _vegetables = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Vegetables)));
            }
        }

        public VegetableViewModel()
        {
            var db = new Database(App.DatabasePath);
            db.InitializeDatabase();
            Vegetables = new ObservableCollection<Vegetable>(db.GetVegetables());
        }

    }
}
