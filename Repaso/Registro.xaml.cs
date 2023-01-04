﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Repaso.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "Bienvenido" + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidadx = Convert.ToInt32(txtCantidad.Text);

                double valor = precio + cantidadx;
                DisplayAlert("VALOR TOTAL DEL PRODUCTO", valor.ToString(), "Cerrar");
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }



            double precio = Convert.ToDouble(txtPrecio.Text);
            int cantidad = Convert.ToInt32((txtCantidad.Text));

            double valor = precio + cantidad;
            DisplayAlert("VALOR TOTAL DEL PRODUCTO", valor.ToString(), "Cerrar");
            
        }

    }
}