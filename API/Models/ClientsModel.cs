using System;

namespace API.Models
{
    public class ClientsModel
    {
        /// <summary>
        /// CPF ou CNPJ
        /// </summary>
        /// <value></value>
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
        public DateTime BirthDate { get; set; }
    }
}