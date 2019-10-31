using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Pilha
{
    class Pilha
    {
        int inicio, fim, tamanho, qtdeElementos;
        int[] f = new int[100];

        public Pilha()
        {
            inicio = fim = -1;
            tamanho = 100;
            qtdeElementos = 0;
        }

        public bool EstaCheia() {
            if (qtdeElementos == tamanho - 1){
                return true;
            }
            return false;
        }

        public bool EstaVazia() {
            if (qtdeElementos == 0){
                return true;
            }
            return false;
        }

        public void Mostrar()
        {
            String elementos = "";
            for (int i = inicio; i <= fim; i++){
                 elementos += f[i] + " - ";
            }
            Console.WriteLine(elementos);
        }

        public void Inserir(int e){
            if (! EstaCheia()){
                if (inicio == -1){
                    inicio = 0;
                }
                fim++;
                f[fim] = e;
                qtdeElementos++;
            }
        }
     
        public void Remover() {
            if (! EstaVazia() ){
                fim--;
                qtdeElementos--;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pilha f = new Pilha();
            f.Inserir(10);
            f.Inserir(12);
            f.Inserir(30);
            f.Inserir(42);
            f.Inserir(50);
            f.Inserir(25);
            f.Inserir(8);
            f.Inserir(17);
            f.Remover();
            f.Mostrar();
            f.Inserir(50);
            f.Mostrar();

            Console.ReadLine();
        }
    }
}