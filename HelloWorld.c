#include <stdio.h>

int main() {
  printf("Hello World! \n");
  printf("There was never an apple to begin with. Never.");
  printf("\t You were lied to.");
  
  // I used replit because VScode does not work
  
  /* This is multi line
  wow
  */
  
  int apples = 0;
  char B = 'B';
  char S = 'S';
  float inches = 0.1;
  
  printf(apples); // This does nothing
  
  printf("\n");
  printf("%d", apples); // This does
  
  printf("\nYou have %d apples", apples); // %d is for int
  printf("\nAnd I bet even if you had, your apple size is %f inches. %c%c.", inches, B, S); // %f is for float, %c is for char");
  return 0;
  
}