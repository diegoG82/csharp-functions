//Array di partenza che chiamo arrayMain
int[] arrayMain = new int[] { 2, 6, 7, 5, 3, 9, };

//Invocazione funzione PrintArray su arrayMain
Console.Write($"Il mio Array di partenza e':");
PrintArray(arrayMain);
Console.WriteLine();

//Dichiaro un numero per la moltiplicazione
int num = 2;

//Invocazione funzione ElevaAlQuadrato con cifre a piacere su riga di testo
Console.WriteLine($"Il risultato della moltiplicazione è: {(ElevaAlQuadrato(num))}");
Console.WriteLine();


//Stampa array al quandrato
Console.Write($"Il mio Array di partenza elevato al quadrato e':");
PrintArray(ElevaAlQuadratoArray(arrayMain));
Console.WriteLine();


//Ristampa arrayMain
Console.Write($"Il mio Array di partenza era:");
PrintArray(arrayMain);
Console.WriteLine();

//Stampa Somma valori Arraymain
Console.WriteLine($"La somma dei numeri dell'array e': {sommaNumeriArray(arrayMain)}");
Console.WriteLine();

//Stampa Somma valori Array al quadrato
Console.WriteLine($"La somma dei numeri dell'array elevato al quadrato e': {sommaNumeriArrayQuad(arrayMain)}");



// FUNZIONI

//Dichiarazione funzione che stampa l'array arrayMain tra quadre e con le virgole:
void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine("]");
}

//funzione che eleva al quadrato un numero
int ElevaAlQuadrato(int num)
{
    return num * num;
}


//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
//(Verificare che l’array originale non sia stato modificato
//quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

int[] ElevaAlQuadratoArray(int[] array)
{
    int[] arrayAlquadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        arrayAlquadrato[i] = ElevaAlQuadrato(array[i]);
    return arrayAlquadrato;
}

//Stampare la somma di tutti i numeri dell'array principale

int sommaNumeriArray(int[] num)

{
    int sommaArray = 0;
    for (int i = 0; i < num.Length; i++)
        sommaArray += num[i];
    return sommaArray;
}

//Stampare la somma di tutti i numeri dell'array al quadrato

int sommaNumeriArrayQuad(int[] num)

{
    int[] newArray = ElevaAlQuadratoArray(num);
    int sumArrayQ = sommaNumeriArray(newArray);
    return sumArrayQ;


}