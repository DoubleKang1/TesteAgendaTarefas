using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaCrud.Models
{
    public class Tarefa
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Data { get; set; }

        public string HoraInicio { get; set; }

        public string HoraFim { get; set; }

        public string Prioridade { get; set; }
            
        public Boolean TarefaFinalizada { get; set; }


    }
}
