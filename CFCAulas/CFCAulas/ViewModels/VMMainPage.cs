using CFCAulas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CFCAulas.ViewModels
{
    class VMMainPage : VMBase
    {

        VMMainPage()
        {
            Regla = Data.DataSource.Reglas.First();
            Infraccion = Regla.Infraccion;
        }

        private Regla _regla { get; set; }
        public Regla Regla
        {
            get { return _regla; }
            set { _regla = value; OnPropertyChanged(); }
        }

        private string _Infraccion { get; set; }
        public string Infraccion
        {
            get { return _Infraccion; }
            set { _Infraccion = value; OnPropertyChanged(); }
        } 
        
        private string _Penalidad { get; set; }
        public string Penalidad
        {
            get { return _Penalidad; }
            set { _Penalidad = value; OnPropertyChanged(); }
        }


        private ICommand _finalizarCommand;
        public ICommand FinalizarCommand
        {
            get
            {
                if (_finalizarCommand == null)
                {
                    _finalizarCommand = new RelayCommand(FinalizarCommandExecute, CanSubmitExecute);
                }
                return _finalizarCommand;
            }
        }

        public async void FinalizarCommandExecute(object parameter)
        {
            ;
        }
    }
}
