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
        /// <summary>
        /// ajouter un candidat
        /// </summary>
        /// <param name="model"></param>
        public void AddNewCandidate(Candidat model)
        {
            //connexion avec dbContext
            using (FilRougeContext dbContext = new FilRougeContext())
            { 
                //ajouter à la table candidat le nouveau candidat via le context
                dbContext.Candidats.Add(model);
                dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// retourne la liste des candidats
        /// </summary>
        /// <returns></returns>
        public List<Candidat> GetCandidates()
        {
            //connexion avec dbContext
            using (FilRougeContext dbContext = new FilRougeContext())
            {
                //retourner la liste
                return dbContext.Candidats.ToList();
            }
        }

        /// <summary>
        /// retourne un candidat dont l'id est passé en paramètre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Candidat GetCandidateById(int id)
        {
            //retourner un candidat avec son id comme paramètre
            return GetCandidates().Where(c => c.IdCandidat == id).SingleOrDefault();
            
        }
    }
}
