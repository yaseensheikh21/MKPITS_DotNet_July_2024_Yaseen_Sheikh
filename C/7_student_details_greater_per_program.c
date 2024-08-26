#include <stdio.h>
void main()
{
   char name1[10],name2[10],name3[10];
   int class1,class2,class3;
   float per1,per2,per3;
    
    printf("enter name1,name2,name3:");
    scanf("%s %s %s",&name1,&name2,&name3);
     
     printf("enter class1,class2,class3:");
     scanf("%d %d %d",&class1,&class2,&class3);
     
     printf("enter per1,per2,per3:");
     scanf("%f %f %f",&per1,&per2,&per3);
      
      
      
      printf("\n***********student detail 1************\n");
      
      printf("name1=%s\n",name1);
      printf("class1=%d\n",class1);
      printf("per1=%f\n",per1);
      
      
      
       printf("\n***********student detail 2************\n");
      
      printf("name2=%s\n",name2);
      printf("class2=%d\n",class2);
      printf("per2=%f\n",per2);
      
      
      
      
       printf("\n***********student detail 3************\n");
      
      printf("name2=%s\n",name3);
      printf("class3=%d\n",class3);
      printf("per3=%f\n",per3);
      
      
      if(per1>per2 && per1>per3)
      {
          printf("per1 is greater than 2&3");
      }
      else if(per2>per1 && per2>per3)
      {
          printf("per2 is geater than 1&3");
      }
      else
      {
          printf("per3 is greater");
      }
}
