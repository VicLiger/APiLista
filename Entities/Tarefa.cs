using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace provaACP.Entities
{
    public class Tarefa
    {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataHora { get; set; }
    public int Concluida { get; set; }
    }
}