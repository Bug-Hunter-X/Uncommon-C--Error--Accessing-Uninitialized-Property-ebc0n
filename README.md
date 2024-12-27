# Uncommon C# Error: Accessing Uninitialized Property

This repository demonstrates a subtle and uncommon error in C#: accessing an uninitialized property. While properties automatically have a default value (e.g., 0 for int, null for reference types), explicitly assigning a value in the constructor or method is a best practice for clarity and preventing potential unexpected behavior.  The example shows how accessing an uninitialized property may work unexpectedly in some cases.

## Bug

The `bug.cs` file shows the erroneous code.  It demonstrates accessing the `MyProperty` before assigning it any value.

## Solution

The `bugSolution.cs` file provides the corrected code. The constructor initializes `MyProperty` to avoid the unexpected behavior.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE (Visual Studio).
3. Run the code and observe the output or any errors encountered in the console.
4. Compare the output with the corrected code in `bugSolution.cs`.
