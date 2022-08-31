void Fillarray(int [,,] arr){
    for (int k=0; k<arr.GetLength(2); k++){
        for (int i=0; i<arr.GetLength(0); i++){
            for (int j=0; j<arr.GetLength(1); j++){
                arr[i,j,k] = new Random().Next(10,100);
                Console.Write($"{arr[i,j,k]} ({i},{j},{k}) "); }
            Console.WriteLine();}
    }
}

int[,,] a = new int[2,2,2];
Fillarray(a);