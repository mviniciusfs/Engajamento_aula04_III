using System;
/*
3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;
*/

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine();
    Console.WriteLine ("Votação");
    Console.WriteLine();

    int voto = 0;
    bool newvoto = false;
    string votonovo;
    string vencedor = "";

    int jose = 0;
    int joana = 0;
    int roberto = 0;
    int branco = 0;
    int nulo = 0;

    do
    {
      Console.WriteLine();
      Console.Write("Escolha seu candidato: \n 33 - José Couve \n 25 - Joana Bravo \n 10 - Roberto Nove \n 0 - Voto em Branco \n 4 - Voto Nulo\n \nN° desejado: ");
      voto = int.Parse(Console.ReadLine());
      Console.WriteLine();

      if (voto == 33)
      {
        jose ++;
      }

      else if (voto == 25)
      {
        joana ++;
      }

      else if (voto == 10)
      {
        roberto ++;
      }

      else if (voto == 0)
      {
        branco ++;
      }

      else if (voto == 4)
      {
        nulo ++;
      }     

      Console.WriteLine("Deseja votar novamente? s/n");
      votonovo = Console.ReadLine();
      if (votonovo == "s")
      {
        newvoto = true;
      }

      else
      {
        newvoto = false;
      }
    }
    while(newvoto);

    if (jose > joana)
    {
      vencedor = "José Couve";
    }

    else if (joana > roberto)
    {
      vencedor = "Joana Bravo";
    }

    else if (roberto > joana)
    {
      vencedor = "Roberto Nove";
    }

    if (roberto == joana && roberto > jose || joana == jose && roberto > jose || jose == roberto && roberto > joana)
    {
      vencedor = "Haverá 2° Turno";
    }   

    Console.WriteLine();
    Console.WriteLine("--------------------");   

    if (vencedor == "")
    {
      Console.WriteLine("A T E N Ç Ã O\n\n Votação anulada, candidatos não receberam votos");
    }

    else
    {
      Console.WriteLine("Vencedor da Eleição\n{0}", vencedor);
    }


    Console.WriteLine();
    Console.WriteLine("--------Resultado dos votos--------");
    Console.WriteLine("Quantidade de votos nulos: {0}\nQuantidade de votos em branco: {1}\nJosé Couve: {2}\nJoana Bravo: {3}\nRoberto Nove: {4}", nulo, branco, jose, joana, roberto);

  }
}