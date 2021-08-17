using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.AspNet.Models
{
    public class ClienteModel
    {
        public ClienteModel() { }

        public ClienteModel(
            int clienteId, 
            String nome, 
            String email)
        {
            this.ClienteId = clienteId;
            this.Nome = nome;
            this.Email = email;
        }

        public ClienteModel(
            int clienteId, 
            string nome, 
            string email, 
            DateTime dataNascimento, 
            string observacao) : this(clienteId, nome, email)
        {
            DataNascimento = dataNascimento;
            Observacao = observacao;
        }

        public ClienteModel(
            int clienteId, 
            string nome,
            string email, 
            DateTime dataNascimento, 
            string observacao, 
            int representanteId) : this(clienteId, nome, email, dataNascimento, observacao)
        {
            RepresentanteId = representanteId;
        }

        public ClienteModel(
            int clienteId, 
            string nome, 
            string email, 
            DateTime dataNascimento, 
            string observacao, 
            int representanteId, 
            RepresentanteModel representante) : this(clienteId, nome, email, dataNascimento, observacao, representanteId)
        {
            Representante = representante;
        }

        [Display(Name = "Id do Cliente:")]
        [HiddenInput]
        public int ClienteId { get; set; }

        [Display(Name = "Nome do Cliente:")]
        public string Nome { get; set; }

        [Display(Name = "E-mail do Cliente:")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento:")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Observação:")]
        [DataType(DataType.MultilineText)]
        public string Observacao { get; set; }

        public int RepresentanteId { get; set; }
        public RepresentanteModel Representante { get; set; }

    }
}
