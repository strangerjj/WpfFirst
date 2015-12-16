using System;
namespace WpfFirst
{
    class ViewModel
    {
        public DelegateCommand CopyCmd { get; set; }
        public Model model { get; set; }
        public DelegateCommand ClearCmd { get; set; }
        public ViewModel()
        {
            this.model = new Model();
            this.CopyCmd = new DelegateCommand();
            
            this.CopyCmd.ExecuteCommand = new Action<object>(this.model.Check);
            this.CopyCmd.ExecuteCommand += new Action<object>(this.model.Copy);
            this.ClearCmd = new DelegateCommand();
            this.ClearCmd.ExecuteCommand = new Action<object>(this.model.Clear);
        }
    }
}