void Fillarray(int [,] arr){
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=0; j<arr.GetLength(1); j++){
            arr[i,j] = new Random().Next(0,10);
            Console.Write($"{arr[i,j]} "); }
        Console.WriteLine();}
}

void MatrixMultiply(int [,] array1, int [,] array2){
        int [,] array = new int[2,2];
        for (int i=0; i<array.GetLength(0); i++){
            for (int j=0; j<array.GetLength(1); j++){
                array[i,j] = array1[i,j] * array2[i,j];
                Console.Write($"{array[i,j]} "); }
            Console.WriteLine();}
}

int[,] a = new int[2,2];
int[,] b = new int[2,2];
Fillarray(a);
Console.WriteLine();
Fillarray(b);
Console.WriteLine();
MatrixMultiply(a,b);
