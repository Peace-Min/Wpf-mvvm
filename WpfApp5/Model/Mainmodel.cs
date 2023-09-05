using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp5.Model
{
    internal class Mainmodel : INotifyPropertyChanged
    {
        private int num = 1;
        private int num2 = 1;
        public int Num
        {
            set
            {
                num = value;
                OnPropertyChanged("Num");
            }
            get
            {
                return num;
            }
        }
        public int Num2
        {
            get { return num2; }
            set
            {
                num2 = value;
                OnPropertyChanged("Num2");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
