List<Tarea> tareas = new List<Tarea>();
tareas.Add(new Tarea {Id = 1, Titulo = "Lavar Ropa", Categoria = "Personal", Completada = false, FechaCreacion = DateTime.Now});
tareas.Add(new Tarea {Id = 2, Titulo = "Revisar Proyecto", Categoria = "Trabajo", Completada = true, FechaCreacion = DateTime.Now});
tareas.Add(new Tarea {Id = 3, Titulo = "Subir Proyecto", Categoria = "Trabajo", Completada = false, FechaCreacion = DateTime.Now});
tareas.Add(new Tarea {Id = 4, Titulo = "Aprender Tipos de Variables", Categoria = "Estudio", Completada = true, FechaCreacion = DateTime.Now});
tareas.Add(new Tarea {Id = 5, Titulo = "Aprender LINQ", Categoria = "Estudio", Completada = false, FechaCreacion = DateTime.Now});
tareas.Add(new Tarea {Id = 6, Titulo = "Aprender Colecciones", Categoria = "Estudio", Completada = false, FechaCreacion = DateTime.Now});

//Recorre todos los elementos y valida uno por uno si su categoría es estudio o no, si es verdadero, agrega el elemento a la nueva lista
var tareasEstudio = tareas.Where(t => t.Categoria == "Estudio").ToList();

//Recorre todos los elementos de la lista verifica cada elemento si está completado o no por medio de la variable Completada, agrega los elementos que cumplen con la condición a la nueva lista y los ordena por fecha de creación
var tareasNoCompletadas = tareas.Where(t => !t.Completada).OrderBy(t => t.FechaCreacion).ToList();

//Hace un contador interno y va aumentando su valor cada que encuentra una tarea completada
int totalCompletadas = tareas.Count(t => t.Completada);

//Recorre todos los elementos buscando la palabra C# en el titulo de cada una, si encuentra almenos uno, devuelve true
bool tareaC = tareas.Any(t => t.Titulo.Contains("C#"));

//Recorre todos los elementos y transforma a mayuscula cada titulo encontrado, el resultado lo guarda en una nueva lista
var tareasMayusculas = tareas.Select(t => t.Titulo.ToUpper());

Console.WriteLine("Tareas de Categoria Estudio: ");
foreach (var tarea in tareasEstudio)
    Console.WriteLine(tarea.Titulo);
Console.WriteLine();

Console.WriteLine("Tareas No Completadas");
foreach (var tarea in tareasNoCompletadas)
    Console.WriteLine(tarea.Titulo);
Console.WriteLine();

Console.WriteLine($"Total de Tareas Completadas: {totalCompletadas}");
Console.WriteLine();

Console.WriteLine($"¿Existe alguna tarea con la palabra C# en el título?: {(tareaC ? "Sí" : "No")}");
Console.WriteLine();

Console.WriteLine("Tareas en Mayúsculas:");
foreach (var tarea in tareasMayusculas)
    Console.WriteLine(tarea);
Console.WriteLine();