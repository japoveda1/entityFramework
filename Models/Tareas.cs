namespace ENTITY.Models

public class Tarea
{

    public Guid Tareaid{get;set;}
    public Guid CategoriasId {get;set;}
    public string Titulo {get;set;}
    public string Descripcion {get;set;}
    public Prioridad PrioridadTarea {get;set;}
    public datetime FechaCreacion {get;set;} 
    public virtual Categoria Categoria{get;set;}


}

public enum Prioridad
{
    Baja,
    Media,
    Alta
}