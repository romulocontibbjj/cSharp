using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            //Exercicio8();
            ExercicioDeFixacao();
        }

        static void Exercicio1()
        {
            string sourcePath = @"C:\tmp\file1.txt";
            string targetPath = @"C:\tmp\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                //fileinfo.CopyTo(targetPath.ToString());

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line.ToString());
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }


        }

        static void Exercicio2()
        {
            string path = @"C:\tmp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

        }

        static void Exercicio3()
        {
            string path = @"C:\tmp\file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
        }

        static void Exercicio4()
        {
            string path = @"C:\tmp\file1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Aconteceu um erro");
                Console.WriteLine(e.Message);
            }

        }

        static void Exercicio5()
        {
            string path = @"C:\tmp\file1.txt";

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Aconteceu um erro");
                Console.WriteLine(e.Message);
            }
        }

        
        static void Exercicio6() //Escrita de Daodos
        {
            string sourcepath = @"C:\tmp\file1.txt";
            string targetpath = @"C:\tmp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e )
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
                
            }
        }

        static void Exercicio7()//Operações com pastas
        {
            string path = @"c:\tmp\MyFolder";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);
                //or var folders = Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                //ver arquivos
                Console.WriteLine("Files:");
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach(string file in files)
                {
                    Console.WriteLine(file);
                }

                //Criar Pasta
                if (!Directory.Exists(path + "\\newFolder2"))
                {
                    Directory.CreateDirectory(path + "\\newFolder2");
                }
                



            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }

        static void Exercicio8()//Path
        {
            string path = @"C:\Tmp\MyFolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: "+ Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: "+ Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: "+ Path.GetExtension(path));
            Console.WriteLine("GetFullPath: "+ Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: "+ Path.GetTempPath());
        }

        static void ExercicioDeFixacao()
        {
            string path = @"C:\Tmp\MyFolder\file.csv";
            string outPath =@"C:\Tmp\MyFolder\out\file.csv";

            if (!Directory.Exists(Path.GetDirectoryName(outPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
            }

            List<string> listaProdutos = new List<string>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string nome = line[0];
                    double valor = Double.Parse(line[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(line[2]);

                    Console.WriteLine("Produto: " + nome + ", Valor: " + valor.ToString("F2", CultureInfo.InvariantCulture) +
                                    ", Quantidade: " + quantidade);

                    listaProdutos.Add(nome + "," + (valor * quantidade).ToString("F2", CultureInfo.InvariantCulture) );

                }
            }

            Console.WriteLine("");
            Console.WriteLine("Lista de Produtos");
            foreach (string s in listaProdutos)
            {
                Console.WriteLine(s);
            }



        }
    }
}
