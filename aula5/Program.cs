using System;

public class Livro{
    public string titulo;
    public string autor;
    public int ano;

    public void mostrarLivro(){
        Console.WriteLine("Titulo: " + titulo + " | " + "Autor: " + autor + " | " + "Ano: " + ano + "\n\n\n");
    }
}
public class Emprestimo{
    public string nome;
    public Livro Livro;
    public string dataEmprestimo;
    public string dataDevolucao;

    public void mostrarDados(){
        Console.WriteLine("EMPRESTIMO!");
        Console.WriteLine($"Livro: {Livro.titulo} | Autor: {Livro.autor} | Data; {Livro.ano}");
        Console.WriteLine($"Nome: {nome} - Data de Emprestimo: {dataEmprestimo} / Data de Devolucao: {dataDevolucao}");
    }
}
public class Veiculo{
    public string placa;
    public string modelo;
    public string cor;
}
public class Motorista{
    public string nome;
    public string habilitacao;
    public Veiculo Veiculo;

    public void apresentarMotorista(){
        Console.WriteLine(nome + "! - Habilitacao: " + habilitacao);
        Console.WriteLine($"PLACA VEICULO: {Veiculo.placa} | MODELO VEICULO: {Veiculo.modelo} | COR VEICULO: {Veiculo.cor}\n\n");
    }
}
class Program{
    public static void Main(string[] args){
        Veiculo carro = new Veiculo();
        carro.placa = "AU976SD3";
        carro.modelo = "Carristico";
        carro.cor = "verde Radioativo";

        Motorista ronaldo = new Motorista();
        ronaldo.nome = "Ronaldo";
        ronaldo.habilitacao = "AB";
        ronaldo.Veiculo = carro;
        ronaldo.apresentarMotorista();

        Livro l1 = new Livro();
        l1.titulo = "O Espreitador";
        l1.autor = "Daniel Hartman";
        l1.ano = 2020;

        //l1.mostrarLivro();

        Emprestimo num1 = new Emprestimo();
        num1.nome = "Luana";
        num1.Livro = l1;
        num1.dataEmprestimo = "07/04/2026";
        num1.dataDevolucao = "07/04/2026";

        num1.mostrarDados();
    }
}