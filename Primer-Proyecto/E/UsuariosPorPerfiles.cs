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
    
    public partial class UsuariosPorPerfiles
    {
        public string nicknameUsuario { get; set; }
        public int codPerfil { get; set; }
<<<<<<< HEAD
        public Nullable<bool> activo { get; set; }
    
        public virtual Perfiles Perfiles { get; set; }
        public virtual Usuarios Usuarios { get; set; }
=======
    
        public virtual Perfiles Perfiles { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual UsuariosPorPerfiles UsuariosPorPerfiles1 { get; set; }
        public virtual UsuariosPorPerfiles UsuariosPorPerfiles2 { get; set; }
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
    }
}
