// constantes
using System.ComponentModel.DataAnnotations;

const int PRIMEIRO_ALUNO = 218;
const int ULTIMO_ALUNO = 233;

// variáveis
int quantidadeAlunos;
int alunoSorteado;
string nomeAluno;
string alunosSorteados = "";


// perguntar a quantidade de alunos a sortear
quantidadeAlunos = RecolheInteiro("Quantidade de alunos a sortear: ", 1, (233-218-1));

// sortear os alunos (concatenação dos resultados)
for (int i = 0; i < quantidadeAlunos; i++)
{
    alunoSorteado = SorteiaAlunoUpSkillPP2023(PRIMEIRO_ALUNO, ULTIMO_ALUNO, 219);
    nomeAluno = DaNome(alunoSorteado);
    alunosSorteados += $"[{alunoSorteado}] - {nomeAluno}\n";
} 

// apresentar na consola
Console.WriteLine(alunosSorteados);


static int RecolheInteiro(string pergunta, int minimo, int maximo)
{
    // variáveis
    int numero;

    // fazer a primeira pergunta
    Console.Write(pergunta);
    numero = int.Parse(Console.ReadLine());

    // fazer ciclos enquanto a resposta for irregular
    while (numero < minimo || numero > maximo)
    {
        Console.WriteLine("O número está errado!");
        Console.Write(pergunta);
        numero = int.Parse(Console.ReadLine());
    }

    // devolver o numero inserido
    return numero;
}


static int SorteiaAlunoUpSkillPP2023(int primeiro, int ultimo, int excluido)
{
    // variáveis
    int numeroSorteado;

    // sortear o número
    numeroSorteado =  GetRandomNumberBetween(primeiro, ultimo);

    // se o excluido for o sorteado, sortear novamente
    while (numeroSorteado == excluido)
        numeroSorteado = GetRandomNumberBetween(primeiro, ultimo);

    // devolve o número sorteado
    return numeroSorteado;
}

static string DaNome(int numero)
{
    // variáveis
    string nome;

    // decidir o nome
    switch (numero)
    {
        case 218:
            nome = "Ana Ferreira";
            break;
        case 219:
            nome = "N/A";
            break;
        case 220:
            nome = "Daniel Sousa";
            break;
        case 221:
            nome = "Fábio Costa";
            break;
        case 222:
            nome = "José Ramião";
            break;
        case 223:
            nome = "Luis Gomes";
            break;
        case 224:
            nome = "Paulo Almeida";
            break;
        case 225:
            nome = "Tomás";
            break;
        case 226:
            nome = "Sara Rocha";
            break;
        case 227:
            nome = "Tássio";
            break;
        case 228:
            nome = "Tiago Guimarães";
            break;
        case 229:
            nome = "José Antunes";
            break;
        case 230:
            nome = "Ana Torres";
            break;
        case 231:
            nome = "Sofia Pereira";
            break;
        case 232:
            nome = "Carlos Marques";
            break;
        case 233:
            nome = "Jorge Torres";
            break;
        default:
            nome = "N/A";
            break;
    }

    // devolve o nome correspondente ao número
    return nome;
}

static int GetRandomNumberBetween(int min, int max)
{
    int quociente = max - min;
    int aleatorio = GetRandomNumber() % quociente;
    return aleatorio + min;
}

static int GetRandomNumber()
{
    Random rnd = new Random();
    return rnd.Next();
}