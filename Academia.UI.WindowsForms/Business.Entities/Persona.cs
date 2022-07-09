using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Entities
{
    public abstract class Persona : BusinessEntity
    {
        private string _Apellido;
        public virtual string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        private string _Direccion;
        public virtual string Direccion
        {
            get { return this._Direccion; }
            set { this._Direccion = value; }
        }

        private string _Email;
        public virtual string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }

        private DateTime _FechaNacimiento;
        public virtual DateTime FechaNacimiento
        {
            get { return this._FechaNacimiento; }
            set { this._FechaNacimiento = value; }
        }

        private Plan _Plan;
        public virtual Plan Plan
        {
            get { return this._Plan; }
            set { this._Plan = value; }
        }

        private int? _Legajo;
        public virtual int? Legajo
        {
            get { return this._Legajo; }
            set { this._Legajo = value; }
        }

        private string _Nombre;
        public virtual string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        private string _Telefono;
        public string Telefono
        {
            get { return this._Telefono; }
            set { this._Telefono = value; }
        }

        private int _TipoPersona;
        [NotMapped]
        public virtual int TipoPersona
        {
            get { return this._TipoPersona; }
            set { this._TipoPersona = value; }
        }

        public override void Validar() { }
    }
}
