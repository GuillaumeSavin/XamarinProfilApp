using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfilApp.Models;
using ProfilApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProfilApp
{
    public partial class ProfileListPage : ContentPage
    {
        public ProfileListPage()
        {
            InitializeComponent();
            BindingContext = new ProfileListPageViewModel();
        }
    }
}