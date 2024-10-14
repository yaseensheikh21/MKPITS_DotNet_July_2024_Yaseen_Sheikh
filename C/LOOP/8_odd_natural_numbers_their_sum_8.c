#include <stdio.h>

int main() {
    int n, sum = 0;
    printf("Enter the number of terms: ");
    scanf("%d", &n);

    printf("The first %d odd natural numbers are: ", n);
    for (int i = 1; i <= 2 * n; i += 2) {
        printf("%d ", i);
        sum += i;
    }

    printf("\nSum of the odd natural numbers: %d\n", sum);

    return 0;
}
