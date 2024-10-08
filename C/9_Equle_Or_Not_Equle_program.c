#include <stdio.h>
 void main() 
 {
    int number1,number2;
    printf("enter number:");
    scanf("%d %d",&number1,&number2);
    
     if  (number1>=number2)
    {
        printf("number1 is equal to number2");
    }
   
   else  if (number1!=number2)
    {
        printf("number1 is not equal to number2");
    }
}