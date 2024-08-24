#include <stdio.h>
void main()
{
    char empoloyee1[10],empoloyee2[10],empoloyee3 [10];
    int contact_no1,contact_no2,contact_no3;
    int age1,age2,age3;
    float salary1,salary2,salary3;
    char postion1[20],postion2[20],postion3[20];
    
    printf("enter empoloyee1,empoloyee2,empoloyee3:");
    scanf("%s %s %s",&empoloyee1,&empoloyee2,&empoloyee3);
    
    printf("enter contact_no1,contact_no2,contact_no3 : ");
    scanf("%d %d %d",&contact_no1,&contact_no2,&contact_no3 );
    
    printf("enter age1,age2,age3: ");
    scanf("%d %d %d",&age1,&age2,&age3);
    
    printf("enter salary1,salary2,salary3:");
    scanf("%f %f %f",&salary1,&salary2,&salary3);
    
    printf("enter postion1,postion2,postion3:");
    scanf("%s %s %s",&postion1,&postion2,&postion3);
    
    
    printf("\n*******Details of Employee 1*********\n");
    
    printf("empoloyee1=  %s\n",empoloyee1);
    printf("contact_no1= %d\n",contact_no1);
    printf("age1=%d\n",age1);
    printf("salary1=%f\n",salary1);
    printf("postion1=%s\n",postion1);
    
    
    printf("\n*******Details of Employee 2*********\n");
    
    printf("empoloyee2=  %s\n",empoloyee2);
    printf("contact_no2= %d\n",contact_no2);
    printf("age2=%d\n",age2);
    printf("salary2=%f\n",salary2);
    printf("postion2=%s\n",postion2);
    
    
    printf("\n*******Details of Employee 3*********\n");
   
    printf("empoloyee3=  %s\n",empoloyee3);
    printf("contact_no3= %d\n",contact_no3);
    printf("age3=%d\n",age3);
    printf("salary3=%f\n",salary3);
    printf("postion3=%s\n",postion3);
}