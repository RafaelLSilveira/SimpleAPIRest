using System;

namespace API.Models
{
    public class HealthPlansModel 
    {
        /// <summary>
        /// Plano
        /// </summary>
        /// <value></value>
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
        public DateTime BeginningDate { get; set; }

        /// <summary>
        /// Data Final de Vigência 
        /// </summary>
        /// <value></value>
        public DateTime? EndingDate { get; set; }
    }
}