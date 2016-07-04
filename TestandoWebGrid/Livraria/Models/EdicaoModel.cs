using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class EdicaoModel
    {
        public int? Id { get; set; }
		public int? LivroId { get; set; }
        public string Titulo { get; set; }
        public string NomePortugues { get; set; }
        public string Subtitulo { get; set; }
        public string SubtituloPortugues { get; set; }
        public string Idioma { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }
        public string Autor { get; set; }
        public long? Isbn { get; set; }
        public int? Paginas { get; set; }
        public int? Edicao { get; set; }
        public string Editora { get; set; }
        public string Sinopse { get; set; }
        public string CapituloUrl { get; set; }
        public string CapaGrande { get; set; }
        public string CapaMedia { get; set; }
        public string CapaPequena { get; set; }
        public string CapaMini { get; set; }
        public string CapaMicro { get; set; }
        public string CapaNano { get; set; }
        public string ImgUrl { get; set; }
        public string Url { get; set; }
        public decimal? PrecoMin { get; set; }
        public decimal? PrecoMax { get; set; }
        public decimal? PrecoOff { get; set; }
    }
}