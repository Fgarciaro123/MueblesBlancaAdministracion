using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class Persona
    {
        int _idPersona;
        long _numeroIdentificacionPersona;
        int _tipoDocumento;
        string _primerNombre;
        string _segundoNombre;
        string _primerApellido;
        string _segundoApellido;
        string _email;
        long _celular;
        string _direccion;
        int _rolPersona;
        string _password;
        DateTime _fechaCreacion;
        DateTime _fechaModificacion;

        public Persona()
        {

        }

        public Persona(
            long pNumeroIdentificacion,
            int pIdTipoIdentificacion,
            string pPrimerNombre,
            string pSegundoNombre,
            string pPrimerApellido,
            string pSegundoApellido,
            string pEmailPersona,
            int pIdrol,
            string pPassword,
            DateTime pFechaCreacion
            )
        {
            this.NumeroIdentificacionPersona = pNumeroIdentificacion;
            this.TipoDocumento = pIdTipoIdentificacion;
            this.PrimerNombre = pPrimerNombre;
            this.SegundoNombre = pSegundoNombre;
            this.PrimerApellido = pPrimerApellido;
            this.SegundoApellido = pSegundoApellido;
            this.Email = pEmailPersona;
            this.Password = pPassword;
            this.RolPersona = pIdrol;
            this.FechaCreacion = pFechaCreacion;
        }

        public Persona(
            int pIdPersona,
            long pNumeroIdentificacion,
            int pIdTipoIdentificacion,
            string pPrimerNombre,
            string pSegundoNombre,
            string pPrimerApellido,
            string pSegundoApellido,
            string pEmailPersona,
            string pPassword,
            DateTime pFechaCreacion
            )
        {
            this.IdPersona = pIdPersona;
            this.NumeroIdentificacionPersona = pNumeroIdentificacion;
            this.TipoDocumento = pIdTipoIdentificacion;
            this.PrimerNombre = pPrimerNombre;
            this.SegundoNombre = pSegundoNombre;
            this.PrimerApellido = pPrimerApellido;
            this.SegundoApellido = pSegundoApellido;
            this.Email = pEmailPersona;
            this.Password = pPassword;
            this.FechaCreacion = pFechaCreacion;
        }

        public Persona(int idPersona, long numeroIdentificacionPersona, int tipoDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string email, long celular, string direccion, int rolPersona, string password, DateTime fechaCreacion, DateTime fechaModificacion)
        {
            _idPersona = idPersona;
            _numeroIdentificacionPersona = numeroIdentificacionPersona;
            _tipoDocumento = tipoDocumento;
            _primerNombre = primerNombre;
            _segundoNombre = segundoNombre;
            _primerApellido = primerApellido;
            _segundoApellido = segundoApellido;
            _email = email;
            _celular = celular;
            _direccion = direccion;
            _rolPersona = rolPersona;
            _password = password;
            _fechaCreacion = fechaCreacion;
            _fechaModificacion = fechaModificacion;
        }

        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public long NumeroIdentificacionPersona { get => _numeroIdentificacionPersona; set => _numeroIdentificacionPersona = value; }
        public int TipoDocumento { get => _tipoDocumento; set => _tipoDocumento = value; }
        public string PrimerNombre { get => _primerNombre; set => _primerNombre = value; }
        public string SegundoNombre { get => _segundoNombre; set => _segundoNombre = value; }
        public string PrimerApellido { get => _primerApellido; set => _primerApellido = value; }
        public string SegundoApellido { get => _segundoApellido; set => _segundoApellido = value; }
        public string Email { get => _email; set => _email = value; }
        public long Celular { get => _celular; set => _celular = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int RolPersona { get => _rolPersona; set => _rolPersona = value; }
        public string Password { get => _password; set => _password = value; }
        public DateTime FechaCreacion { get => _fechaCreacion; set => _fechaCreacion = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
    }
}
