using System;

namespace Construtore_15_12_2
{
    public class Produto
    {
        public int Codigo{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public int Estoque{get;set;}
        
        public Produto(){
            
        }

        public Produto (int valor){
            Codigo = valor;
            
        }

        // public string ExibeTexto(){
        //     return "Esse metodo exibe o texto 'olá'";
        // }
        // public string ExibeTexto(string nome){
        //     return $"Esse metodo exibe o texto {nome}";
        // }
         public Produto(int codigo, string nome, string descricao, int estoque){
                Codigo = codigo;
                Nome = nome;
                Descricao = descricao;
                Estoque = estoque;

                Console.WriteLine("");

         }
            
        
    }
}