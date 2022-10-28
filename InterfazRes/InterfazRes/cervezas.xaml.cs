using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cervezas : ContentPage
    {
        public cervezas()
        {
            InitializeComponent();
        }
        private void whisky(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Whisky());
        }
    }
}