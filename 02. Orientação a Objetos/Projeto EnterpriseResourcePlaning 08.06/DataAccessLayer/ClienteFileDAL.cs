using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClienteFileDAL
    {
        public string Cadastrar(Cliente cliente)
        {
            try
            {
                //Dentro do bloco try, botamos todas as linhas que podem
                //disparar exceptions!
                File.WriteAllText(cliente.CPF + ".txt", cliente.ToString());
                return "Cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                //Se exceptions forem disparadas, o bloco catch é executado e 
                //a variável "ex" ganha os detalhes desta exception, podendo
                //escrever a mensagem da exception em um log de erro.
                File.AppendAllText("log.txt", ex.Message + " às " + DateTime.Now);
                return "Sistema encontrou erros. Contate o administrador.";
            }
        }

        public bool Exists(Cliente cliente)
        {
            return File.Exists(cliente.CPF + ".txt");
        }

    }
}
