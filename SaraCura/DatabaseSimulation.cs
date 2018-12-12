using System;
using Clinica;
using Enums;
using Constantes;
using System.Collections.Generic;

namespace SimulacaoDeDatabase
{
    public class GeradorAleatorio
    {

        private static Random _random = new Random();

        //TODO: gerar equipamentos não tão aleatórios, sepá gerar uma lista de 5 especialidades e fazer seus respectivos equipamentos(?)

        public static Medico GerarMedicoAleatório()
        {
            string nome;
            int idade;
            string sexo;
            List<string> especialidades = new List<string>();
            Agenda agenda;

            sexo = EscolheAleatoriamente(typeof(Sexo), Constantes.Constantes.quantidadeSexos);

            if (sexo == Enum.GetName(typeof(Sexo), Sexo.Feminino))
            {
                nome = EscolheAleatoriamente(typeof(NomesFemininos), Constantes.Constantes.quantidadeNomes);
            }
            else
            {
                nome = EscolheAleatoriamente(typeof(NomesMasculinos), Constantes.Constantes.quantidadeNomes);
            }
            nome = nome + ' ' + EscolheAleatoriamente(typeof(Sobrenomes), Constantes.Constantes.quantidadeSobrenomes);

            idade = _random.Next(Constantes.Constantes.idadeMinima, Constantes.Constantes.idadeMaxima);

            int numeroDeEspecialidades = _random.Next(Constantes.Constantes.quantidadeMinimaEspecialidades, Constantes.Constantes.quantidadeMaximaEspecialidades);
            List<int> indicesEspecialidades = GerarNumerosAleatoriosUnicos(numeroDeEspecialidades, Constantes.Constantes.quantidadeEspecialidades);
            foreach(var indice in indicesEspecialidades)
            {
                especialidades.Add(Escolhe(typeof(Especialidades), indice));
            }

            agenda = GerarAgendaAleatória();

            return new Medico(nome, idade, sexo, especialidades, agenda); 
        }

        public static Agenda GerarAgendaAleatória()
        {

            int tempoConsulta;
            int chegada;
            List<string> dias = new List<string>();
            List<DisponibilidadePorDia> disponibilidade = new List<DisponibilidadePorDia>();

            tempoConsulta = Constantes.Constantes.tempoConsulta[_random.Next(3)];

            chegada = _random.Next(Constantes.Constantes.horarioMinimoDeChegada, Constantes.Constantes.horarioMaximoDeChegada);

            List<int> indicesDiasDeTrabalho = GerarNumerosAleatoriosUnicos(Constantes.Constantes.diasDeTrabalho, Constantes.Constantes.quantidadeDiasDaSemana);
            foreach (var indice in indicesDiasDeTrabalho)
            {
                dias.Add(Escolhe(typeof(DiasDaSemana), indice));
            }

            foreach(var dia in dias)
            {
                var disponibilidadePorDia = new DisponibilidadePorDia(dia, chegada, chegada + 6, tempoConsulta);
                disponibilidade.Add(disponibilidadePorDia);
            }

            return new Agenda(tempoConsulta, chegada, dias, disponibilidade);

        }

        private static List<int> GerarNumerosAleatoriosUnicos(int quantidade, int alcance)
        {
            List<int> lista = new List<int>();
            int contador = 0;
            int numero = 0;
            while (contador != quantidade)
            {
                numero = _random.Next(alcance);
                if (!lista.Contains(numero))
                {
                    lista.Add(numero);
                    contador++;
                }
            }

            return lista;
        }

        private static string EscolheAleatoriamente(Type tipo, int alcance)
        {
            return Enum.GetName(tipo, _random.Next(alcance));
        }

        private static string Escolhe(Type tipo, int indice)
        {
            return Enum.GetName(tipo, indice);
        }


    }
}