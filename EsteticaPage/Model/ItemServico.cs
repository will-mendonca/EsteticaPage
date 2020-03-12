using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaPage.Model
{
    public class ItemServico
    {
        [Key]
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public float Preço { get; set; }
        public DateTime Data { get; set; }

        [ForeignKey("Procedimento")]
        public int ProcedimentoId { get; set; }
        public Procedimento Procedimento { get; set; }
    }
}
