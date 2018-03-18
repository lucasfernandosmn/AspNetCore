using System;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class TarefaItem
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Tarefa Completa")]
        public bool EstaCompleta { get; set; }
        [Required(ErrorMessage="O nome da tarefa é obrigatório"),StringLength(200)] 
        public string Nome { get; set; }
        [Display(Name="Data de conclusão")]
        public DateTimeOffset? DataConclusao { get; set; }
    }
}