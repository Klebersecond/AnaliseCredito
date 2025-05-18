Console.Clear();

Console.Write("Qual valor de empréstimo você deseja ?:");

double valoremprestimo = double.Parse(Console.ReadLine()!);

Console.WriteLine($"valor de emprestimo solicitado é: {valoremprestimo:C}");

Console.WriteLine("Qual a sua renda mensal ?:");

double salario = double.Parse(Console.ReadLine()!);

Console.WriteLine($"{salario:C}");

Console.Write("Em quantas parecelas você deseja pagar ?:");

int parcelas = int.Parse(Console.ReadLine()!);


double valorparcela = valoremprestimo / parcelas;

Console.WriteLine($"Valor de cada parcela: {valorparcela:C}");

if (valorparcela > salario * 0.3) 
   { Console.WriteLine("Não autorizado!");
}

else {
    Console.Write("Aprovado!");
}
