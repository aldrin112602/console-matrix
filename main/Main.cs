using System;  
public class Main 
{  
    public static void Main() 
    {
        int i,j,n;
    	int[,] arr1 = new int[50,50];
		int[,] brr1 = new int[50,50];
		int[,] crr1 = new int[50,50];
  
       Console.Write("\n\nSubtraction of two Matrices :\n");
       Console.Write("------------------------------\n");  
        Console.Write("Input the size of the square matrix (less than 5): ");
	   n = Convert.ToInt32(Console.ReadLine());
  
    /* Stored values into the array*/
       Console.Write("Input elements in the first matrix :\n");
       for(i=0;i<n;i++)
        {
            for(j=0;j<n;j++)
            {
	           Console.Write("element - [{0},{1}] : ",i,j);
		       arr1[i,j] = Convert.ToInt32(Console.ReadLine());			   
            }
        }   
  
       Console.Write("Input elements in the second matrix :\n");
       for(i=0;i<n;i++)
        {
            for(j=0;j<n;j++)
            {
	           Console.Write("element - [{0},{1}] : ",i,j);
		       brr1[i,j] = Convert.ToInt32(Console.ReadLine());			   
            }
        }    
   Console.Write("\nThe First matrix is :\n");
  for(i=0;i<n;i++)
    {
      Console.Write("\n");
      for(j=0;j<n;j++)
           Console.Write("{0}\t",arr1[i,j]);
    }
  
  Console.Write("\nThe Second matrix is :\n");
  for(i=0;i<n;i++)
    {
      Console.Write("\n");
      for(j=0;j<n;j++)
      Console.Write("{0}\t",brr1[i,j]);
    }
/* calculate the subtraction of the matrix */   
   for(i=0;i<n;i++)
       for(j=0;j<n;j++)
            crr1[i,j]=arr1[i,j]-brr1[i,j];
   Console.Write("\nThe Subtraction of two matrix is : \n");
   for(i=0;i<n;i++){
       Console.Write("\n");
       for(j=0;j<n;j++)
            Console.Write("{0}\t",crr1[i,j]);
   }
   Console.Write("\n\n");
  }
}
