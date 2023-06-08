using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEstudo.Dominio.Dominio
{
    [Table("tb_Carro")]
    public class Carro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCarro { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NomeMotorista { get; set; }

        public string Telefone { get; set; }

        public Pessoa Pessoa { get; set; }

        [ForeignKey("Pessoa")]
        public int Id_Pessoa { get; set; }
    }
}
