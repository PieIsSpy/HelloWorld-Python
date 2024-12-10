# include <stdio.h>

int main () {
  int choice = 1;

  while (choice > 0) {
    printf ("\n1. Cat \n2. Dog \n3. Cow \nNegative numbers end the program.\n");

    scanf("%d", &choice);

    if (choice > 0) {
      switch (choice) {
        case 1:
          printf("Meow!");
          break;

        case 2:
          printf("Woof!");
          break;
        case 3:
          printf("Moo!");
          break;
        default:
          printf("Error, try again.");
      }
    }
      
    else {
      return 0;
    }
    
  }
  
}