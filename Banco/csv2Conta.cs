using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Banco.Contas;

namespace Banco
{
    public static class csv2Conta
    {
        public static string ParaString(this Conta c)
        {
            return $"{c.numero};{c.Titutar.Nome};{c.saldo}";
        }

        public static Conta ParaConta(this string Linha)
        {
            string[] partes = Linha.Split(';');
            Conta conta = new Conta(Numero: Convert.ToInt32(partes[0]), 
                Titular: partes[1], 
                Saldo: Convert.ToDouble(partes[2]));
       
            return conta;
        }

    }


}
