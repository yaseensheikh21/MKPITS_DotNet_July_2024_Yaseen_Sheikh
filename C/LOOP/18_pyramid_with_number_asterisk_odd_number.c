#include <stdio.h>

int main() {
    int i, j, rows, space, stars;

    printf("Enter the number of rows: ");
    scanf("%d", &rows);
    for (i = 1; i <= rows; i++)
    {
            for (space = 1; space <= rows - i; space++) {
            printf(" ");
        }
        for (stars = 1; stars <= (2 * i - 1); stars++) {
            printf("*");
        }
        printf("\n");
    }

    return 0;
}