# include <stdio.h>

int main () {
  int calculation = 1;
  int first = 0;
  int second = 0;
  int result = 0;

  while (calculation > 0) {
    printf("1. sum \n2. difference \n3. product \n<=0 end program \n");
    scanf("%d", &calculation);

    if (calculation > 0) {
      printf("Enter the first number: \n");
      scanf("%d", &first);

      printf("Enter the second number: \n");
      scanf("%d", &second);
      
      switch (calculation) {
        case 1:
          result = first + second;
          printf("%d + %d = %d\n", first, second, result);
          break;
        case 2:
          result = first - second;
          printf("%d - %d = %d\n", first, second, result);
          break;
        case 3:
          result = first * second;
          printf("%d * %d = %d\n", first, second, result);
          break;
      }
    }
    
    else if (calculation <= 0) {
      printf("Program end.\n");
      return 0;
    }

    else if (calculation > 3) {
      printf("Invalid output.\n");
    }
  }
}
