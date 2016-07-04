using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class LivroModel
    {
        public int? Id { get; set; }
	    public int? LivroId { get; set; }
	    public int? Ranking { get; set; }
        public int? Tipo { get; set; }
        public int? Favorito { get; set; }
        public int? Desejado { get; set; }
        public int? Troco { get; set; }
        public int? Tenho { get; set; }
        public int? Emprestei { get; set; }
        public int? Paginas { get; set; }
        public DateTime? DtResenha { get; set; }
        public int? PaginasLidas { get; set; }
        public DateTime? DtLeitura { get; set; }
        public int? Meta { get; set; }
        public int? Spoiler { get; set; }
        public int? Update { get; set; }
        public EdicaoModel Edicao { get; set; }
    }
}