int tamanho = 10;
int[] vetor = new int[tamanho];
int aux = 0;
Boolean troca = false;
Random random = new Random();



Console.Clear();

for (int i = 0; i < tamanho; i++)
{
    vetor[i] = random.Next(0, 500);
}

// for (int j = 0; j < tamanho; j++)
// {    
//     for (int i = 0; i < tamanho - 1; i++)
//     {
        
//         if(vetor[i] > vetor[i+1]){
//             aux = vetor[i];
//             vetor[i] = vetor[i+1];
//             vetor[i+1] = aux;
//         }
//     }
// }

do
{
    troca = false;
    for (int i = 0; i < tamanho - 1; i++)
    {
        if(vetor[i] > vetor[i+1]){
            aux = vetor[i];
            vetor[i] = vetor[i+1];
            vetor[i+1] = aux;
            troca = true;
        }
    }
}
while(troca);




void ImpremirVetor()
{
    for (int i = 0; i < tamanho; i++)
    {
        Console.Write(vetor[i] + " ");
    }
    Console.WriteLine("\n");
}

//Array.Sort(vetor);


ImpremirVetor();