using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int lcr, lcm, lm, lm2, lm3;
            lcr = 300; lcm = 200; lm = 0; lm2 = 0;
            Caminhao[] truck = new Caminhao[lcm];
            Carro[] car = new Carro[lcr];

            bool l;
            l = true;

            for (lm3 = 0; lm3 < (lm + 1); lm3++) {
                truck[lm3].placa = "";
            }
            for (lm3 = 0; lm3 < (lm2 + 1); lm3++){
                car[lm3].apelido = "";
            }
            while (l == true)
            {
                string es;
                menu();
                es = Console.ReadLine();
                switch (es)
                {
                    case "1":
                        int lp;
                        if (lm < 300)
                        {
                            c();
                            for (lp = 0; lp < lcr; lp++)
                            {
                                if (car[lp].apelido == "")
                                {
                                    string d, ve;
                                    d = "digite ";
                                    ve = "carro";

                                    Console.WriteLine("\n\n***cadastrar carro***\n\n");
                                    Console.WriteLine(d + "o modelo do " + ve + ":"); string m = Console.ReadLine();
                                    Console.WriteLine(d + "o nome do fabricante do " + ve + ":"); string f = Console.ReadLine();
                                    Console.WriteLine(d + "a cor do " + ve + ":"); string c = Console.ReadLine();
                                    Console.WriteLine(d + "o ano de lançamento do " + ve + ":"); int a = int.Parse(Console.ReadLine());
                                    Console.WriteLine(d + "o número de porta do " + ve + ":"); int np = int.Parse(Console.ReadLine());
                                    Console.WriteLine(d + "a capacidade de mala do " + ve + "(não digite o kg):"); int cp = int.Parse(Console.ReadLine());
                                    Console.WriteLine("responda " + ve + " possui bagageiro:"); string r = Console.ReadLine();

                                    car[lp].modelo = m; car[lp].fabricante = f; car[lp].cor = c;
                                    car[lp].ano = a; car[lp].nporta = np; car[lp].cpmala = cp; car[lp].bag = r;
                                    lm++;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            c();
                            Console.WriteLine("não ha vagas para cadastrar carro, recomendado remover outro");
                        }
                        break;

                    case "2":
                        if (lm2 < 200)
                        {
                            for (lp = 0; lp < lcm; lp++)
                            {
                                c();
                                if (truck[lp].placa == "")
                                {
                                    string d, ve;
                                    d = "digite ";
                                    ve = "caminhão";

                                    Console.WriteLine("\n\n***cadastrar carro***\n\n");
                                    Console.WriteLine(d + "o modelo do " + ve + ":"); string m = Console.ReadLine();
                                    Console.WriteLine(d + "o nome do fabricante do " + ve + ":"); string f = Console.ReadLine();
                                    Console.WriteLine(d + "a cor do " + ve + ":"); string c = Console.ReadLine();
                                    Console.WriteLine(d + "o ano de lançamento do " + ve + ":"); int a = int.Parse(Console.ReadLine());
                                    Console.WriteLine(d + "o número de porta do " + ve + ":"); int np = int.Parse(Console.ReadLine());
                                    Console.WriteLine(d + "o numero de eixos do " + ve + ":"); int ne = int.Parse(Console.ReadLine());
                                    Console.WriteLine(d + "a peso maximo do " + ve + " aguenta(não digite o kg):"); int cp = int.Parse(Console.ReadLine());
                                    Console.WriteLine(d + "a placa do " + ve + ":"); string r = Console.ReadLine();

                                    truck[lp].modelo = m; truck[lp].fabricante = f; truck[lp].cor = c;
                                    truck[lp].ano = a; truck[lp].nporta = np; truck[lp].neixo = ne; truck[lp].pesom = cp; truck[lp].placa = r;
                                    lm2++;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            c();
                            Console.WriteLine("não ha vagas para cadastrar caminhão, recomendado remover outro");
                        }
                        break;

                    case "3":
                        c();
                        string res;
                        Console.WriteLine("digite uma placa:");
                        res = Console.ReadLine();
                        for (lp = 0; lp < lcm; lp++)
                        {
                            if (truck[lp].placa == res)
                            {
                                Console.WriteLine("carro {0}\n{1}", (lp + 1), car[lp].ToString());
                                break;
                            }
                            else
                            {

                                continue;
                            }
                        }
                        Console.WriteLine("digite 0 para voltar para o menu");
                        res = Console.ReadLine();
                        if (res == "0")
                        {
                            c();
                        }
                        else
                        {
                            c();
                            Console.WriteLine("se vai para esse menu do mesmo jeito :)");
                        }
                        break;

                    case "4":
                        c();
                        Console.WriteLine("digite um modelo:");
                        res = Console.ReadLine();
                        for (lp = 0; lp < lcm; lp++)
                        {
                            if (truck[lp].modelo == res)
                            {
                                Console.WriteLine("carro {0}\n{1}", (lp + 1), car[lp].ToString());
                                break;
                            }
                            else
                            {

                                continue;
                            }
                        }
                        Console.WriteLine("digite 0 para voltar para o menu");
                        res = Console.ReadLine();
                        if (res == "0")
                        {
                            c();
                        }
                        else
                        {
                            c();
                            Console.WriteLine("se vai para o menu do mesmo jeito :)");
                        }
                        break;

                    case "5":
                        c();
                        Console.WriteLine("digite um cor:");
                        res = Console.ReadLine();
                        for (lp = 0; lp < lcm; lp++)
                        {
                            if (car[lp].cor == res)
                            {
                                Console.WriteLine("carro {0}\n{1}", (lp + 1), car[lp].ToString());
                                break;
                            }
                            else
                            {

                                continue;
                            }
                        }
                        Console.WriteLine("digite 0 para voltar para o menu");
                        res = Console.ReadLine();
                        if (res == "0")
                        {
                            c();
                        }
                        else
                        {
                            c();
                            Console.WriteLine("se vai para o menu do mesmo jeito :)");
                        }
                        break;

                    case "6":
                        c();
                        Console.WriteLine("\n\n***Carros***\n\n");
                        for (lp = 0; lp < lcr; lp++)
                        {
                            Console.WriteLine("{0}-carro:\n{1}\n", (lp + 1), car[lp].ToString());
                        };
                        Console.WriteLine("digite 0 para voltar para o menu");
                        res = Console.ReadLine();
                        if (res == "0")
                        {
                            c();
                        }
                        else
                        {
                            c();
                            Console.WriteLine("se vai para o menu do mesmo jeito :)");
                        }
                        break;

                    case "7":
                        c();
                        Console.WriteLine("\n\n***Caminhão***\n\n");
                        for (lp = 0; lp < lcm; lp++)
                        {
                            Console.WriteLine("{0}-Caminhão:\n{1}", (lp + 1), truck[lp].ToString());
                        };
                        Console.WriteLine("digite 0 para voltar para o menu");
                        res = Console.ReadLine();
                        if (res == "0")
                        {
                            c();
                        }
                        else
                        {
                            c();
                            Console.WriteLine("se vai para o menu do mesmo jeito :)");
                        }
                        break;

                    case "0":

                        ex();
                        break;

                    default:
                        c();
                        Console.WriteLine("digite um valor válido");
                        l = true;
                        break;
                };
                Console.ReadKey();
            }
        }
        static void c()
        {
            Console.Clear();
        }
        static void ex()
        {
            Environment.Exit(1);
        }
        static void menu()
        {
            string p;
            p = "para ";

            Console.WriteLine("\n\n***Menu Consensionaria***\n");
            Console.WriteLine("Digite:\n");
            Console.WriteLine("1-" + p + "Cadastro de Carro\n2-" + p + "Cadastro de Caminhão\n3-" + p + "Consulta por placa\n4-" + p + "Consultar Caminhão por modelo/marca");
            Console.WriteLine("5-" + p + "Consultar Carro por cor\n6-" + p + "Exibir todos os Carros cadastrados\n7-" + p + "Exibir todos os Caminhões cadastrados\n0-" + p + "sair");
        }
    }
    public class Veiculo
    {
        public string modelo;
        public string fabricante;
        public string cor;
        public int ano;
        public int nporta;

        public Veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.cor = null;
            this.ano = 0;
            this.nporta = 0;
        }
        public Veiculo(string modelo, string fabricante, string cor, int ano, int nporta)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.cor = cor;
            this.ano = ano;
            this.nporta = nporta;
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Nporta
        {
            get { return nporta; }
            set { nporta = value; }
        }
        public override string ToString()
        {
            return string.Format("Modelo: {0}\nFabricante: {1}\nAno: {2}\nCor: {3}\nNúmero de portas: {4}\n", modelo, fabricante, ano, cor, nporta);
        }
    }
    public class Carro : Veiculo
    {
        public int cpmala;
        public string apelido;
        public string bag;

        public Carro()
            : base()
        {
            this.cpmala = 0;
            this.apelido = null;
            this.bag = null;
        }
        public Carro(string modelo, string fabricante, string cor, int ano, int nporta, int cpmala, string bag, string apelido)
            : base(modelo, fabricante, cor, ano, nporta)
        {
            this.cpmala = cpmala;
            this.apelido = apelido;
            this.bag = bag;
        }
        public int Cpmala
        {
            get { return cpmala; }
            set { cpmala = value; }
        }
        public string Bag
        {
            get { return bag; }
            set { bag = value; }
        }
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}Capacidade do porta malas: {1} kg\nBagajeiro: {2}", base.ToString(), cpmala, bag, apelido);
        }
    }
    public class Caminhao : Veiculo
    {
        public int neixo;
        public double pesom;
        public string placa;

        public Caminhao()
            : base()
        {
            this.neixo = 0;
            this.pesom = 0;
            this.placa = null;
        }
        public Caminhao(string modelo, string fabricante, string cor, int ano, int nporta, int neixo, double pesom, string placa)
            : base(modelo, fabricante, cor, ano, nporta)
        {
            this.neixo = neixo;
            this.pesom = pesom;
            this.placa = placa;
        }
        public int Neixo
        {
            get { return neixo; }
            set { neixo = value; }
        }
        public double Pesom
        {
            get { return pesom; }
            set { pesom = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}Número de eixos: {1}\nPeso Máximo de carga: {2} kg\nPlaca: {3}", base.ToString(), neixo, pesom, placa);
        }
    }
}
