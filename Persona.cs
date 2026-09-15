
internal class Persona
{
    public string Name { get; set; }
    public int Edad { get; set; }
    public string ApellidoP { get; set; }
    public string ApellidoM { get; set; }
    public DateTime FechaNacimiento { get; set; }

    // Constructor de la clase Persona
    public Persona(string name, int edad, string apellidoP, string apellidoM, DateTime fechaNacimiento)
    {
        Name = name;
        Edad = edad;
        ApellidoP = apellidoP;
        ApellidoM = apellidoM;
        FechaNacimiento = fechaNacimiento;
    }
}
