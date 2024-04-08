using BibliotecaFinanceira;

Console.WriteLine("1-CALCULAR CAPITAL\n2-CALCULAR MONTANTE\n3-CALCULAR TAXA\n4-CALCULAR TEMPO");
int escolha = Convert.ToInt32(Console.ReadLine());

string mont = "Informe o montante: ";
string tax = "Informe a taxa: ";
string temp = "Informe o tempo: ";
string capita = "Informe a capital: ";
double valorJuros = 0;
if (escolha == 1)
{
    Console.Write(mont);
    double montante = Convert.ToDouble(Console.ReadLine());

    Console.Write(tax);
    double taxa = Convert.ToDouble(Console.ReadLine());

    Console.Write(temp);
    double tempo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Valor da capital = " + CalculosFinanceiro.CalcularCapital(taxa, montante, tempo));
    valorJuros = CalculosFinanceiro.CalcularCapital(taxa, montante, tempo);
    Console.WriteLine("Juros simples = " + (montante - valorJuros));
}
else if (escolha == 2)
{
    Console.Write(capita);
    double capital = Convert.ToDouble(Console.ReadLine());

    Console.Write(tax);
    double taxa = Convert.ToDouble(Console.ReadLine());

    Console.Write(temp);
    double tempo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Valor do montante = " + CalculosFinanceiro.CalcularMontante(taxa,capital,tempo));
    valorJuros = CalculosFinanceiro.CalcularMontante(taxa, capital, tempo);

    Console.WriteLine("Juros simples = " + (valorJuros - capital));
}
else if (escolha == 3)
{
    Console.Write(mont);
    double montante = Convert.ToDouble(Console.ReadLine());

    Console.Write(capita);
    double capital = Convert.ToDouble(Console.ReadLine());

    Console.Write(temp);
    double tempo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Valor da taxa = " + CalculosFinanceiro.CalcularTaxa(capital,montante,tempo));

    Console.WriteLine("Juros simples = " + (montante - capital));
}
else if (escolha == 4)
{
    Console.Write(mont);
    double montante = Convert.ToDouble(Console.ReadLine());

    Console.Write(capita);
    double capital = Convert.ToDouble(Console.ReadLine());

    Console.Write(tax);
    double taxa = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Valor do tempo = " + CalculosFinanceiro.CalcularTempo(montante,capital,taxa));
    Console.WriteLine("Juros simples = " + (montante - capital));
}

Console.ReadKey();


