using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_EESA.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        DateTime _Fecha;
        string _Resultadofecha;
        #endregion

        #region OBJETOS
        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value);}
        }
        public string SeleccionTipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetProperty(ref _TipoUsuario, value); 
                TipoUsuario = _TipoUsuario;
            }
        }
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value);
                Resultadofecha = _Fecha.ToString("dd/MM/yyyy");
            }
        }
        public string Resultadofecha
        {
            get { return _Resultadofecha; }
            set { SetValue(ref _Resultadofecha, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Vista.Page2());
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(R);

            r = n1 + n2;
            R = r.ToString();
        }
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", R, "Ok");
        }

        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS
        public ICommand Navegarpagina2command => new Command(async () => await Navegarpagina2());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion

        #region CONTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }
        #endregion
    }
}
