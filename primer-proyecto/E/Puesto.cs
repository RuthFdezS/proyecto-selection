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
    
    public partial class Puesto
    {
        public Puesto()
        {
            this.PuestoPorExpediente = new HashSet<PuestoPorExpediente>();
        }
    
        public int codpuesto { get; set; }
        public Nullable<int> disponibilidad { get; set; }
        public string nombrepuesto { get; set; }
        public string idioma { get; set; }
        public string certificacion { get; set; }
        public string titulo { get; set; }
    
        public virtual ICollection<PuestoPorExpediente> PuestoPorExpediente { get; set; }
    }
}