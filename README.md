# Stack Overflow Bug in C# Recursive Function

This repository demonstrates a common error in recursive functions: stack overflow due to a missing or inadequate base case. The `MyMethod` function recursively calls itself, subtracting 1 from both inputs (`a` and `b`) in each call. If `a` and `b` are large, the function will exceed the stack's capacity, causing a stack overflow exception.

The solution involves adding a more robust base case to avoid this issue.  The improved version efficiently handles a wider range of inputs.