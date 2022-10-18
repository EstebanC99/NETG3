namespace Business.Views
{
    public class AlumnoDataView : PersonaDataView, IPersonaDataView
    {
        public AlumnoDataView()
        {

        } 

        public int? InscripcionID { get; set; }

        public int? Nota { get; set; }
    }
}
