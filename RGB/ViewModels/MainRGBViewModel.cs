using System.ComponentModel;
using Xamarin.Forms;

namespace RGB.ViewModel
{
    public class MainRGBViewModel: INotifyPropertyChanged
    {
        private double _R, _G, _B;
        public Color _color;

        public event PropertyChangedEventHandler PropertyChanged;

        public double R
        {
            get
            {
                return _R;
            }

            set
            {
                _R = value;
                OnPropertyChanged();
                SetColor();
            }
        }

        public double G
        {
            get
            {
                return _G;
            }
            set
            {
                _G = value;
                OnPropertyChanged();
                SetColor();
            }
        }

        public double B
        {
            get
            {
                return _B;
            }
            set
            {
                _B = value;
                OnPropertyChanged();
                SetColor();
            }
        }

        public Color VColor
        {
            get {
                return _color;
            }
            set
            {
                _color = value;
                OnPropertyChanged();

            }

        }

        private void SetColor()
        {
            VColor = Color.FromRgb(R, G, B);

        }

        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
