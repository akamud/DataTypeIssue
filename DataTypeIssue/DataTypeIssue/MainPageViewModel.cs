using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataTypeIssue
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _images;

        public ObservableCollection<string> Images
        {
            set
            {
                if (_images != value)
                {
                    _images = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Images)));
                }
            }
            get => _images;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            Images = new ObservableCollection<string> {"image1.png", "image2.png"};
        }
    }
}