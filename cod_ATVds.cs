using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
        static void cwt(string text){
            Console.WriteLine(text);
        }
        static void menu(){
            string n,t;
            n="\n\n";
            t="\t\t";
            cwt("\tprograma 1");
            cwt(n+t+"Menu\n");
            cwt("\tDigite"+n);
            cwt("\t1) Para escrever uma mesagem para ser lido pelo 2 programa");
            cwt("\t2) Ler a mesagem feita pelo 2 programa");
            cwt("\t0) sair");
            swt(Console.ReadLine());
        }
        static void exit(){
            Environment.Exit(0);
        }
        static void swt(string res){
            c();
            switch(res){
                case "1":
                    cwt("Escreva sua mensagem amigo (você será mandado para o menu logo em seguida)");
                    gravar(Console.ReadLine());
                    menu();
                break;
                
                case "2":
                    int ver = ver();
                    string ler = ler();
                    if(ver == 0){
                        cwt("faça a mensagem no programa 2 primeiro");
                        menu();
                    }else(
                        cwt("retorne para o menu digitando 11");
                        cwt("feche o programa digitando 0");
                        cwt("\n\n\n\n\t\t"+ler);
                        swt(Console.ReadLine());
                    );
                break;
                
                case "0":
                    exit();
                break;
                
                case "11":
                    menu();
                break;
                
                default:
                    cwt("Digite algo valido");
                    menu();
                break;
            }
        }
        static void c()
        {
            Console.Clear();
        }
        static void gravar(string res)
        {
            StreamWriter wr = new StreamWriter(@"Exercicio1", true);
            wr.WriteLine(res);
            wr.Close();
        }
        static string ler()
        {
            StreamReader rd = new StreamReader();
            while(!rd.EndOfStream){
                string linha = rd.ReadLine();
            }
            rd.Close();
            return linha;
        }
        static int ver(){
            int a
            if (!File.Exists(@"Exercio2.bin")) {
                a = 0;
            }else{
                a = 1;
            }
            return a;
        }
    }
}
