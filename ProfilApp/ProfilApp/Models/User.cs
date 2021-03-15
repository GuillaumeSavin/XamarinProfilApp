using System;
using System.Collections.Generic;
using System.Text;

namespace ProfilApp.Models
{
    public class User
    {
        public string Username
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string BirthDate
        {
            get;
            set;
        }
        public string BirthPlace
        {
            get;
            set;
        }
        public int NbrView
        {
            get;
            set;
        }
        public int NbrShare
        {
            get;
            set;
        }
        public string Avatar
        {
            get;
            set;
        }
        public string Background
        {
            get;
            set;
        }

        public User()
        {
            Username = "Perceval";
            Description = "Perceval est un des Chevaliers de la Table Ronde. Il est l'un des chevaliers les plus fidèles au Roi Arthur et le considère comme un des être les plus chers. Alors qu'il est souvent traité d'imbécile, il est relativement intelligent par moments. Il est aussi extrêmement sensible aux gens qui l'aiment et qui l'entourent.";
            BirthDate = "42/42/1130";
            BirthPlace = "Listenois";
            NbrView = 0;
            NbrShare = 0;
            Avatar = "perceval.jpg";
            Background = "kaamelott.png";
        }
    }
}
