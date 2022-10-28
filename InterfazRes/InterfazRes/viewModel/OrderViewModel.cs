using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public List<Pick> MenuListVino { get; set; }
        public List<Pick> MenuListCerveza { get; set; }
        public List<Pick> MenuListWhisky { get; set; }
        public OrderViewModel()
        {
            MenuListVino = GetMenuVino();
            MenuListCerveza = GetMenuCerveza();
            MenuListWhisky = GetMenuWhisky();
        }



        public List<Pick> GetMenuVino()
        {
            return new List<Pick>
            {
                new Pick{Title="Vino tinto", Image="vino.png", Description="", Price="200000"},
                new Pick{Title="Vino Blanco", Image="vino2.png", Description="", Price="300000"},

            };
        }
        public List<Pick> GetMenuCerveza()
        {
            return new List<Pick>
            {
                new Pick{Title="Heineken", Image="cerveza2.png", Description="", Price="4000"},
                new Pick{Title="Deek", Image="cerveza1.png", Description="", Price="3000"},

            };
        }

        public List<Pick> GetMenuWhisky()
        {
            return new List<Pick>
            {
                new Pick{Title="Buchanans", Image="Whisky1.png", Description="", Price="40000"},
                new Pick{Title="OldParr", Image="Whisky2.png", Description="", Price="30000"},

            };
        }
    }
}
