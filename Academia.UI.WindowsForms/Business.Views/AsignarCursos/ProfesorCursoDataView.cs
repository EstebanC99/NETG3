namespace Business.Views.AsignarCursos
{
    public class ProfesorCursoDataView : DataView
    {
        public int ProfesorID { get; set; }

        public string ProfesorNombre { get; set; }

        public string ProfesorApellido { get; set; }

        public int? ProfesorLegajo { get; set; }

        public string Cargo { get; set; }
    }
}
