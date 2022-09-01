int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[n,n];
int temp = 0;
for (int delta =0; delta<n-2; delta++){
    for (int j=0+delta; j<n-delta; j++){
        temp++;
        matrix[0+delta,j]=temp;
    }
    for (int i=1+delta; i<n-delta; i++){
        temp++;
        matrix[i,n-1-delta]=temp;
    }
    for (int j=n-2-delta; j>=0+delta; j--){
        temp++;
        matrix[n-1-delta,j]=temp;
    }
    for (int i=n-2-delta; i>0+delta; i--){
        temp++;
        matrix[i,0+delta]=temp;
    }
}

void Printarray(int [,] arr){
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=0; j<arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} "); }
        Console.WriteLine();}
}
Printarray(matrix);
