// See https://aka.ms/new-console-template for more information
Console.Write("Qual a quantidade de vitórias: ");
int vitorias = int.Parse(Console.ReadLine());

Console.Write("Qual a quantidade de derrotas: ");
int derrotas = int.Parse(Console.ReadLine());

int saldoVitorias = CalcularSaldoVitorias(vitorias, derrotas);
string nivel = DeterminaNivel(vitorias);

ExibeMensagem(saldoVitorias, nivel);

static int CalcularSaldoVitorias(int vitorias, int derrotas)
{
	return (vitorias - derrotas);
}

static string DeterminaNivel(int vitorias)
{
	if (vitorias < 10)
	{
		return "Ferro";
	}
	else if (vitorias >= 11 && vitorias <= 20)
	{
		return "Bronze";
	}
	else if (vitorias >= 21 && vitorias <= 50)
	{
		return "Prata";
	}
	else if (vitorias >= 51 && vitorias <= 80)
	{
		return "Ouro";
	}
	else if (vitorias >= 81 && vitorias <= 90)
	{
		return "Diamante";
	}
	else if (vitorias >= 91 && vitorias <= 100)
	{
		return "Lendário";
	}
	else // vitorias >= 101
	{
		return "Imortal";
	}
}

static void ExibeMensagem(int saldoVitorias, string nivel)
{
	Console.WriteLine($"O Herói tem de saldo de {saldoVitorias} e está no nível de {nivel}");
}