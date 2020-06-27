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
            MultipSelectedIndex = -1;

            Regla = Data.DataSource.Reglas.First();

            GenerarPenalidades();
            GenerarMultiplicador();
            GenerarMedidaAdministrativa();
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

        public void GenerarMedidaAdministrativa()
        {
            try
            {
                var idsMedidaAdministrativa = GenerarListaIds(3, Data.DataSource.MedidaAdministrativas.Count, Regla.IdMedidaAdministrativa);

                MedidaAdministrativa = string.Empty;
                MedidaAdministrativa2 = string.Empty;
                MedidaAdministrativa3 = string.Empty;

                MedidaAdministrativa = Data.DataSource.MedidaAdministrativas.Where(x => x.Id == idsMedidaAdministrativa[0]).First().Nombre;
                MedidaAdministrativa2 = Data.DataSource.MedidaAdministrativas.Where(x => x.Id == idsMedidaAdministrativa[1]).First().Nombre;
                MedidaAdministrativa3 = Data.DataSource.MedidaAdministrativas.Where(x => x.Id == idsMedidaAdministrativa[2]).First().Nombre;
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

        #region MEDIDA ADMINISTRATIVA

        private string _MedidaAdministrativa { get; set; }
        public string MedidaAdministrativa
        {
            get { return _MedidaAdministrativa; }
            set { _MedidaAdministrativa = value; OnPropertyChanged(); }
        }

        private string _MedidaAdministrativa2 { get; set; }
        public string MedidaAdministrativa2
        {
            get { return _MedidaAdministrativa2; }
            set { _MedidaAdministrativa2 = value; OnPropertyChanged(); }
        }

        private string _MedidaAdministrativa3 { get; set; }
        public string MedidaAdministrativa3
        {
            get { return _MedidaAdministrativa3; }
            set { _MedidaAdministrativa3 = value; OnPropertyChanged(); }
        }

        #endregion

        #region MULTIPLICADORES

        private string _MultiplicadorSelected { get; set; }
        public string MultiplicadorSelected
        {
            get { return _MultiplicadorSelected; }
            set { _MultiplicadorSelected = value; OnPropertyChanged(); }
        }

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

        private int _MultipSelectedIndex { get; set; }     
        public int MultipSelectedIndex
        {
            get { return _MultipSelectedIndex; }
            set { _MultipSelectedIndex = value; OnPropertyChanged(); }
        }

        #endregion

        private string _Observacion { get; set; }
        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; OnPropertyChanged(); }
        }


        private Boolean _IsChecked { get; set; }
        public Boolean IsChecked
        {
            get { return _IsChecked; }
            set { _IsChecked = value; OnPropertyChanged(); }
        }

        public Boolean Validar()
        {
            if (Regla.Multiplicador != MultiplicadorSelected) return false;
            return true;
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
            if (parameter.ToString() == "Continuar")
            {
                if (Validar())
                {
                    CurrentPage.DisplayAlert("👍", "resposta incorreta", "Fechar");
                }
                else
                {
                    CurrentPage.DisplayAlert("☹", "resposta incorreta", "Fechar");
                }

                GenerarPenalidades();
                GenerarMultiplicador();
                GenerarMedidaAdministrativa();
                MultipSelectedIndex = -1;
            }
            else
            {

            }

        }

        
        private ICommand _MultiplicadorSelectedItemChangedCommand;
        public ICommand MultiplicadorSelectedItemChangedCommand
        {
            get
            {
                if (_MultiplicadorSelectedItemChangedCommand == null)
                {
                    _MultiplicadorSelectedItemChangedCommand = new RelayCommand(MultiplicadorSelectedItemChangedExecute, CanSubmitExecute);
                }
                return _MultiplicadorSelectedItemChangedCommand;
            }
        }
        public async void MultiplicadorSelectedItemChangedExecute(object parameter)
        {
          
            var radioButtonGroupView = (Plugin.InputKit.Shared.Controls.RadioButtonGroupView)parameter;
            if (radioButtonGroupView.SelectedItem.ToString() == "Multiplicador") MultiplicadorSelected = Multiplicador;
            if (radioButtonGroupView.SelectedItem.ToString() == "Multiplicador2") MultiplicadorSelected = Multiplicador2;
            if (radioButtonGroupView.SelectedItem.ToString() == "Multiplicador3") MultiplicadorSelected = Multiplicador3;
            if (radioButtonGroupView.SelectedItem.ToString() == "Multiplicador4") MultiplicadorSelected = Multiplicador4;
        }

        public List<int> GenerarListaIds(int Cantidad, int MaxRange, int Incluir = 0)
        {

            List<int> listNumbers = new List<int>();
            var rand = new Random();
            for (int i = 0; i < Cantidad; i++)
            {
            Generar:
                int index = rand.Next(1, MaxRange);
                if (listNumbers.Contains(index))
                    goto Generar;
                listNumbers.Add(index);
            }

            if (Incluir != 0)
                if (!listNumbers.Where(x => x == Incluir).Any())
                {
                    listNumbers[rand.Next(0, Cantidad - 1)] = Incluir;
                }

            return listNumbers;
        }

    }
}
