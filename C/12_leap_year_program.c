#include <stdio.h>
void main()
{
int year;
printf("enter year:");
scanf("%d",&year);
if (year %4==0)
{
    printf("this is leap year ");
}
else 
{
    printf("this is not leap year");
 }
}