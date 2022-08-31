void Fillarray(int [,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(0,10);
            Console.Write($"{matrix[i,j]} "); }
        Console.WriteLine();}
}
int[] Sum(int [,] matrix){
    int [] sum = new int[matrix.GetLength(0)];
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){
            sum[i]+= matrix[i,j];
        }
        Console.WriteLine(sum[i]);
    }
    Console.WriteLine();
    return sum;
}
void FindSum(int [] array){
    int k=0;
    int max = array[0];
    for (int i=1; i<array.GetLength(0); i++){
        if (array[i]>max){
            k=i+1;
            max=array[i];
        }
    }
    Console.WriteLine(k);
}
int[,] a = new int[5,4];
Fillarray(a);
Console.WriteLine();
FindSum(Sum(a));

