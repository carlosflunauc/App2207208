namespace MiprimeraApp.Dominio
{
    /// <summary> Class <c> Medico </c>
    /// Modela un medico del equipo
    /// </summary>
    public class Medico : Persona
    {
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
        public string RegistroRethus {get; set;}
    }
}