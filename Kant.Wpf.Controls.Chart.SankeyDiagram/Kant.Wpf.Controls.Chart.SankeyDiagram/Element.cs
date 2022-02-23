using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kant.Wpf.Controls.Chart
{
    public class Element : INotifyPropertyChanged
    {

        protected void OnPropertyChanged(string name) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); }

        private bool _IsHighlight;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsHighlight
        {
            get { return _IsHighlight; }
            set { _IsHighlight = value; OnPropertyChanged("IsHighlight"); }
        }
        public Brush OriginalBrush { get; set; }
    }
}
