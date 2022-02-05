using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    /// <summary>
    /// Clientes
    /// </summary>
    public class Clients
    {
        public Clients()
        {
            HealthPlans = new HashSet<HealthPlans>();
        }

        #region fields

        /// <summary>
        /// Identificador
        /// </summary>
        /// <value></value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// CPF ou CNPJ
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage = "O campo CPF/CNPJ é obrigatório!")]
        [MaxLength(14, ErrorMessage = "O campo CPF/CNPJ pode conter ate 11 caracteres!")]
        public string TxId { get; set; }

        /// <summary>
        /// RG
        /// </summary>
        /// <value></value>
        public string IdentityCard { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        public string Name { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        /// <value></value>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        /// <value></value>
        public string Email { get; set; }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório!")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Data de Cadastro
        /// </summary>
        /// <value></value>
        public DateTime Created { get; set; }

        #endregion fields

        #region collections

        public ICollection<HealthPlans> HealthPlans { get; set; }

        #endregion collections
    }
}