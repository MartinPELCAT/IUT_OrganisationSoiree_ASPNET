using SondageSoiree.Models.Entity;
using SondageSoiree.Models;
using SondageSoiree.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sondagesoiree.Models.DAL
{
    public class Dal : IDal
    {
        public int AjouterEtudiant(string nom, string prenom, string password)
        {
            throw new NotImplementedException();
        }

        public int AjouterVote(int idSondage, int idResto, int idEtudiant)
        {
            throw new NotImplementedException();
        }

        public Eleve Authentifier(string nom, string password)
        {
            throw new NotImplementedException();
        }

        public int CreerRestaurant(string nom, string adresse, string telephone, string email)
        {
            throw new NotImplementedException();
        }

        public int CreerSondage(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ModifierRestaurant(int idResto, string nom, string adresse, string telephone, string email)
        {
            throw new NotImplementedException();
        }

        public Eleve RenvoieEtudiant(int idEtudiant)
        {
            throw new NotImplementedException();
        }

        public Restaurant RenvoieRestaurant(int idRestaurant)
        {
            throw new NotImplementedException();
        }

        public IList<Resultat> RenvoieResultat(int idSondage)
        {
            throw new NotImplementedException();
        }

        public IList<Restaurant> RenvoieTousLesRestaurants()
        {
            throw new NotImplementedException();
        }

        public bool RestaurantExist(string nom)
        {
            throw new NotImplementedException();
        }

        public Dal SoireeContext()
        {
            return SoireeContext();

        }

        public bool VoteExist(int idSondage, int idEtudiant)
        {
            throw new NotImplementedException();
        }

        Eleve IDal.Authentifier(string nom, string password)
        {
            throw new NotImplementedException();
        }

        Eleve IDal.RenvoieEtudiant(int idEtudiant)
        {
            throw new NotImplementedException();
        }

        Restaurant IDal.RenvoieRestaurant(int idRestaurant)
        {
            throw new NotImplementedException();
        }

        IList<Restaurant> IDal.RenvoieTousLesRestaurants()
        {
            throw new NotImplementedException();
        }
    }
}




