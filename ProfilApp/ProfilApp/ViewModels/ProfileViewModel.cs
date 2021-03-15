using ProfilApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProfilApp.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        string username;
        string description;
        string birthdate;
        string birthplace;
        int nbrview;
        int nbrshare;
        string avatar;
        string background;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                SetProperty (ref username, value);                
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
                SetProperty (ref description, value);                
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
                SetProperty (ref birthdate, value);                
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
                SetProperty (ref birthplace, value);                
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
                SetProperty (ref nbrview, value);                
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
                SetProperty (ref nbrshare, value);                
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
                SetProperty (ref avatar, value);                
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
                SetProperty (ref background, value);                
            }
        }


        //Suppression du bouton car juste consultation du profile
        /*
        public ICommand OnButtonShareClickedCommand
        {
            get
            {
                return new Command(ButtonShareClicked);
            }
        }

        void ButtonShareClicked()
        {
            Nbrshare ++;
        }
        */

        public ProfileViewModel(User user)
        {
            Username = user.Username;
            Description = user.Description;
            Birthdate = user.BirthDate;
            Birthplace = user.BirthPlace;
            Nbrview = user.NbrView;
            Nbrshare = user.NbrShare;
            Avatar = user.Avatar;
            Background = user.Background;
        }
    }
}
