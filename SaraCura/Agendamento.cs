using Clinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Saracura
{
    public class Agendamento
    {
        public List<Medico> DisponibilidadePorEspecialidade(string especialidadeDesejada, List<Medico> todosMedicos)
        {
            return todosMedicos.Where(m => m.especialidades.Contains(especialidadeDesejada)).ToList();
        }

        public Agenda DisponilidadePorMedico(string medicoDesejado, List<Medico> todosMedicos)
        {
            Medico medico = todosMedicos.FirstOrDefault(m => m.nome == medicoDesejado);
            return medico.agenda;
        }

        public List<Medico> DisponibilidadeParaExame(string especialidadeDoExame, List<Medico> todosMedicos)
        {
            return todosMedicos.Where(m => m.especialidades.Contains(especialidadeDoExame) &&
                                           m.agenda.tempoConsulta == Constantes.Constantes.tempoConsulta[1]).ToList();
        }
    }
}
