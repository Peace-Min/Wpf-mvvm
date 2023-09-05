using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private Model.Mainmodel model = null;
        public Command btn_cmd { get; set; }
        public MainViewModel() { 
            model = new Model.Mainmodel();
            btn_cmd = new Command(Execute_func, CanExecute_func);
        }
        public Model.Mainmodel Model
        {
            get { return model; }
            set { model = value; OnPropertyChanged("Model");
            }
        }
        private void Execute_func(object obj)
        {
            model.Num2 = Model.Num * 2;
        }
        private bool CanExecute_func(object obj)
        {
            return true;
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
