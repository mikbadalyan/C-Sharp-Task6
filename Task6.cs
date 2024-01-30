//Task 6

//Ստեղծում ենք մատրից
int rows = 8;
int columns = 8;

int[,] matrix = new int[rows,columns];
//


Random random = new Random();

//մատրիցի էլեմենտների հավանական արժեքները հավաքենք մեկ զանգվածում
int[] array = new int[rows * columns];
for (int i = 0; i < rows * columns; i++)
{
    array[i] = i + 1;
}
//

// Պատահականության սկզբունքով արժեքներ տալ էլեմենտներին։
int index;
int x;
int y;

for (int i = 0; i < rows * columns * 10; i++)
{
    index = random.Next(0, rows*columns);
    x = random.Next(0, rows);
    y = random.Next(0, columns);
    if (matrix[x, y] == 0 && array[index] != 0)
    {
        matrix[x, y] = array[index];
        array[index] = 0;
    }
}
//

//Այն դեպքում եթե որևէ քանակությամբ էլեմենտներ չունենան արժեք, դրանք լրացնել պատահականության սկզբունքով սակայն օգտագործելով ցիկլ։
index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        
        if (matrix[i, j] == 0)
        {
           
            for(int e = index; e < rows * columns; e++)
            {
                if (array[e] != 0)
                {
                    matrix[i, j] = array[e];
                    array[e] = 0;
                    break;
                }
            }

            index++;
        }
    }
}
//

//Մատրիցի պատկերում
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
//









