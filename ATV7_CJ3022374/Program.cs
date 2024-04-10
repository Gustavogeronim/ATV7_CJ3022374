namespace ATV7_CJ3022374
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                do
                {

                    Console.WriteLine("=========MENU=========");
                    Console.WriteLine("0 - SAIR");
                    Console.WriteLine("1 - EX1");
                    Console.WriteLine("2 - EX2");
                    Console.WriteLine("3 - EX3");

                    opcao = int.Parse(Console.ReadLine());

                } while (opcao < 0 || opcao > 3);

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema!");
                        break;


                    case 1:
                        Console.WriteLine("Executando o ex1");

                        // Atividade 1
                        int n = 1, i;

                        Console.WriteLine("Digite um número:");
                        i = int.Parse(Console.ReadLine());


                        do
                        {
                            Console.WriteLine(n);
                            n++;
                        }
                        while (n <= i);
                        break;

                    case 2:
                        Console.WriteLine("Executando o ex2");
                        int r = 1, j;

                        Console.WriteLine("Digite um número:");
                        j = int.Parse(Console.ReadLine());

                        do
                        {
                            if (r == 1 || r % 2 == 0)
                                Console.WriteLine(r);
                            r++;
                        }
                        while (r <= j);

                        break;


                    case 3:
                        Console.WriteLine("Executando o ex3");
                        int p = 1000, l;

                        Console.WriteLine("Digite um número até 1000:");
                        l = int.Parse(Console.ReadLine());


                        if (p <= 1000)
                        {
                            do
                            {
                                if (p % 2 == 0)
                                    Console.WriteLine(p);
                                p--;

                            } while (p <= l);
                        }
                        else
                        {
                            Console.WriteLine("O número é maior que mil");
                        }

                        break;


                    case 4:
                        Console.WriteLine("Executando o ex3");

                        int valor = 0, n1, conta = 0;

                        do
                        {

                            Console.WriteLine("Digite um número");
                            n1 = int.Parse(Console.ReadLine());

                            valor += n1;
                            conta++;



                            if (n1 >= 0)
                            {
                                Console.WriteLine("O útimo número positivo é:{0}", n1);
                                Console.WriteLine("A soma dos números até agora é de", valor);

                            }
                            else if (n1 < 0)

                            {
                                Console.WriteLine("útimo número negativo digitado é:", n1);
                                Console.WriteLine("a soma dos números até agora é:", valor);
                            }
                            if (valor >= 200)
                            {
                                break;
                            }
                        } while (true);
                        break;

                    case 5:
                        Console.WriteLine("Executando o ex3");
                        break;

                }

            } while (opcao != 0);
        }
    }
}
