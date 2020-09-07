#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    int idade = 0;
    printf("Digite sua idade: ");
    scanf("%d", &idade);
    if(idade >= 18)
    {
		printf("E maior de idade");
    }
    else
    {
		printf("E menor de idade");
    }

    getchar();
    return 0;
}
