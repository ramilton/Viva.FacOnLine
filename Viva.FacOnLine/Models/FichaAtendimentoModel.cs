using System;
using System.ComponentModel.DataAnnotations;

namespace Viva.FacOnLine.Models
{
    public class FichaAtendimentoModel
    {
        [Required]
        [Key]
        [Display(Name = "Nº")]
        public int NumeroFicha { get; set; }

        [Required]
        [Display(Name = "Corretor")]
        public string NomeCorretor { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string NomeCliente { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string EmailCliente { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Tel. Res.")]
        public string TelRes { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Tel. Com.")]
        public string TelCom { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Required]
        [Display(Name = "Imóvel")]
        public string Imovel { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Fonte de Informação")]
        public string FonteInformacao { get; set; }

        [Display(Name = "Contato")]
        public string Contato { get; set; }

        [Display(Name = "Agendamento")]
        public Boolean Agendamento { get; set; }

        [Display(Name = "Data Agendamento")]
        [DataType(DataType.Date)]
        public DateTime AgendamentoData { get; set; }

        [Display(Name = "Hora Agendamento")]
        [DataType(DataType.Time)]
        public DateTime AgendamentoHora { get; set; }
    }
}