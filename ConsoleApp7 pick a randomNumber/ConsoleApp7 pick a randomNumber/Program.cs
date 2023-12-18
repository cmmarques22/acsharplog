int random = PickRandomNumber();
string name = GetName(random);
Console.WriteLine($"O nome  sorteado é: {name}"/*+ GetName()*/);



static int GetRandomNumberBetween(int min, int max)
{
    int quociente = max - min;
    int aleatorio = GetRandomNumber() % quociente;
    return aleatorio + min;

    // int numero;
    // return  (GetRandomNumber() % (max - min)) + min;
}

static int GetRandomNumber()
{
    Random rnd = new Random();
    return rnd.Next();
}


int PickRandomNumber()
{
    int random = GetRandomNumberBetween(218, 233);
    while (random == 219)
    {
        random = GetRandomNumberBetween(218, 233);
    }
    return random;
}

string GetName(int numero)
{
    string name;
    switch (numero)
    {
        case 218:
            name = "Ana Ferreira";
            break;
        case 220:
            name = "Daniel Sousa";
            break;
        case 221:
            name = "Fábio Costa";
            break;
        case 222:
            name = "José Ramião";
            break;
        case 223:
            name = "Luis Gomes";
            break;
        case 224:
            name = "Paulo Almeida";
            break;
        case 225:
            name = "Tomás";
            break;
        case 226:
            name = "Sara Rocha";
            break;
        case 227:
            name = "Tássio";
            break;
        case 228:
            name = "Tiago Guimarães";
            break;
        case 229:
            name = "José Antunes";
            break;
        case 230:
            name = "Ana Torres";
            break;
        case 231:
            name = "Sofia Pereira";
            break;
        case 232:
            name = "Camané";
            break;
        case 233:
            name = "Jorge Torres";
            break;
        default:
            name = "N/A";
            break;
    }

    return name;
}
