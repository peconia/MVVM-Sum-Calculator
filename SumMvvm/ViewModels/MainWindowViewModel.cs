using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumMvvm.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {
        private int _x;
        private int _y;
        private int _z;

        public int x
        {
            get { return _x; }
            set
            {
                SetProperty(ref _x, value);
            }
        }

        public int y
        {
            get { return _y; }
            set
            {
                SetProperty(ref _y, value);
            }
        }
        
        public int z 
        {
            get { return _z; }
            set
            {
                SetProperty(ref _z, value);
            }
        }

        public ICommand SumCommand { get; private set; }

        public MainWindowViewModel()
        {
            SumCommand = new DelegateCommand(onSum);
        }

        private void onSum()
        {
            z = x + y;
        }

    }
}
