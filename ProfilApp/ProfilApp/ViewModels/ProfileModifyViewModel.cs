using ProfilApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProfilApp.ViewModels
{
    public class ProfileModifyViewModel : BaseViewModel
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        User currentUser;

        string username;
        string description;
        string birthdate;
        string birthplace;
        int nbrview;
        int nbrshare;
        string avatar;
        string background;

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
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                SetProperty(ref username, value);
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                SetProperty(ref description, value);
            }
        }
        public string Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                SetProperty(ref birthdate, value);
            }
        }
        public string Birthplace
        {
            get
            {
                return birthplace;
            }
            set
            {
                SetProperty(ref birthplace, value);
            }
        }
        public int Nbrview
        {
            get
            {
                return nbrview;
            }
            set
            {
                SetProperty(ref nbrview, value);
            }
        }
        public int Nbrshare
        {
            get
            {
                return nbrshare;
            }
            set
            {
                SetProperty(ref nbrshare, value);
            }
        }
        public string Avatar
        {
            get
            {
                return avatar;
            }
            set
            {
                SetProperty(ref avatar, value);
            }
        }
        public string Background
        {
            get
            {
                return background;
            }
            set
            {
                SetProperty(ref background, value);
            }
        }

        public ProfileModifyViewModel(ObservableCollection<User> old, User selectedUser)
        {
            users = old;
            currentUser = selectedUser;

            Username = selectedUser.Username;
            Description = selectedUser.Description;
            Birthdate = selectedUser.BirthDate;
            Birthplace = selectedUser.BirthPlace;
            Nbrview = selectedUser.NbrView;
            Nbrshare = selectedUser.NbrShare;
            Avatar = selectedUser.Avatar;
            Background = selectedUser.Background;
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
            Users.Remove(currentUser);

            Users.Add(new User
            {
                Username = username,
                Description = description,
                BirthDate = birthdate,
                BirthPlace = birthplace,
                Avatar = avatar,
                Background = background,
                NbrShare = nbrshare,
                NbrView = nbrview
            });

            Application.Current.MainPage.Navigation.PushAsync(new ProfileListPage(Users));
        }
    }
}

