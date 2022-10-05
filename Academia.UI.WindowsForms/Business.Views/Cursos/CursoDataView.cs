namespace Business.Views
{
    public class CursoDataView : DataView
    {
        public int AnioCalendario { get; set; }

        public int Cupo { get; set; }

        public int MateriaID { get; set; }

        public string MateriaDescripcion { get; set; }

        public int ComisionID { get; set; }

        public string ComisionDescripcion { get; set; }

        public int PlanID { get; set; }

        public string PlanDescripcion { get; set; }

        public int EspecialidadID { get; set; }

        public string EspecialidadDescripcion { get; set; }

        public string ProfesorNombreApellido { get; set; }

        public int HsSemanales { get; set; }

        public int HsTotales { get; set; }

        public bool EstaInscripto { get; set; }

        public int CuposRestantes { get; set; }
    }
}
