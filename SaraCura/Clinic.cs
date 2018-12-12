﻿using System;
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
        private int tempoConsulta;
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
        
    }

    /*class Pagamento
	{
		private string tipo;
		private 
	}*/

    class Consulta
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
            if (!paciente.GetAtendimento)
            {
                if (pagamento == null)
                {
                    throw new ArgumentNullException("pagamento", "Forma de pagamento inválida!");
                }
                else
                {
                    this.pagamento = pagamento;
                }
            }
        }
    }

    class Paciente
    {
        private string nome;
        private int idade;
        private string sexo;
        private double peso;
        private double altura;
        private bool atendimento;
        public bool GetAtendimento => atendimento;
    }
    
}