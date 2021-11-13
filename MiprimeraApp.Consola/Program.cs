using System;
using System.Collections.Generic;
using MiprimeraApp.Dominio;
using MiprimeraApp.Persistencia;

namespace MiprimeraApp.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();
        private static IRepositorioSignoVital _repoSignoVital = new RepositorioSignoVital();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //BuscarPaciente(2);
            //EliminarPaciente(1); 
            //MostrarPacientes();
            //AddMedico();
            //AsignarMedico();
            //AddSignoVital(); 
            AsignarSignoVital();
            //AsignarPaciente(); ok 
        }
  private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Pepito",
                Apellidos = "Perez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
        private static void EliminarPaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("paciente Eliminado");
        }
        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
            }
        }
        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Juliana",
                Apellidos = "Lopez",
                NumeroTelefono = "3001645",
                Genero = Genero.Femenino,
                Especialidad = "Internista",
                Codigo = "2535",
                RegistroRethus = "34567"
            };
            _repoMedico.AddMedico(medico);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(3, 4);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }

        private static void AddSignoVital()
        {
            var signoVital = new SignoVital
            {
                FechaHora = new DateTime(2021, 11, 12),
                Valor = 38.3F,
                Signo = TipoSigno.TemperaturaCorporal
            };
            _repoSignoVital.AddSignoVital(signoVital);
        }

        private static void AsignarSignoVital()
        {
            var signoVital = _repoPaciente.AsignarSignoVital(2, 1);
            Console.WriteLine(signoVital.Signo + " " + signoVital.Valor);
        }

        private static void AsignarPaciente()
        {
            var paciente = _repoSignoVital.AsignarPaciente(1, 1);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }
    }
}
