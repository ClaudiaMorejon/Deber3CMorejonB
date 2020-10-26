using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deber2CMorejonB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calificaciones();
           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
