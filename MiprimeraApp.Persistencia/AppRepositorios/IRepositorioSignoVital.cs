using System.Collections.Generic;
using MiprimeraApp.Dominio;
namespace MiprimeraApp.Persistencia
{
    public interface IRepositorioSignoVital
    {
        IEnumerable<SignoVital> GetAllSignosVitales();
        SignoVital AddSignoVital(SignoVital signoVital);
        SignoVital GetSignoVital(int idSignoVital);
        Paciente AsignarPaciente(int idSignoVital, int idPaciente);
   }
}
