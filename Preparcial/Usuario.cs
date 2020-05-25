using System.Windows.Forms;

namespace Preparcial
{
    public class Usuario
    {
        
        public string Nombre { get; set; }
        public string Contra { get; set; }
        public bool Admi { get; set; }
        public int IdUsuario { get; set; }

        public Usuario()
        {
            
        }

        public Usuario(int idUsuario,string nombre, string contra , bool admi)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Contra = contra;
            this.Admi = admi;

        }

        
    }
}