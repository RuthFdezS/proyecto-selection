//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public Usuarios()
        {
            this.UsuariosPorPerfiles = new HashSet<UsuariosPorPerfiles>();
        }
    
        public string nicknameUsuario { get; set; }
        public string nomusuario { get; set; }
        public string pass { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual Usuarios Usuarios1 { get; set; }
        public virtual Usuarios Usuarios2 { get; set; }
        public virtual ICollection<UsuariosPorPerfiles> UsuariosPorPerfiles { get; set; }
    }
}
