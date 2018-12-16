using SimulacaoDeDatabase;
using System;
using System.Collections.Generic;

namespace Clinica
{
    public class DisponibilidadePorDia
    {
        private string dia; 
        private List<DateTime> horariosLivres;

        public DisponibilidadePorDia(string dia, int chegada, int saida, int tempoConsulta)
        {
            this.dia = dia;
            DateTime horaInicial = new DateTime(2000, 1, 1, chegada, 0, 0);
            DateTime horaFinal = new DateTime(2000, 1, 1, saida, 0, 0);
            while(horaInicial != horaFinal)
            {
                this.horariosLivres.Add(horaInicial);
                horaInicial.AddMinutes(tempoConsulta);
            }
        }
    }

    public class Agenda
    {
        public int tempoConsulta;
        private DateTime chegada;
        private DateTime saida;
        private List<string> dias = new List<string>();
        private List<DisponibilidadePorDia> disponibilidade;

        public Agenda()
        {
            this.tempoConsulta = 20;
            this.chegada = new DateTime(2000, 1, 1, 7, 0, 0);
            this.saida = new DateTime(2000, 1, 1, 20, 0, 0);
            this.dias = TodosOsDias();
            this.disponibilidade = new List<DisponibilidadePorDia>();
        }

        public Agenda(int tempoConsulta, int chegada, List<string> dias, List<DisponibilidadePorDia> disponibilidade)
        {
            this.tempoConsulta = tempoConsulta;
            this.chegada = new DateTime(2000, 1, 1, chegada, 0, 0); ;
            this.saida = new DateTime(2000, 1, 1, chegada + 6, 0, 0);
            this.dias = dias;
            this.disponibilidade = disponibilidade;
        }

        private List<string> TodosOsDias()
        {
            List<string> listaDeDias = new List<string>();
            foreach(var dia in Enum.GetNames(typeof(Enums.DiasDaSemana)))
            {
                listaDeDias.Add(dia);
            }

            return listaDeDias;
        }
    }

    public class Equipamento
    {
        private string tipo;
        private bool estado;
        private List<string> especialidades;
        private Agenda agenda;

        public Equipamento(string tipo, bool estado, List<string> especialidades)
        {
            this.tipo = tipo;
            this.estado = estado;
            this.especialidades = especialidades;
            this.agenda = new Agenda();
        }
    }

    public class Medico
    {
        public string nome;
        private int idade;
        private string sexo;
        public List<string> especialidades;
        public Agenda agenda;

        public Medico(string nome, int idade, string sexo, List<string> especialidades, Agenda agenda)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.especialidades = especialidades;
            this.agenda = agenda;
        }

        //TODO: gerar um método adicionar médico para ser usado no botão de ok do cadastro do médico. Adicionar a lista Sessao.MedicosCadastrados
        
    }

    /*class Pagamento
	{
		private string tipo;
		private 
	}*/

    public class Consulta
    {
        private Paciente paciente;
        private Medico medico;
        private string diaDaSemana;
        private DateTime horario;
        private string pagamento;

        public Consulta(Paciente paciente, Medico medico, string diaDaSemana, DateTime horario, string pagamento)
        {
            this.paciente = paciente;
            this.medico = medico;
            this.diaDaSemana = diaDaSemana;
            this.horario = horario;
            //if (!paciente.GetAtendimento)
            //{
            //    if (pagamento == null)
            //    {
            //        throw new ArgumentNullException("pagamento", "Forma de pagamento inválida!");
            //    }
            //    else
            //    {
            //        this.pagamento = pagamento;
            //    }
            //}
        }

        //TODO: gerar um método para agendar consulta, retirando da lista do médico o horário selecionado
    }

    public class Paciente
    {
        private int contador = 0;
        private string nome;
        private string email;
        private string telefone;
        public Pagamento pagamento;

        public Paciente (string nome, string email, string telefone, string matricula)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.pagamento = new Pagamento()
            {
                convenio = true,
                matricula = matricula
            };
            this.contador++;
        }

        public Paciente (string nome, string email, string telefone, string tipoCartao, string nomeCartao, string numeroCartao, int cvv, string cpf)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.pagamento = new Pagamento()
            {
                convenio = false,
                cartao = new Cartao()
                {
                    tipo = tipoCartao,
                    nome = nomeCartao,
                    numero = numeroCartao,
                    cvv = cvv,
                    cpf = cpf
                }
            };
            if(this.contador >= 12)
            {
                this.contador = 0;
            }
        }

        public List<Paciente> AdicionarPaciente(List<Paciente> todosPacientes, Paciente paciente)
        {
            if(contador != 12)
            {
                todosPacientes.Add(paciente);
                return todosPacientes;
            }
            else
            {
                throw new Exception("Erro: solicitação não autorizada.");
            }
        }

    }

    public class Pagamento
    {
        public bool convenio;
        public string matricula;
        public Cartao cartao;
    }

    public class Cartao
    {
        public string tipo;
        public string nome;
        public string numero;
        public int cvv;
        public string cpf;
    }

    public class Sessao
    {
        public List<Medico> MedicosCadastrados;
        public List<Paciente> PacientesCadastrados;
        public List<Equipamento> EquipamentosCadastrados;
        public List<Consulta> ConsultasAgendadas;

        public Sessao()
        {
            MedicosCadastrados = new List<Medico>();
            PacientesCadastrados = new List<Paciente>();
            EquipamentosCadastrados = new List<Equipamento>();
            ConsultasAgendadas = new List<Consulta>();
        }

        public void CriarSessao()
        {
            for (int i = 0; i < Constantes.Constantes.medicosGerados; i++)
            {
                MedicosCadastrados.Add(GeradorAleatorio.GerarMedicoAleatório());
            }

            //TODO: gerar equipamentos
            

        }
    }

}