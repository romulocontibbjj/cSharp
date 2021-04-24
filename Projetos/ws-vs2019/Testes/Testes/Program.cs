using System;
using System.Collections.Generic;
using System.Globalization;

namespace Testes
{
    class Program
    {


        static double Pi = 3.14;

        static void Main(string[] args)
        {

            //T1();
            //T2();
            //bhaskara();
            //EntradaDeDadosMesmaLinha();
            //EntradaDeDados2();
            //ExercicioFixacao2();

            //TesteFuncoes1();

            //ExercicioSemClasses();
            //ExercicioComClasse();

            //ExercicioComClasse2();
            //ExercicioComClasse3();
            //ExercicioFixacaoComClasse1();
            //ExercicioFixacaoComClasse2();

            //ExercicioDeRaio();

            //ExercicioConverter();

            //ExercicioConstrutores();

            //ExercicioEncapsulamento();

            //ExercicioEncapsulamento();

            //ExercicioEncapsulamento2();
            //ExercicioEncapsulamento3();

            //ExercicioFixacaoEncapsulamento();

            //ExVetores();
            //ExVetores2();

            //ExercicioFixacaoVetores();

            //ExercicioMudancaParametros();
            //ModificadorDeParametros_Ref_Out();

            //ExLacoEach();

            //ExLista();

            //ExercicioListaClasse();

            //Matrizes();

            //ExercioMatriz1();

            //ExercioMatriz2();

            //TrabalhandoComStrings();

            //TrabDatas();

            //AulaTimeSpan();
            //AulaTimeSpan2();

            AulaDateTimeKind();

        }

        public static void T2()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 32;
            int codigo = 5290;
            String genero = "M";

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é R${1:F2}", produto1, preco1);
            Console.WriteLine(produto1 + ", cujo preço é de R$" + preco1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");

        }

        public static void T1()
        {
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";



            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }

        public static void bhaskara()
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

        public static void EntradaDeDadosMesmaLinha()
        {
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Linha {i}: {vet[i]}");
            }

        }

        public static void EntradaDeDados2()
        {

            Console.WriteLine("EntradaDeDados2");

            //• Ler um número inteiro
            /*• Ler um caractere
            • Ler um número double
            • Ler um nome(única palavra), sexo
            (caractere F ou M), idade(inteiro)
            e altura(double) na mesma linha,
            armazenando - os em quatro
            variáveis com os devidos tipos*/

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }

        public static void ExercicioFixacao2()
        {

            Console.WriteLine("ExercicioFixacao2");

            string nomeCompleto = Console.ReadLine();
            int qtdQuartos = int.Parse(Console.ReadLine());
            double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] frase = Console.ReadLine().Split(' ');
            string ultimoNome = frase[0];
            int idade = int.Parse(frase[1]);
            double altura = double.Parse(frase[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos.ToString());
            Console.WriteLine(valorProduto.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade.ToString());
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }

        public static void ExercicioFixacao2Prof()
        {
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }

        static void TesteFuncoes1()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);

        }


        static void ExercicioSemClasses()
        {
            double xA, xB, xC;
            double yA, yB, yC;

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            xA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            yA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double xArea = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double yArea = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X:" + xArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y:" + yArea.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Maior Área: " + (xArea > yArea ? xArea : yArea).ToString("F4", CultureInfo.InvariantCulture));





        }

        static void ExercicioComClasse()
        {
            Triangulo X, Y;
            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            X.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            Y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (X.A + X.B + X.C) / 2.0;
            double xArea = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));

            p = (Y.A + Y.B + Y.C) / 2.0;
            double yArea = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));

            Console.WriteLine("Área de X:" + xArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y:" + yArea.ToString("F4", CultureInfo.InvariantCulture));

        }

        static void ExercicioComClasse2()
        {
            Triangulo X, Y;
            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            X.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            Y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = X.Area();
            double areaY = Y.Area();

            Console.WriteLine("Área de X:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y:" + areaY.ToString("F4", CultureInfo.InvariantCulture));
        }

        static void ExercicioComClasse3()
        {
            Produto Pr = new Produto();
            int Qtd = 0;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("NOME: ");
            Pr.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            Pr.Preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            Pr.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(Pr.ToString());

            Console.Write("Digite o número de produtos a serem adicionados ao estoque:");
            Qtd = int.Parse(Console.ReadLine());
            Pr.AdicionarProdutos(Qtd);
            Console.WriteLine(Pr.ToString());

            Console.Write("Digite o número de produtos a serem removidos do estoque:");
            Qtd = int.Parse(Console.ReadLine());
            Pr.RemoverProdutos(Qtd);
            Console.WriteLine(Pr.ToString());

        }

        static void ExercicioFixacaoComClasse1()
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a Largura e Altura:");
            ret.Largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExercicioFixacaoComClasse2()
        {
            Funcionario func = new Funcionario();
            double reajuste = 0;

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.Write("Funcionário: " + func.ToString());
            Console.WriteLine("");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            reajuste = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(reajuste);
            Console.Write("Funcionário: " + func.ToString());



        }

        static void ExercicioDeRaio()
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do Raio:");
            double raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double circ2 = calc.Circunferencia(raio);
            double circ3 = Calculadora2.Circunferencia2(raio);

            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferência2: " + circ2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferência3: " + circ3.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double xraio)
        {
            return 2.0 * Pi * xraio;
        }

        static double Volume(double r)
        {
            //Math.Pow(r, 3) -> raio ao cubo
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

        static void ExercicioConverter()
        {
            Console.Write("Qual é a cotação do Dólar? ");
            double ValorDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorSerPago = ConversorDeMoeda.ValorEmReais(ValorDolar, qtd);
            Console.Write("Valor a ser pago em Reais: " + valorSerPago.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExercicioConstrutores()
        {
            //Produto2 Pr = new Produto2();
            int Qtd = 0;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("NOME: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto2 Pr = new Produto2(nome, preco, quantidade);

            Console.WriteLine(Pr.ToString());

            Console.Write("Digite o número de produtos a serem adicionados ao estoque:");
            Qtd = int.Parse(Console.ReadLine());
            Pr.AdicionarProdutos(Qtd);
            Console.WriteLine(Pr.ToString());

            Console.Write("Digite o número de produtos a serem removidos do estoque:");
            Qtd = int.Parse(Console.ReadLine());
            Pr.RemoverProdutos(Qtd);
            Console.WriteLine(Pr.ToString());
        }

        static void ExercicioEncapsulamento()
        {
            Produto3 p = new Produto3("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
        }

        static void ExercicioEncapsulamento2()
        {
            Produto4 p = new Produto4("TV", 500.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);

        }

        static void ExercicioEncapsulamento3()
        {
            Produto5 p = new Produto5("TV", 500.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);

        }

        static void ExVetores()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double avg = soma / n;

            Console.WriteLine("Média de Altura: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExVetores2()
        {
            int n = int.Parse(Console.ReadLine());
            ProductVetores[] pr = new ProductVetores[n];
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                string name;
                double preco = 0.0;

                Console.Write("Digite o Nome do Produto: ");
                name = Console.ReadLine();
                Console.Write("Digite o Valor do Produto: ");
                preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += preco;
                pr[i] = new ProductVetores { Name = name, Preco = preco };
            }

            double avg = soma / n;

            Console.WriteLine("Valor Médio dos Produtos: R$" + avg.ToString("F2", CultureInfo.InvariantCulture));

        }

        static void ExercicioFixacaoVetores()
        {
            Console.Write("Quantos quartos serão alugados? -> ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] vect = new Estudante[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }

        static void ExercicioMudancaParametros()
        {
            int resultado = Calculator.Sum(new int[] { 2, 3, 4 });
            Console.WriteLine(resultado);

            //Depois de Colocar o PARAMS
            int resultado2 = Calculator.Sum(10, 20, 30);
            Console.WriteLine(resultado2);
        }

        static void ModificadorDeParametros_Ref_Out()
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }

        static void ExLacoEach()
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        static void ExLista()
        {
            //System.Collections.Generic;

            List<string> lista = new List<string>();

            List<string> lista2 = new List<string>() { "Maria", "Alex" };

            List<string> lista3 = new List<string>();

            lista3.Add("Maria");
            lista3.Add("Alex");
            lista3.Add("Bob");
            lista3.Add("Anna");

            lista3.Insert(2, "Marco");


            foreach (string obj in lista3)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine(lista3.Count);

            string s1 = lista3.Find(Test);

            Console.WriteLine("First 'A': " + s1); //Primeiro Cara com Letra A

            string s2 = lista3.Find(x => x[0] == 'A'); //expressão Lambda
            Console.WriteLine("First 'A': " + s2); //Primeiro Cara com Letra A

            string s3 = lista3.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s3); //Primeiro Cara com Letra A

            int posIni = lista3.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição First 'A': " + posIni);

            int posLast = lista3.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição Last 'A': " + posLast);

            Console.WriteLine("-----------------------");

            List<string> listaAuxFiltros = lista3.FindAll(x => x.Length == 5);

            foreach (string xList in listaAuxFiltros)
            {
                Console.WriteLine(xList);
            }

            Console.WriteLine("-----------------------");
            //Remover elementos
            lista3.Remove("Alex");

            foreach (string obj in lista3)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine("-----------------------");
            lista3.RemoveAll(x => x[0] == 'M');
            foreach (string obj in lista3)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine("#######################");
            lista3.Clear();
            lista3.Add("Maria");
            lista3.Add("Alex");
            lista3.Add("Bob");
            lista3.Add("Anna");
            lista3.Insert(2, "Marco");
            foreach (string obj in lista3)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@");
            //Remove por Posição
            lista3.RemoveAt(2);
            foreach (string obj in lista3)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine("#######################");
            lista3.Clear();
            lista3.Add("Maria");
            lista3.Add("Alex");
            lista3.Add("Bob");
            lista3.Add("Anna");
            lista3.Insert(2, "Marco");

            lista3.RemoveRange(2, 2);

            foreach (string obj in lista3)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }

        static void ExercicioListaClasse()
        {
            Console.Write("Quantos Funcionários quer cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<ListaFunc> listaFunc = new List<ListaFunc>();

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Funcionário #" + (i + 1) + ": ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write("SALÁRIO: R$ ");
                double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //ListaFunc func = new ListaFunc(id, nome, salario);
                listaFunc.Add(new ListaFunc(id, nome, salario));
                Console.WriteLine("");
            }

            Console.Write("Digite o Código do Funcionário para dar o Reajuste: ");
            int idSearch = int.Parse(Console.ReadLine());
            Console.Write("Digite o % do Reajuste: ");
            double reajuste = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ListaFunc func = listaFunc.Find(x => x.ID == idSearch);
            if (func != null)
            {
                func.Reajuste(reajuste);
            }
            else
            {
                Console.WriteLine("Funcionário Inexistente!");
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Lista de Funcionários: ");
            foreach (ListaFunc obj in listaFunc)
            {
                Console.WriteLine(obj.ToString());
            }

        }


        static void Matrizes()
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Total de Registros: " + mat.Length); //Total de Registros
            Console.WriteLine("Linhas: " + mat.Rank); // Total Linhas
            Console.WriteLine("linhas: " + mat.GetLength(0)); // Total de linhas
            Console.WriteLine("Colunas: " + mat.GetLength(1)); // Total de Colunas

        }

        static void ExercioMatriz1()
        {
            Console.Write("Entre com o Tamanho da Matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int x = 0; x < n; x++)
            {
                //Linha
                Console.Write("Digite os Dados da Linha #" + x + ": ");
                string[] s = Console.ReadLine().Split(' ');
                //Coluna
                for (int y = 0; y < n; y++)
                {
                    mat[x, y] = int.Parse(s[y]);
                }
            }

            //Mostrar a Diagonal
            string valdiagonal = "";
            for (int d = 0; d < n; d++)
            {
                valdiagonal += (mat[d, d].ToString()) + " ";

            }
            Console.WriteLine("Valor Diagonal: " + valdiagonal.ToString());
            Console.WriteLine("");

            int count = 0;
            for (int ilinha = 0; ilinha < n; ilinha++)
            {
                for (int coluna = 0; coluna < n; ++coluna)
                {
                    if (mat[ilinha, coluna] < 0)
                    {
                        count += 1;
                    }
                }
            }

            Console.WriteLine("Números Negativos: " + count.ToString());

        }

        static void ExercioMatriz2()
        {
            Console.Write("Entre com a Quantidade de Linhas e Colunas: ");
            string[] vlineCol = Console.ReadLine().Split(' ');
            int M = int.Parse(vlineCol[0]);
            int N = int.Parse(vlineCol[1]);

            int[,] matriz = new int[M, N];

            for (int ilinhas = 0; ilinhas < M; ilinhas++)
            {
                Console.Write("Digite os Dados da Linha #" + ilinhas.ToString() + ": ");
                string[] sDados = Console.ReadLine().Split(' ');

                for (int icols = 0; icols < N; icols++)
                {
                    matriz[ilinhas, icols] = int.Parse(sDados[icols]);
                }
            }

            Console.WriteLine("Matriz Carregada");
            Console.WriteLine("");

            Console.Write("Digite o número a ser Localizado: ");
            int ibusca = int.Parse(Console.ReadLine());

            //Busca Número
            for (int bLinha = 0; bLinha < M; bLinha++) //Linha
            {
                for (int bcoluna = 0; bcoluna < N; bcoluna++)
                {
                    if (matriz[bLinha, bcoluna].Equals(ibusca))
                    {
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("Position " + bLinha.ToString() + ", " + bcoluna.ToString() + ": ");
                        //Esquerda
                        if (bcoluna > 0)
                        {
                            Console.WriteLine("Left: " + matriz[bLinha, ((bcoluna - 1))].ToString());
                        }

                        //Direita
                        if (bcoluna < (matriz.GetLength(1) - 1))
                        {
                            Console.WriteLine("Right: " + matriz[bLinha, ((bcoluna + 1))].ToString());
                        }

                        //Acima
                        if (bLinha > 0)
                        {
                            Console.WriteLine("Top: " + matriz[((bLinha - 1)), bcoluna].ToString()); ;
                        }

                        //Abaixo
                        if (bLinha < (matriz.GetLength(0) - 1))
                        {
                            Console.WriteLine("Down: " + matriz[((bLinha + 1)), bcoluna].ToString()); ;
                        }




                    }
                }
            }

        }

        static void TrabalhandoComStrings()
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }

        static void TrabDatas()
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 35, 31);
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2018, 11, 25, 20, 35, 31, 500);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15 13:05:08");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("20/04/2025 14:55:09");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("20210101150930", "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);


            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();
            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string s8 = d1.ToString("yyyymmddHHmmss");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(s8);
            Console.WriteLine("------------------------------------");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            /*DateTime x = ...
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);*/

            Console.WriteLine("***************************");
            DateTime dt1 = new DateTime(2021, 04, 20);
            DateTime dt2 = new DateTime(2021, 04, 23);

            TimeSpan tDif = dt2.Subtract(dt1);

            DateTime dataIni = DateTime.Parse("23/04/2021 17:00:00");
            DateTime dataFim = DateTime.Parse("23/04/2021 17:09:00");
            TimeSpan tDif2 = dataFim.Subtract(dataIni);
            Console.WriteLine("Tempo em Minutos: " + tDif2.TotalMinutes);
            Console.WriteLine("Tempo em Segundos: " + tDif2.TotalSeconds);

            Console.WriteLine(tDif);

        }


        static void AulaTimeSpan()
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine("----------------------------");
            TimeSpan teste1 = TimeSpan.FromDays(1.5);
            TimeSpan teste2 = TimeSpan.FromHours(1.5);
            TimeSpan teste3 = TimeSpan.FromMinutes(1.5);
            TimeSpan teste4 = TimeSpan.FromSeconds(1.5);
            TimeSpan teste5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan teste6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(teste1);
            Console.WriteLine(teste2);
            Console.WriteLine(teste3);
            Console.WriteLine(teste4);
            Console.WriteLine(teste5);
            Console.WriteLine(teste6);
        }

        static void AulaTimeSpan2()
        {
            TimeSpan Teste1 = new TimeSpan(DateTime.Now.Ticks);

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("---------------------");
            TimeSpan t = new TimeSpan(2, 0, 0, 0, 0);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("---------------------------");

            

            TimeSpan t1calc = new TimeSpan(1, 30, 10);
            TimeSpan t2Calc = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1calc.Add(t2Calc);
            Console.WriteLine(sum);

            TimeSpan Teste2 = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan TotalExec = Teste2.Subtract(Teste1);

            Console.WriteLine("Exec.: " + TotalExec.TotalMilliseconds);


            TimeSpan mult = t2Calc.Multiply(2);
            Console.WriteLine(mult);

            TimeSpan div = t2Calc.Divide(2);
            Console.WriteLine(div);
        }

        static void AulaDateTimeKind()
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind : " + d1.Kind);
            Console.WriteLine("d1 local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
        }

    }
}
