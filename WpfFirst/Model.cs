using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfFirst
{
    class Model : NotificationObject
    {
        private string _wpf = "WPF";

        public string WPF
        {
            get { return _wpf; }
            set
            {
                _wpf = value;
                this.RaisePropertyChanged("WPF");
            }
        }

        public void Copy(object obj)
        {
            this.WPF += " WPF";
            Console.Write("{0}*{1}", (1 == 2 ? 3 : 4) / 2, "10");
        }
        public void Clear(object obj)
        {
            this.WPF = null;
        }

    }
}