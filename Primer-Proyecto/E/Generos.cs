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
    
    [Serializable]
    public partial class Generos
    {
        public Generos()
        {
            this.Expediente = new HashSet<Expediente>();
        }
    
        public int codgenero { get; set; }
        public string nomgenero { get; set; }
    
        public virtual ICollection<Expediente> Expediente { get; set; }
    }
}
