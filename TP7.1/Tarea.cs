public class Tarea 
{
    int tareaID, duracion;
    string descripcion;

    public int TareaID { get => tareaID; set => tareaID = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }

    public void mostrar() {
        Console.WriteLine("Tarea "+TareaID+" - Duración: "+Duracion+"min - "+Descripcion);
    }
}