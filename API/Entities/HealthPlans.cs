using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    /// <summary>
    /// Planos de Saúde
    /// </summary>
    public class HealthPlans 
    {
        public HealthPlans()
        {

        }

        #region fields

        /// <summary>
        /// Identificador
        /// </summary>
        /// <value></value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Cliente
        /// </summary>
        /// <value></value>
        public int? ClientId { get; set; }
        public Clients Client { get; set; }

        /// <summary>
        /// Plano
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage = "O campo Plano é obrigatório!")]
        [MaxLength(255, ErrorMessage = "O campo Plano pode conter ate 11 caracteres!")]
        public string Title { get; set; }

        /// <summary>
        /// Permite Pessoa Jurídica
        /// </summary>
        /// <value></value>
        public bool AllowsLegalPerson { get; set; }   

        /// <summary>
        /// Data de Início de Vigência 
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage = "O campo Data de Início de Vigência é obrigatório!")]
        public DateTime BeginningDate { get; set; }

        /// <summary>
        /// Data Final de Vigência 
        /// </summary>
        /// <value></value>
        public DateTime? EndingDate { get; set; }

        /// <summary>
        /// Data de Cadastro
        /// </summary>
        /// <value></value>
        public DateTime Created { get; set; }

        #endregion fields
    }
}