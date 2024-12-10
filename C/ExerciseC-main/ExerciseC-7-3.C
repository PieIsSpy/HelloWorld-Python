# include <stdio.h>

int main() {
  int a = 0;
  int b = 0;
  int c = 0;

  printf("Enter the first number: \n");
  scanf("%d", &a);

  printf("Enter the second number: \n");
  scanf("%d", &b);

  printf("Enter the third number: \n");
  scanf("%d", &c);

  int largest_num = highest(a, b, c);
  int smallest_num = smallest(a, b, c);

  printf("Largest = %d, Smallest = %d", largest_num, smallest_num);  
}

int highest (int a, int b, int c) {
  int result = a;
  if (b > a) result = b;
  if (c > b) result = c;
  return result;
}

int smallest (int a, int b, int c) {
  int result = a;
  if (a > b) result = b;
  if (b > c) result = c;
  return result;
}
