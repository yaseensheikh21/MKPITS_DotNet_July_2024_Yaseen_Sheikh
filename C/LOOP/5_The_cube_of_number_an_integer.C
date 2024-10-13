#include <stdio.h>

int main() {
    int n;

    printf("Enter an integer: ");
    scanf("%d", &n);

    printf("Number\tCube\n");
    for (int i = 1; i <= n; i++) {
        printf("%d\t%d\n", i, i * i * i);
    }

    return 0;
}
