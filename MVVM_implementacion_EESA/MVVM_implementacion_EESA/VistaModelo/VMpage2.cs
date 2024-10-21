using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_EESA.VistaModelo;
using MVVM_implementacion_EESA.Modelo;

namespace MVVM_implementacion_EESA.VistaModelo
{
    public class VMpage2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion

        #region CONTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
                { 
                    new Musuarios
                    {
                        Nombre = "Eduardo",
                        Imagen = "https://ibb.co/cgCPqg2"
                    },
                    new Musuarios
                    {
                        Nombre = "Eduardo",
                        Imagen = "https://ibb.co/cgCPqg2"
                    },
                    new Musuarios
                    {
                        Nombre = "Eduardo",
                        Imagen = "https://ibb.co/cgCPqg2"
                    },
                    new Musuarios
                    {
                        Nombre = "Eduardo",
                        Imagen = "https://ibb.co/cgCPqg2"
                    },
                };
        }
        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(Mostrarusuarios);
        #endregion

    }
}

