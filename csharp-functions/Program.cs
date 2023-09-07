//Array di partenza che chiamo arrayMain
int[] arrayMain = new int[] { 2, 6, 7, 5, 3, 9 };

//Array al quadrato
int[] arrayAlquadrato = ElevaAlQuadratoArray(arrayMain);

//Invocazione funzione PrintArray su arrayMain
PrintArray(arrayMain);

//Invocazione funzione ElevaAlQuadrato con cifre a piacere su riga di testo
Console.WriteLine(ElevaAlQuadrato(2));


//Stampa array al quadrato
PrintArray(arrayAlquadrato);

//Ristampa arrayMain
PrintArray(arrayMain);

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

int [] ElevaAlQuadratoArray(int[] array)
{
    int[] arrayAlquadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        arrayAlquadrato[i] = ElevaAlQuadrato(array[i]);
    return arrayAlquadrato;
}   