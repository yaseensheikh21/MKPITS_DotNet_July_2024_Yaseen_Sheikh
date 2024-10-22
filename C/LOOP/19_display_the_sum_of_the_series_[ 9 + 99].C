#include <stdio.h>

int main() {
    int n, i;
    long int num = 9, sum = 0;
    printf("Enter the number of terms: ");
    scanf("%d", &n);
    for (i = 1; i <= n; i++) {
        printf("%ld ", num); 
        sum += num;         
        num = num * 10 + 9;  
    }
    printf("\nSum of the series: %ld\n", sum);
    return 0;
}