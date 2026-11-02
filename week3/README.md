C# Chapter 3: Making Decisions

1. Introduction

This chapter explains how to make decisions in C# programming. Decision structures allow a program to choose what to do based on a condition.

2. Topics Covered

* Decision Structures and the if Statement
* The if-else Statement
* Nested Decision Structures
* The if-else-if Statement
* Logical Operators
* Boolean Variables and Flags
* Comparing Strings
* The TryParse() Method
* Input Validation
* Radio Buttons and Check Boxes
* The switch Statement
* Introduction to ListBox Controls

3. Decision Structures and the if Statement

A decision structure executes statements only when a specific condition is true.

The if statement uses a Boolean expression that evaluates to true or false.

Example:

if (sales > 50000)
{
    bonus = 500;
}

In this example, the bonus is assigned 500 only when sales are greater than 50,000.

Relational Operators

Operator	Meaning
>	Greater than
<	Less than
>=	Greater than or equal to
<=	Less than or equal to
==	Equal to
!=	Not equal to

4. The if-else Statement

The if-else statement executes one block when the condition is true and another block when it is false.

Example:

if (age >= 18)
{
    MessageBox.Show("Adult");
}
else
{
    MessageBox.Show("Not an adult");
}

5. Nested Decision Structures

Nested decisions occur when one decision structure is placed inside another decision structure.

They are used when a program needs to check more than one condition.

Example:

if (salary >= 30000)
{
    if (yearsOnJob >= 2)
    {
        MessageBox.Show("You qualify for the loan");
    }
    else
    {
        MessageBox.Show("Minimum years at current job not met");
    }
}
else
{
    MessageBox.Show("Minimum salary requirement not met");
}

6. The if-else-if Statement

The if-else-if statement checks multiple conditions and selects the block that matches the first true condition.

Example:

if (score >= 90)
{
    MessageBox.Show("Grade A");
}
else if (score >= 80)
{
    MessageBox.Show("Grade B");
}
else if (score >= 70)
{
    MessageBox.Show("Grade C");
}
else
{
    MessageBox.Show("Grade D");
}

7. Logical Operators

Logical operators connect or reverse Boolean expressions.

Operator	Name	Meaning
&&	AND	Both conditions must be true
`		`
!	NOT	Reverses the Boolean value

Example:

if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

8. Boolean Variables and Flags

A bool variable stores one of two values: true or false.

A flag is a variable that signals whether a particular condition exists.

Example:

bool isApproved = true;
if (isApproved)
{
    MessageBox.Show("Approved");
}

9. Comparing Strings

Strings can be compared using relational operators and methods.

Example using ==:

if (name1 == name2)
{
    MessageBox.Show("Names are equal");
}

Example using !=:

if (name1 != "Bob")
{
    MessageBox.Show("The name is not Bob");
}

The String.Compare() method can also compare strings.

if (String.Compare(name1, name2) == 0)
{
    MessageBox.Show("Names are equal");
}

10. Preventing Data Conversion Exceptions

The TryParse() methods help prevent exceptions when converting user input into numbers.

Common methods include:

* int.TryParse()
* double.TryParse()
* decimal.TryParse()

Example:

int age;
if (int.TryParse(textBox1.Text, out age))
{
    MessageBox.Show("Valid number");
}
else
{
    MessageBox.Show("Please enter a number");
}

The out keyword is required when using the TryParse() pattern shown in this chapter.

11. Input Validation

Input validation checks whether entered data is valid before the program uses it.

TryParse() checks whether input can be converted to a number. It does not automatically check whether the number is reasonable.

Example:

int hours;
if (int.TryParse(textBox1.Text, out hours))
{
    if (hours > 0 && hours <= 168)
    {
        MessageBox.Show("Valid hours");
    }
    else
    {
        MessageBox.Show("Hours must be between 1 and 168");
    }
}
else
{
    MessageBox.Show("Enter a valid number");
}

12. Radio Buttons

Radio buttons allow users to select one option from a group of choices.

The Checked property determines whether a radio button is selected.

Example:

if (choiceRadioButton.Checked)
{
    MessageBox.Show("Option selected");
}

13. Check Boxes

Check boxes allow users to select options, such as Yes/No or True/False.

Example:

if (option1CheckBox.Checked)
{
    MessageBox.Show("Option selected");
}

CheckedChanged Event

The CheckedChanged event occurs when the Checked property changes.

It allows a program to respond when a radio button or check box is selected or deselected.

14. The switch Statement

The switch statement selects a path based on the value of a variable or expression.

It is an alternative to some if-else-if structures.

Example:

switch (choice)
{
    case 1:
        MessageBox.Show("Monday");
        break;
    case 2:
        MessageBox.Show("Tuesday");
        break;
    default:
        MessageBox.Show("Invalid choice");
        break;
}

* case defines a possible value.
* break ends the current case.
* default handles values that do not match the listed cases.

15. Introduction to ListBox

A ListBox displays a list of items and allows users to select an item.

Important Properties

* Text: Contains the text of the currently selected item.
* Items: Contains the items in the ListBox.
* Items.Count: Gives the number of items.
* SelectedItem: Gets the selected item.
* SelectedIndex: Gives the index of the selected item.

ListBox indexes start at zero. If no item is selected, SelectedIndex is -1.

Example:

if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit = fruitListBox.SelectedItem.ToString();
    MessageBox.Show(selectedFruit);
}

16. Adding Items to a ListBox

The Items.Add() method adds an item to a ListBox.

Example:

daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");

17. Removing Items from a ListBox

Remove()

Removes a specific item.

daysListBox.Items.Remove("Tuesday");

RemoveAt()

Removes an item at a specified index.

daysListBox.Items.RemoveAt(2);

The index must be valid.

Clear()

Removes all items.

daysListBox.Items.Clear();

18. Technologies Used

* C#
* .NET Framework
* Windows Forms
* Visual Studio

19. Learning Objectives

After studying this chapter, students should be able to:

* Use decision structures in C#.
* Apply relational and logical operators.
* Write nested if statements.
* Compare strings.
* Use TryParse() to check numeric input.
* Validate user input.
* Work with radio buttons and check boxes.
* Use the switch statement.
* Add, select, and remove ListBox items.

20. Conclusion

This chapter introduces important decision-making concepts in C#. These concepts help programmers control program execution, validate input, and create interactive Windows Forms applications.

Reference: Starting Out with Visual C#, Sixth Edition — Chapter 3: Making Decisions.