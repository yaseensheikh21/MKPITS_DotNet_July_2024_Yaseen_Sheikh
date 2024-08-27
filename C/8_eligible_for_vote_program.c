#include <stdio.h> 
void main()
{
    int age = 18;
    
    
    printf("enter you age:");
    scanf("%d",&age);
    
    if (age>=18)
    {
    printf("age is greater then 18 is eligible for vote ");
    }
    else if (age<=18)
    {
    printf("age is less then 18 is not eligible for vote");
    }
}

