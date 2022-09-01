using System;

class Programa{
     public static void Main(string[] args){
        string nome;
         double anosempresa,salario;

        Console.Write("digite seu nome:");                                                                                                                                                                                                                                                                 
         nome= Console.ReadLine();
         
        Console.Write("digite o seu salario:");
         salario = double.Parse(Console.ReadLine());

        Console.Write("digite o tempo de empresa: ");
        anosempresa = double.Parse(Console.ReadLine());


        if(anosempresa <=3){
             salario = salario * 1.03;
             Console.WriteLine("seu novo salario e" + salario);
        }
        else if(anosempresa <= 10){
            salario = salario * 1.25;
            Console.WriteLine("seu novo salario e" + salario);
        }else if(anosempresa >= 10){
            salario = salario * 1.20;
            Console.WriteLine("seu novo salario e" + salario);
        }

             Console.WriteLine("pressione enter para sair...");
             Console.ReadLine();
   }
}
