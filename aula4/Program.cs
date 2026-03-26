using System;

class Program{
    
class Produto{

    public string nome;
    public double preco;
    public int quantidade;

    public void exibir(){
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preco: R$" + preco);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Valor de estoque: R$" + calcularValorTotal());
        Console.WriteLine("PrecoDesconto: R$" + aplicarDesconto(10).ToString("F2"));
        Console.WriteLine("Valor de estoque com desconto: R$" + (aplicarDesconto(10)* quantidade).ToString("F2"));
    }
    public void adicionarEstoque(int qnt){
        quantidade += qnt;
    }
    public void removerEstoque(int qnt){
        quantidade -= qnt;
    }
    public double calcularValorTotal(){
        return preco * quantidade;
    }
    public double aplicarDesconto(int qnt ){
        return preco - (preco * (qnt/100.0));
    }
}
static void Main(){
    Console.WriteLine("Hello, World!");
    Produto p = new Produto();

    p.nome = "Chocolate";
    p.preco = 5;
    p.quantidade = 10;

    p.adicionarEstoque(4);
    p.removerEstoque(2);

    p.exibir();
    }
}
