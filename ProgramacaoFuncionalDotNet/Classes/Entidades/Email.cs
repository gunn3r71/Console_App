using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Classes.Entidades
{
    public class Email
    {
        /// <summary>
        /// Quando construtor é privado, não consigo realizar uma instância
        /// </summary>
        private Email()
        {
        }

        private static Email instance;
        public string From;
        public string To;
        public string Subject;
        public string Body;


        public static Email Instance {
            get
            {
                if (instance == null)
                {
                    instance = new Email();
                }
                return instance;
            }
        }

        public void EnviarEmail()
        {
            if (!string.IsNullOrEmpty(this.From) && !string.IsNullOrEmpty(this.To) && !string.IsNullOrEmpty(this.Subject) && !string.IsNullOrEmpty(this.Body))
            {
                Console.WriteLine($"Email enviado para {this.To}.");
            }
            else
            {
                Console.WriteLine("Email não foi enviado, por favor verifique se todas as informações inseridas estão corretas!");
            }
        }
    }
}
