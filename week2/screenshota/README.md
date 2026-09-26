Chapter 2: Processing Data — Summary

1. Variables and Data Types

* Variable: Stores data in memory.
* Data types:
    * string – stores text.
    * int – stores whole numbers.
    * double – stores decimal numbers.
    * decimal – stores precise decimal values, often used for money.

2. TextBox and Data Conversion

* A TextBox accepts user input.
* TextBox.Text stores input as a string.
* int.Parse() converts text to an integer.
* double.Parse() converts text to a double.
* .ToString() converts a value to a string.

3. Arithmetic Operators

Operator	Meaning
+	Addition
-	Subtraction
*	Multiplication
/	Division
%	Remainder

Note: Integer division gives an integer result.

4. Constants and Variables

* Constant: A value that cannot change. Use const.
* Local variable: Declared inside a method.
* Field: Declared inside a class but outside methods.
* Scope: Where a variable can be accessed.
* Lifetime: How long a variable exists.

5. Exception Handling

An exception is an error that occurs while a program runs.

* try contains code that may cause an error.
* catch handles the error.

6. Math Class

The Math class performs mathematical operations.

Method	Purpose
Math.Sqrt(25)	Square root
Math.Pow(2, 3)	Power
Math.Max(10, 20)	Largest value
Math.Min(10, 20)	Smallest value
Math.Round(4.6)	Rounds a number

7. Formatting Numbers

Use .ToString() to display numbers as text.

* "N" – Number format
* "F" – Fixed-point format
* "C" – Currency format
* "P" – Percentage format
* "E" – Scientific notation

Example:

8. Form Controls

* TabIndex: Determines the order of keyboard focus.
* Focus(): Sets focus to a control.
* Access Key: Uses & before a letter in a control’s text.
* BackColor: Changes background color.
* ForeColor: Changes text color.

9. GroupBox and Panel

* GroupBox: A container that can have a title.
* Panel: A container without a title; it supports a border style.

10. Debugging

Debugging helps find errors in a program.

* Logic error: The program runs but produces the wrong result.
* Breakpoint: Pauses program execution.
* Locals window: Shows local variables and their values.
* Watch window: Shows selected variables.
* Single-step: Executes one statement at a time.