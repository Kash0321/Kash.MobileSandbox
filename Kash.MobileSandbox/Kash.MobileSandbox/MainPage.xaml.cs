using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kash.MobileSandbox
{
    public partial class MainPage : ContentPage
    {
        int Executions { get; set; } = 0;

        public MainPage()
        {
            InitializeComponent();

            cmdExecute.Clicked += CmdExecute_Clicked;
        }

        private void CmdExecute_Clicked(object sender, EventArgs e)
        {
            Executions++;
            lblMessage.Text = $"Botón pulsado {Executions} veces";
        }
    }
}
