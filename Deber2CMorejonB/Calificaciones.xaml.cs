using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Deber2CMorejonB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calificaciones : ContentPage
    {
        readonly Class1 clase1 = new Class1();

        public Calificaciones()
        {
            InitializeComponent();
        }

        private void btnNotas1_Clicked(object sender, EventArgs e)
        {
            

            try
            {
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double examen1 = Convert.ToDouble(txtExamen1.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double examen2 = Convert.ToDouble(txtExamen2.Text);

                if (nota1 < 0  || nota1 > 10 || nota2 < 0 || nota2 > 10 || examen1<0 || examen1>10 || examen2<0 || examen2>10)
                {
                    DisplayAlert("Alert", "La nota debe estar en el rango de 0 a 10", "OK");
                }
                else
                {
                    
                    double notaParcial1;
                    nota1 *= 0.3;
                    examen1 *= 0.2;
                    notaParcial1 = nota1 + examen1;

                   
                    double notaParcial2;
                    nota2 *= 0.3;
                    examen2 *= 0.2;
                    notaParcial2 = nota2 + examen2;
                    double notaFinal = notaParcial1 + notaParcial2;

                    txtResultadoNota1.Text = nota1.ToString();
                    txtResultadoExamen1.Text = examen1.ToString();
                    txtNotaParcial1.Text = notaParcial1.ToString();

                    txtResultadoNota2.Text = nota2.ToString();
                    txtResultadoExamen2.Text = examen2.ToString();
                    txtNotaParcial2.Text = notaParcial2.ToString();
                    txtFinal.Text = notaFinal.ToString();

                    if (notaFinal >= 7)
                    {

                        txtEstado.Text = "Aprobado";
                        txtEstado.TextColor = Color.Green;
                    }

                    else
                    {
                        txtEstado.Text = "Reprobado";

                        txtEstado.TextColor = Color.Red;
                    }

                }



            }
            catch (Exception ex)
            {
                DisplayAlert("mensaje", "ERROR" + ex.Message, "ok");
            }



            

        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            clase1.LimpiarLabel(txtNota1);
            clase1.LimpiarLabel(txtExamen1);
            clase1.LimpiarLabel(txtNota2);
            clase1.LimpiarLabel(txtExamen2);
            clase1.LimpiarLabel(txtNotaParcial1);
            clase1.LimpiarLabel(txtNotaParcial2);
            clase1.LimpiarLabel(txtResultadoNota1);
            clase1.LimpiarLabel(txtResultadoNota2);
            clase1.LimpiarLabel(txtResultadoExamen1);
            clase1.LimpiarLabel(txtResultadoExamen2);
            clase1.LimpiarLabel(txtFinal);
            clase1.LimpiarLabel(txtEstado);
        }
    }
}