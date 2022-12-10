Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Length = IntLength(N);
int numberA = N, numberB;
// В Список записываются т.к. удобно следить за дубликатами и просто на будущее использование.
List<int> SubDigits = new List<int>();
int Amount = 0;
int Primes = 0;

for (int i = Length; i > 0; i--){
    numberB = numberA;
    while (numberB>9){
        numberB = numberB/10;
        if (!SubDigits.Contains(numberB)) {
            SubDigits.Add(numberB);
            Amount++;
            Console.WriteLine("Подчисло B " + numberB);
            if (IsPrime(numberB)){
                Primes++;
                Console.WriteLine(" Простое!");
            }
        }
    }
    int LengthA = IntLength(numberA);
    numberA = numberA%(int)Math.Pow(10,(LengthA-1));
    if (!SubDigits.Contains(numberA)&&numberA != 0) {
        SubDigits.Add(numberA);
        Amount++;
        Console.WriteLine("Подчисло A " + numberA);
        if (IsPrime(numberA)&&numberA != 0){
            Primes++;
            Console.WriteLine(" Простое!");
        }
    } 
}
Console.WriteLine("Подчисел суммарно " + Amount);
Console.WriteLine("Простых суммарно " + Primes);


int IntLength(int i)
{
  if (i < 0) i = Math.Abs(i);
  if (i == 0) return 1;
  return (int)Math.Floor(Math.Log10(i)) + 1;
}


bool IsPrime(int number) 
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;
    
    int boundary = (int)Math.Floor(Math.Sqrt(number));
    
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    
    return true;        
}

