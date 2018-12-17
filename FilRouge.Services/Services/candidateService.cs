using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilRouge.Domain.Entities;
using FilRouge.Services.Interfaces;

namespace FilRouge.Services.Services
{
    public class CandidateService : ICandidateService
    {
        //ajouter un candidat
        public void AddNewCandidate(Candidat model)
        {
            //ajouter un candidat à la table candidat
            //connexion avec dbContext
            FilRougeContext dbContext = new FilRougeContext();
            //ajouter à la table candidat le nouveau candidat via le context
            dbContext.Candidat.Add(model);
            dbContext.SaveChanges();
           
        }
        //retourne la liste des candidats
        public List<Candidat> GetCandidates()
        {
            //connexion avec dbContext
            FilRougeContext dbContext = new FilRougeContext();
            //retourner la lister
            return dbContext.Candidat.ToList();
          
        }
        //retourne un candidat dont l'id est passé en paramètre
        public Candidat GetCandidateById(int id)
        {
            //connexion avec dbContext
            FilRougeContext dbContext = new FilRougeContext();
            //retourner un candidat avec son id comme paramètre
            return GetCandidates().Where(c => c.IdCandidat == id).SingleOrDefault();
            
        }
    }
}
