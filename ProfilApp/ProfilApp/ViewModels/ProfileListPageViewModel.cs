using ProfilApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProfilApp.ViewModels
{
    public class ProfileListPageViewModel : BaseViewModel
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        User userSelected;

        public ObservableCollection<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                SetProperty(ref users, value);
            }
        }

        public ProfileListPageViewModel()
        {
            Users.Add(new User
            {
                Username = "Perceval",
                Description = "Chef de clan des semi-croustillants"
            });
            Users.Add(new User
            {
                Username = "Arthur",
                Description = "Roi de Bretagne"
            });
            Users.Add(new User
            {
                Username = "Lancelot",
                Description = "Chevalier errant"
            });

        }       

        public User UserSelected
        {
            get
            {
                return userSelected;
            }
            set
            {
                SetProperty(ref userSelected, value);

                if(value != null)
                {
                    Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage(value));
                    UserSelected = null;
                }
            }
        }
    }
}