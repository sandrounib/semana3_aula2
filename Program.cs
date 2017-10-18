using System;

namespace semana3_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine(Convert.ToInt16(cpf[0]));
            if(cpf.Length != 11){
                Console.WriteLine("Cpf Inválido!");
            }
            else{

                int[] digito1 = new int[9] {10,9,8,7,6,5,4,3,2};
                int[] digito2 = new int[10] {11,10,9,8,7,6,5,4,3,2};
                string guarda9DigCpf, digitos;
                int soma = 0, resto = 0;

                guarda9DigCpf = cpf.Substring(0,9);
                //System.Console.WriteLine(tempcpf);
                for (int i = 0; i < 9; i++){
                    System.Console.WriteLine(guarda9DigCpf[i].ToString() + " * " + 
                    digito1[i] + " = " + Convert.ToInt16(guarda9DigCpf[i].ToString()) * digito1[i]);
                    soma += Convert.ToInt16(guarda9DigCpf[0]) * digito1[i];
                }
                
                resto = soma % 11;
                
                if (resto < 2){
                    resto =0;
                }
                else{
                    resto = 11 - resto;
                }

                digitos = resto.ToString();
                System.Console.WriteLine(digitos);

                //para pegar o segundo dito acrescento essas linhas 
                // note que zerei a soma e coloquei o tempcpf que são 9 mais digitos
                guarda9DigCpf = guarda9DigCpf + digitos;

                soma = 0;

                for (int i = 0; i < 10; i++){
                    System.Console.WriteLine(guarda9DigCpf[i] + " * " + 
                    digito2[i] + " = " + Convert.ToInt16(guarda9DigCpf[i].ToString()) * digito2[i]);
                    soma += Convert.ToInt16(guarda9DigCpf[i].ToString()) * digito2[i];
                }

                resto = soma % 11;
                
                if (resto < 2){
                    resto =0;
                }
                else{
                    resto = 11 - resto;
                }
                digitos = digitos + resto.ToString();
                if(cpf.EndsWith(digitos) == true){
                    System.Console.WriteLine("CPF VÁLIDO!");
                }
                else{
                    System.Console.WriteLine("CPF INVÁLIDO");
                }

                System.Console.WriteLine(digitos);
            }
            
        }
    }
}
