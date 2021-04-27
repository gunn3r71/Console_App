﻿using System;

namespace Componentes
{
    public class Ferramentas
    {
        internal static string testeInterno()
        {
            return "Aqui funciona";
        }

        public static string testePublico()
        {
            return "Aqui funciona";
        }   


        /// <summary>
        /// Função de validação de email básica
        /// </summary>
        /// <param name="email">Email a ser validado</param>
        /// <returns>booleano</returns>
        public static bool validaEmail(string email)
        {
            if (email.Contains('@') && email.EndsWith(".com") || email.EndsWith(".com.br"))
            {
                return true;
            }
            return false;
        }
    }
}