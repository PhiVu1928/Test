using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using EventVBM.Models;
using EventVBM.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventVBM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExtraPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        readonly ExtraViewModel _model;
        public ExtraPage(Items items)
        {
            InitializeComponent();
            _model = new ExtraViewModel(items);
            BindingContext = _model;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}