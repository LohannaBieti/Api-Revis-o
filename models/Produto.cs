using System;
using System.ComponentModel.DataAnnotations;

namespace API_revisao.models;

public class Produto()
{
    [Key]
    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.Now;
}
