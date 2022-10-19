namespace Business.Views.ReporteCursos
{
    public class ReporteCursoAlumnoDataView: DataView
    {
        public int? Legajo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Condicion { get; set; }

        public int? Nota { get; set; }
    }
}
