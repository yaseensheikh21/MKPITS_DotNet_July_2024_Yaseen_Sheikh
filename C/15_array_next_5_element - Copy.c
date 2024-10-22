#include <stdio.h>

int main() {
    int first = 1999; 
    int size = 8;    
    int arr[size];   

   
    for (int count = 0; count < size; count++)
    {
        arr[count] = first + count; 
    }
    for (int count = 0; count < size; count++) {
        printf("%d\n", arr[count]);
    }

    return 0;
}
