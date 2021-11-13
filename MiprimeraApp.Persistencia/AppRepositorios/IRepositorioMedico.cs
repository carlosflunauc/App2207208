using System.Collections.Generic;
using MiprimeraApp.Dominio;
namespace MiprimeraApp.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        void DeleteMedico(int idMedico);    
        Medico GetMedico(int idMedico);
   }
}