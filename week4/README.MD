Chapter_04_Gaddis_CSharp_6e_final.pptx
Presentati

Chapter Overview

Learning Topics

Sharaxaadda while, for iyo do-while

Increment iyo Decrement

File Handling (StreamReader iyo StreamWriter)

OpenFileDialog iyo SaveFileDialog

Random Numbers

Windows Forms Load Event

Key Terms iyo Quick Review

README.md

Markdown file · Diyaar u ah GitHub
Ready
Download README.md


README.md
Document



Chapter 4: Loops, Files, and Random Numbers
Overview
This README summarizes the topics covered in the PowerPoint presentation
Starting Out with Visual C# (Sixth Edition, Global Edition), Chapter
4. The chapter introduces repetition using loops, basic file
input/output, file dialog controls, random-number generation, and the
Windows Forms Load event.

Learning Topics
The while loop
Increment (++) and decrement (--) operators
The for loop
The do-while loop
Using text files for data storage
OpenFileDialog and SaveFileDialog controls
Random numbers with the Random class
The Windows Forms Load event
1. The while Loop
A while loop repeats a statement or block while its Boolean condition
is true. It is a pretest loop, because the condition is checked
before the loop body runs. Therefore, the body may run zero times.

int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
The example displays the message five times. Make sure the loop changes
something that can eventually make its condition false; otherwise, it
may become an infinite loop.

2. Increment and Decrement Operators
count++ increases count by one.
count-- decreases count by one.
count += 1 and count = count + 1 also increase it by one.
count -= 1 and count = count - 1 also decrease it by one.
Postfix (count++): use the current value, then increment it.
Prefix (++count): increment first, then use the new value.

3. The for Loop
A for loop is useful when a counter controls how many times a loop
repeats. It has three parts: initialization, condition test, and update.

for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
The counter can also increase by a different amount or count backward:

for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
4. The do-while Loop
A do-while loop is a posttest loop. It runs the body first and
checks the condition afterward, so its body always runs at least once.

int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);
Even though the condition is initially false, the message is displayed
once.

5. Using Text Files for Data Storage
The chapter describes three basic file-processing steps:

Open the file.
Read from or write to the file.
Close the file.
The chapter focuses on text files. The two .NET classes introduced
are: - StreamWriter --- writes data to a text file. - StreamReader
--- reads data from a text file.

Writing to a file
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();
WriteLine() writes data and then starts a new line.
Write() writes data without adding a newline.
File.CreateText() creates a file; if the file already exists, its
contents are erased.
File.AppendText() adds data to an existing file without erasing
its current contents.
Reading from a file
StreamReader inputFile;
inputFile = File.OpenText("students.txt");
Methods mentioned in the presentation include ReadLine(), Read(),
and ReadToEnd(). File.ReadAllText() is also listed. Close the file
after processing it.

To read until the end of a file, use the EndOfStream property:

while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    // Process the line here.
}

inputFile.Close();
6. Open and Save File Dialog Controls
OpenFileDialog displays the standard Windows Open dialog.
SaveFileDialog displays the standard Windows Save As dialog.
These are invisible controls placed in the component tray in the
Windows Forms Designer.
ShowDialog() displays the dialog and returns a DialogResult.
DialogResult.OK indicates that the user confirmed a selection;
DialogResult.Cancel indicates cancellation.
The selected file path is available through the dialog control's
FileName property.
InitialDirectory can specify the directory displayed initially.
Example:

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamReader inputFile =
        File.OpenText(openFileDialog.FileName);
}
7. Random Numbers
The .NET Random class generates random values.

Random rand = new Random();

int number1 = rand.Next();
double number2 = rand.NextDouble();
Next() generates a random integer.
NextDouble() generates a floating-point value from 0.0 up to
(but not including) 1.0.
Next(max) generates an integer from 0 up to (but not including)
max.
For example:

int number = rand.Next(100); // 0 through 99
8. The Windows Forms Load Event
The form's Load event occurs when the form is loaded into memory as
the application starts. Code in the event handler runs when the form is
launched.

private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
Key Terms
Iteration: one execution of a loop body.
Counter variable: a variable used to track how many times a loop
runs.
Pretest loop: checks its condition before executing the body
(while and for).
Posttest loop: executes the body before checking its condition
(do-while).
Infinite loop: a loop that does not reach a terminating
condition.
Text file: a file containing data encoded as text.
Binary file: a file containing data not stored as readable text.
Quick Review
Which loop checks its condition before its body runs? while and
for.
Which loop always runs its body at least once? do-while.
Which class writes text files? StreamWriter.
Which class reads text files? StreamReader.
Which method adds a new line when writing? WriteLine().
Which method appends without erasing existing contents?
File.AppendText().
Which class generates random numbers? Random.
Which event runs when a Windows Form is loaded? Load.
Source
Prepared from the uploaded PowerPoint presentation:
Chapter_04_Gaddis_CSharp_6e_final.pptx. The README follows the
presentation's stated topics and examples.