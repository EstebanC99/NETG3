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
    }
}
