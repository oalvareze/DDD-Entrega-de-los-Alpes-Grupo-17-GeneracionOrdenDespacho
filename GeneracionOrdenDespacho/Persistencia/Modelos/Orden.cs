using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneracionOrdenDespacho.Persistencia.Modelos
{
    public class Orden
    {
        [Key]
        public Guid OrdenId { get; set; } = Guid.NewGuid();

        [MaxLength(255)]
        public string Usuario { get; set; }

        [MaxLength(1024)]
        public string DireccionUsuario { get; set; }

        #region Propiedades de navegación

        public virtual ICollection<DespachoUltimaMilla> Despachos { get; set; }

        #endregion
    }
}
