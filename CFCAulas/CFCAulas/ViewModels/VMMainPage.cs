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

        public VMMainPage()
        {
            Regla = Data.DataSource.Reglas.First();
            //Infraccion = Regla.Infraccion;
            //Penalidad = Regla.Penalidad;
            //Multiplicador = Regla.Multiplicador;
            //MedidaAdministrativa = Regla.MedidaAdministrativa;
            //Observacion = Regla.Observacion;
            GenerarPenalidades();
            GenerarMultiplicador();
        }

        public void GenerarPenalidades()
        {
            try
            {
                var idsPenalidad = GenerarListaIds(3, Data.DataSource.Penalidades.Count, Regla.IdPenalidad);

                Penalidad = string.Empty;
                Penalidad2 = string.Empty;
                Penalidad3 = string.Empty;

                Penalidad = Data.DataSource.Penalidades.Where(x => x.Id == idsPenalidad[0]).First().Nombre;
                Penalidad2 = Data.DataSource.Penalidades.Where(x => x.Id == idsPenalidad[1]).First().Nombre;
                Penalidad3 = Data.DataSource.Penalidades.Where(x => x.Id == idsPenalidad[2]).First().Nombre;
            }
            catch (Exception ex)
            {
                if (App.Current.MainPage != null)
                    CurrentPage.DisplayAlert("Erro", ex.ToString(), "Fechar");
            }
        }

        public void GenerarMultiplicador()
        {
            try
            {
                var idsMultiplicador = GenerarListaIds(4, Data.DataSource.Multiplicadores.Count, Regla.IdMultiplicador);

                Multiplicador = string.Empty;
                Multiplicador2 = string.Empty;
                Multiplicador3 = string.Empty;
                Multiplicador4 = string.Empty;

                Multiplicador = Data.DataSource.Multiplicadores.Where(x => x.Id == idsMultiplicador[0]).First().Nombre;
                Multiplicador2 = Data.DataSource.Multiplicadores.Where(x => x.Id == idsMultiplicador[1]).First().Nombre;
                Multiplicador3 = Data.DataSource.Multiplicadores.Where(x => x.Id == idsMultiplicador[2]).First().Nombre;
                Multiplicador4 = Data.DataSource.Multiplicadores.Where(x => x.Id == idsMultiplicador[3]).First().Nombre;
            }
            catch (Exception ex)
            {
                if (App.Current.MainPage != null)
                    CurrentPage.DisplayAlert("Erro", ex.ToString(), "Fechar");
            }
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

        #region PENALIDAD

        private string _Penalidad { get; set; }
        public string Penalidad
        {
            get { return _Penalidad; }
            set { _Penalidad = value; OnPropertyChanged(); }
        }

        private string _Penalidad2 { get; set; }
        public string Penalidad2
        {
            get { return _Penalidad2; }
            set { _Penalidad2 = value; OnPropertyChanged(); }
        }

        private string _Penalidad3 { get; set; }
        public string Penalidad3
        {
            get { return _Penalidad3; }
            set { _Penalidad3 = value; OnPropertyChanged(); }
        }

        #endregion

        private string _MedidaAdministrativa { get; set; }
        public string MedidaAdministrativa
        {
            get { return _MedidaAdministrativa; }
            set { _MedidaAdministrativa = value; OnPropertyChanged(); }
        }

        #region MULTIPLICADORES

        private string _Multiplicador { get; set; }
        public string Multiplicador
        {
            get { return _Multiplicador; }
            set { _Multiplicador = value; OnPropertyChanged(); }
        }

        private string _Multiplicador2 { get; set; }
        public string Multiplicador2
        {
            get { return _Multiplicador2; }
            set { _Multiplicador2 = value; OnPropertyChanged(); }
        }

        private string _Multiplicador3 { get; set; }
        public string Multiplicador3
        {
            get { return _Multiplicador3; }
            set { _Multiplicador3 = value; OnPropertyChanged(); }
        }

        private string _Multiplicador4 { get; set; }
        public string Multiplicador4
        {
            get { return _Multiplicador4; }
            set { _Multiplicador4 = value; OnPropertyChanged(); }
        }

        #endregion

        private string _Observacion { get; set; }
        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; OnPropertyChanged(); }
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
            GenerarPenalidades();
            GenerarMultiplicador();
        }

        public List<int> GenerarListaIds(int Cantidad, int MaxRange, int Incluir = 0)
        {
                      
            List<int> listNumbers = new List<int>();
            var rand = new Random();
            for (int i = 0; i < Cantidad; i++)
            {
                int index = rand.Next(1, MaxRange);
                listNumbers.Add(index);              
            }

            if (Incluir != 0)
                if (!listNumbers.Where(x => x == Incluir).Any())
                {
                    listNumbers[rand.Next(0, Cantidad-1)] = Incluir;
                }

            return listNumbers;
        }

    }
}
