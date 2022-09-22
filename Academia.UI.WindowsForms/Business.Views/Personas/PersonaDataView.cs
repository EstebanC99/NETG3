using System;

namespace Business.Views
{
    public class PersonaDataView : DataView, IPersonaDataView
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Legajo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        #region Plan
        public int? PlanID { get; set; }
        public string PlanDescripcion { get; set; }
        #endregion
        public int TipoPersonaID { get; set; }
    }

    public interface IPersonaDataView : IDataView
    {
        string Nombre { get; set; }

        string Apellido { get; set; }

        int? Legajo { get; set; }

        string Direccion { get; set; }

        string Telefono { get; set; }

        string Email { get; set; }

        DateTime FechaNacimiento { get; set; }

        #region Plan
        int? PlanID { get; set; }

        string PlanDescripcion { get; set; }
        #endregion

        int TipoPersonaID { get; set; }
    }
}
