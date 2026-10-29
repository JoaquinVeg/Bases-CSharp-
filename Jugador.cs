public class Jugador
{
    public string Name { get; set; }
    public int Edad { get; set; }

    public Jugador(string name, int edad) //Este sera el constructur, el cual tomara los atributos.
    {
        Name = name;
        Edad = edad;
    }
    public override string ToString()
    {
        return $"Nombre: {Name}, Edad: {Edad}";
    }


}