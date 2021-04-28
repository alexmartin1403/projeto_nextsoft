using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacaoNextSoft
{
    class ClienteValidacaoCpf
    {
        public bool ValidaCPF(string vrCPF)

        {
            //Retira ponto e traço do CPF se houver
            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");


            //Verifica se o CPF tem 11 digitos
            if (valor.Length != 11)

                return false;


            //Cria a variavel igual com valor true
            bool igual = true;

            
            for (int i = 1; i < 11 && igual; i++)

                if (valor[i] != valor[0])

                    igual = false;


            //Verifica se o CPF é 12345678909
            if (igual || valor == "12345678909")

                return false;


            //Cria variavel de vetor com cada número do CPF
            int[] numeros = new int[11];


            //Transforma os digitos do número do CPF em string
            for (int i = 0; i < 11; i++)

                numeros[i] = int.Parse(

                  valor[i].ToString());


            //Realiza alguns calculos para verificar se o CPF é valido
            int soma = 0;

            for (int i = 0; i < 9; i++)

                soma += (10 - i) * numeros[i];



            int resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[9] != 0)

                    return false;

            }

            else if (numeros[9] != 11 - resultado)

                return false;



            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += (11 - i) * numeros[i];



            resultado = soma % 11;



            if (resultado == 1 || resultado == 0)

            {

                if (numeros[10] != 0)

                    return false;

            }

            else

                if (numeros[10] != 11 - resultado)

                return false;



            return true;

        }
    }
}
