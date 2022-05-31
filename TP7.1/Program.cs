//Dentro de la clase Empleado

const int N = 3;
string[] descripciones = {"Sacar la basura", "Imprimir reportes", "Regar las plantas", "Pedir delivery", "Ordenar la oficina"};

var tareasPendientes = new List<Tarea>();
var tareasRealizadas = new List<Tarea>();
var rnd = new Random();
Tarea nueva;
for (int i = 0; i < N; i++) {
    nueva = new Tarea();
    nueva.TareaID = i;
    nueva.Duracion = rnd.Next(10,100);
    nueva.Descripcion = descripciones[rnd.Next(0,descripciones.Length)];
    tareasPendientes.Add(nueva);
}

Console.WriteLine("\n1.- Tareas Realizadas");
foreach (var tarea in tareasPendientes) {
    Console.WriteLine("¿Realizó la tarea de: "+tarea.Descripcion+"? (0/1)");
    bool resp = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));
    if(resp) {
        tareasRealizadas.Add(tarea);
        tareasPendientes.Remove(tarea);//!?
    }
}

Console.WriteLine("\n2.- Buscador de tareas pendientes");
Console.WriteLine("Ingrese una palabra clave: ");
string palabra = Console.ReadLine();

foreach (var tarea in tareasPendientes) {
    if(tarea.Descripcion.ToLower().Contains(palabra.ToLower().Trim())) {
        tarea.mostrar();
    }
}

int horas = 0;
foreach (var tarea in tareasRealizadas) {
    horas += tarea.Duracion;
}
Console.WriteLine("\n3.- Horas trabajadas por el empleado: "+horas);


