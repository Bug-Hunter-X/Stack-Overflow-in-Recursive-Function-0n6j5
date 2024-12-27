public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0 || b == 0) {
            return a + b; //Corrected base case
        }
        if (a < 0 || b < 0) {
            throw new ArgumentOutOfRangeException("Inputs must be non-negative.");
        }
        return MyMethod(a - 1, b - 1); 
    }
}