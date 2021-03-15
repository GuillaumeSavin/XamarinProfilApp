using ProfilApp.Models;
using ProfilApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ProfilApp
{
    public partial class ProfileCreatePage : ContentPage
    {
        public ProfileCreatePage(ObservableCollection<User> old)
        {
            InitializeComponent();
            BindingContext = new ProfileCreateViewModel(old);
        }
    }
}
