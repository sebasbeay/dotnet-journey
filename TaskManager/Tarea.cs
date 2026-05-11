// Tarea.cs
public class Tarea
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public bool Completada { get; set; }
    public DateTime FechaCreacion { get; set; }
}