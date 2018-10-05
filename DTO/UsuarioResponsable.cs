namespace DTO
{
    public class UsuarioResponsable
    {
        public int UsuarioResponsableId { get; set; }
        public int UsuarioId { get; set; }
        public int AlumnoTituloId { get; set; }
        public string Comentario { get; set; }
        public bool Aprobo { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual AlumnoTitulo AlumnoTitulo { get; set; }
    }
}