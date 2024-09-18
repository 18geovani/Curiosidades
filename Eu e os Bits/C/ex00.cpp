#include <stdio.h>
int main() {
    // Abre o arquivo 'z' para escrita
    FILE *file = fopen("z", "w");

    // Verifica se o arquivo foi aberto corretamente
    if (file != NULL) {
        // Escreve "Z" seguido de uma quebra de linha no arquivo
        fputc('Z', file);
        fputc('\n', file);

        // Fecha o arquivo
        fclose(file);
    } else {
        // Se houver um erro ao abrir o arquivo, imprime uma mensagem de erro
        printf("Erro ao criar o arquivo 'z'\n");

        // Retorna um código de erro
        return 1;
    }

    // Retorna 0 indicando sucesso
    return 0;
}
