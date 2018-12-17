using FilRouge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRouge.Services.Interfaces
{
    public interface ICandidateService
    {
        void AddNewCandidate(Candidat model);
        List<Candidat> GetCandidates();
        Candidat GetCandidateById(int id);
    }
}
