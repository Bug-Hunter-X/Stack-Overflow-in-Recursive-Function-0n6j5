public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; //correct
        }
        if (b == 0) {
            return a; //correct
        }
        return MyMethod(a - 1, b - 1); //potential stack overflow if a and b are large 
    }
}