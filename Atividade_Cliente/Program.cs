﻿using System;
namespace Atividade_Cliente
{
    class Program
    {
        static void Main (string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Informar (f) para Pessoa Física ou (j) para Pessoa Jurídica");
            string var_tipo = Console.ReadLine();

        //------- Pessoa Física -------

            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

// -------- Entrada de informações PF -------------

                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar valor da compra");
                val_pag = float.Parse(Console.ReadLine());

// -------- Cáculo do imposto PF -----------------


                pf.Pagar_Imposto(val_pag);

// -------- Impressão tabela final PF ----------

                Console.WriteLine("--------- Pessoa Física ---------");
                Console.WriteLine("Nome...........: " + pf.nome);
                Console.WriteLine("Endereço.......: " + pf.endereco);
                Console.WriteLine("CPF............: " + pf.cpf);
                Console.WriteLine("RG.............: " + pf.rg);
                Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto........: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar..: " + pf.total.ToString("C"));
            }
        //----------- Pessoa Jurídica --------------

            if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

        //-------- Entrade de informações PJ --------

                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar Inscrição Estadual:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor da compra:");
                val_pag = float.Parse(Console.ReadLine());

        // ------- Cálculo imposto PJ ---------------

                pj.Pagar_Imposto(val_pag);

        // ------- Impressão tabela final PJ --------

                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome...........: " + pj.nome);
                Console.WriteLine("Endereço.......: " + pj.endereco);
                Console.WriteLine("CNPJ...........: " + pj.cnpj);
                Console.WriteLine("IE.............: " + pj.ie);
                Console.WriteLine("Valor da Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar..: " + pj.total.ToString("C"));
            }
        }
    }
}
