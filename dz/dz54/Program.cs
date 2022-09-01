void Fillarray(int [,] arr){
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=0; j<arr.GetLength(1); j++){
            arr[i,j] = new Random().Next(0,10);
        }
    }
}
void Printarray(int [,] arr){
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=0; j<arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} "); }
        Console.WriteLine();}
}

void Sort(int [,] arr){
    int temp;
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=arr.GetLength(1)-1; j>0; j--){
            for (int k=j-1; k>-1; k--){
                if (arr[i,k]<arr[i,j]){
                    temp=arr[i,k];
                    arr[i,k]=arr[i,j];
                    arr[i,j]=temp;
                }
            }
        }
    }
}

int[,] a = new int[3,4];
Fillarray(a);
Printarray(a);
Console.WriteLine();
Sort(a);
Printarray(a);