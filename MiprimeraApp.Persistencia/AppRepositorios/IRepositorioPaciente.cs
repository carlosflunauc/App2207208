using System.Collections.Generic;
using MiprimeraApp.Dominio;
namespace MiprimeraApp.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);    
        Paciente GetPaciente(int idPaciente);
        Medico AsignarMedico(int idPaciente, int idMedico);
        SignoVital AsignarSignoVital(int idPaciente, int idSignoVital);
   }
}