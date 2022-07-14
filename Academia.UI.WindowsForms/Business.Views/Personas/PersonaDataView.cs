using System;

namespace Business.Views
{
    public class PersonaDataView : DataView
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int? Legajo { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        #region Plan
        public int PlanID { get; set; }

        public string PlanDescripcion { get; set; }
        #endregion
    }
}
