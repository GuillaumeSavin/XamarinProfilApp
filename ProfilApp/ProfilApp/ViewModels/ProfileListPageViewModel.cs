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

        public ProfileListPageViewModel(ObservableCollection<User> newUsers)
        {
            Users = newUsers;
        }
        public ICommand OnButtonCreateClickedCommand
        {
            get
            {
                return new Command(ButtonCreateClickedCommand);
            }
        }

        void ButtonCreateClickedCommand()
        {
            
            Application.Current.MainPage.Navigation.PushAsync(new ProfileCreatePage(Users));

        }

        public ICommand OnButtonShowClickedCommand
        {
            get
            {
                return new Command(ButtonShowClickedCommand);
            }
        }

        void ButtonShowClickedCommand()
        {
            if(UserSelected != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new ProfileViewPage(UserSelected));
            } 
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Information", "Veuillez sélectionner un profile avant d'appuyer sur ce bouton !", "OK");
                    UserSelected = null;
                });
            }
            
        }

        public ICommand OnButtonDeleteClickedCommand
        {
            get
            {
                return new Command(ButtonDeleteClickedCommand);
            }
        }

        void ButtonDeleteClickedCommand()
        {
            if (UserSelected != null)
            {
                Users.Remove(UserSelected);
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Information", "Veuillez sélectionner un profile avant d'appuyer sur ce bouton !", "OK");
                    UserSelected = null;
                });
            }
        }

        public ICommand OnButtonModifyClickedCommand
        {
            get
            {
                return new Command(ButtonModifyClickedCommand);
            }
        }

        void ButtonModifyClickedCommand()
        {
            if (UserSelected != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new ProfileModifyPage(Users, UserSelected));
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Information", "Veuillez sélectionner un profile avant d'appuyer sur ce bouton !", "OK");
                    UserSelected = null;
                });
            }
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
            }
        }
    }
}