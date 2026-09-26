Chapter 1: Introduction to Visual C#

1. Objects

An object is a program component that contains data and performs operations.

* Properties: Data and characteristics of an object.
* Methods: Operations an object can perform.

2. Controls

Controls are objects that are visible in a program’s Graphical User Interface (GUI).

Control	Function
Label	Displays text
Button	Performs an action when clicked
TextBox	Allows the user to enter data
PictureBox	Displays an image

Some GUI objects are invisible, such as Timers and OpenFileDialog.

3. Class and .NET Framework

* Class: Code that describes a particular type of object.
* .NET Framework: A collection of classes and other code used to create Windows applications.
* C#: A programming language supported by .NET.

4. Visual Studio

Visual Studio is a professional Integrated Development Environment (IDE).

Its main windows include:

* Designer Window: Used to design the form.
* Solution Explorer: Displays projects and files.
* Properties Window: Used to change object properties.
* Toolbox: Contains controls used in an application.

5. Projects and Solutions

* Solution: A container that can hold one or more projects.
* Project: An application being developed.
* Project Files: Files containing the code and resources needed by the application.

6. Forms and Properties

When you create a new Windows Forms App, an empty form named Form1 is automatically created.

* Bounding Box: Thin dotted lines surrounding a form in the Designer.
* Sizing Handles: Small handles used to resize the form.

The Properties window has two columns:

* Left column: Property name.
* Right column: Property value.

The Text property determines the text displayed in the form’s title bar.

Example: Change Form1 to My First Program.

7. Rules for Naming Controls

Control names are also known as identifiers.

The naming rules are:

* The first character must be a letter or an underscore (_).
* Other characters can be letters, numbers, or underscores.
* The name cannot contain spaces.

Examples of valid names:

* showDayButton
* DisplayTotal
* _ScoreLabel

camelCase: A naming convention that begins with a lowercase letter. The first letter of each following word is uppercase.

Example: showDayButton

8. Namespace, Class, and Method

C# code is primarily organized in three ways:

* Namespace: A container that holds classes.
* Class: A container that holds methods.
* Method: A group of one or more programming statements that perform operations.

A file containing program code is called a source code file.

9. Program.cs and Form1.cs

* Program.cs: Contains the application’s startup code.
* Form1.cs: Contains code associated with the Form1 form.

10. Event-Driven Applications

GUI applications are event-driven. This means they respond to events that occur while the application is running.

* Event: A user’s action, such as clicking a button or pressing a key.
* Event Handler: A method that executes when a specific event occurs.

Example:

MessageBox.Show() displays a message in a dialog box.

11. Hello World Application

The following code displays “Hello World” when the button is clicked.

* messageButton_Click: The event handler.
* MessageBox.Show: Displays a message.
* "Hello World": The message to display.

12. Label Controls

A Label control displays text on a form. It can display unchanging text or program output.

Important properties:

Property	Function
Text	Gets or sets the text
Name	Gets or sets the control’s name
Font	Sets the font and font size
BorderStyle	Displays a border
AutoSize	Controls how the label is resized
TextAlign	Sets the text alignment

Text Alignment

The TextAlign property supports nine positions:

* TopLeft, TopCenter, TopRight
* MiddleLeft, MiddleCenter, MiddleRight
* BottomLeft, BottomCenter, BottomRight

Displaying Output in a Label

This statement displays “Hello World” in the Label control.

To clear the text:

The = symbol is called the assignment operator. It assigns a value to a variable or property.

13. IntelliSense

IntelliSense provides automatic code completion as you write programming statements.

It helps programmers by:

* Suggesting code automatically.
* Displaying keywords, variables, methods, classes, and properties.
* Making programming language references easily accessible.

14. PictureBox Controls

A PictureBox control displays a graphic image on a form.

Important properties:

* Image: Specifies the image to display.
* SizeMode: Specifies how the image is displayed.
* Visible: Determines whether the control is visible at runtime.

Example:

This makes the back image visible and hides the face image.

15. Sequential Execution of Statements

Sequential execution means that statements execute in the order in which they appear.

Example:

First, the back image becomes visible. Then, the face image becomes hidden.

Incorrect statement order can cause a logic error, where the program runs but produces an incorrect result.

16. Comments, Blank Lines, and Indentation

Comments are notes placed in source code to explain how parts of a program work.

A single-line comment:

A block comment:

* Blank Lines: Empty lines used to separate sections of code.
* Indentation: The spacing used to make code easier to read.

17. Closing an Application

To close the current form:

To close the entire application:

18. Syntax Errors

A syntax error occurs when code violates the language’s writing rules.

Visual Studio identifies syntax errors by underlining the incorrect code with a jagged line.

Common examples include:

* Forgetting a semicolon (;).
* Forgetting to close parentheses ().
* Writing a method name incorrectly.
* Using braces {} incorrectly.