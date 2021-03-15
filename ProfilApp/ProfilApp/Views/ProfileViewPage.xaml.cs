using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfilApp.Models;
using ProfilApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProfilApp;

namespace ProfilApp
{
    public partial class ProfileViewPage : ContentPage
    {
        public ProfileViewPage(User user)
        {
            InitializeComponent();

            BindingContext = new ProfileViewModel(user);
        }
    }
}
