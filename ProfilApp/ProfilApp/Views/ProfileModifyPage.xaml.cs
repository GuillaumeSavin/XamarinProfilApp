using ProfilApp.Models;
using ProfilApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProfilApp 
{
    public partial class ProfileModifyPage : ContentPage
    {
        public ProfileModifyPage(ObservableCollection<User> old, User selectedUser)
        {
            InitializeComponent();
            BindingContext = new ProfileModifyViewModel(old, selectedUser);
        }
    }
}