using System;
using System.Collections.Generic;
using System.Text;

namespace sistema
{
    class globais
    {
        public static string versao="1.0";

        public static Boolean logado = false;

        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        public static string nomeBanco = "bd_super_bem.db";

        public static string caminhoBanco=caminho+@"\banco\";

    }
}
