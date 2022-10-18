namespace Business.Views.Cursos
{
    public class InscripcionDataView : DataView
    {
        public int? Nota { get; set; }

        public int AlumnoID { get; set; }

        public string AlumnoNombre { get; set; }

        public string AlumnoApellido { get; set; }

        public int? AlumnoLegajo { get; set; }

        public int CursoID { get; set; }

        public string MateriaDescripcion { get; set; }

        public int AnioCalendario { get; set; }
    }
}
