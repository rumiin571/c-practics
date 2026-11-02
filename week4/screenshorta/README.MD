Features
- Create a file named this file.doc.
- Write sample text into the file using StreamWriter.
- Read the file line by line using File.ReadLines().
- Display each line in a ListBox.
- Show a message if the file does not exist.
Screenshots
1. Create and write to a file

2. Read file contents

Code overview
Create / write file
The btnwrite_Click event creates this file.doc, writes several
lines, displays a success message, and closes the writer.
![create file](<create file.png>)
Requirements
- Visual Studio
- C# Windows Forms project
- A ListBox named fist
- Buttons connected to the correct Click events
- using System.IO; at the top of the C# file
How to run
1. Open the Windows Forms project in Visual Studio.
2. Make sure the button Click events are connected to btnwrite_Click
   and btread_Click.
3. Run the project.
4. Click the Write button first to create and fill the file.
5. Click the Read button to display its contents in the ListBox.
Important notes
- The file is created in the application's current working directory.
  For a beginner project, this is often the project's bin\Debug or
  bin\Debug\net... folder.
- The name fist must match the actual ListBox name in the Windows
  Forms Designer. If your ListBox is named listBox1, replace fist
  with listBox1.
- The text this file.doc contains plain text even though its
  extension is .doc; it is not a real Microsoft Word document.
- For safer resource handling, you can use using with StreamWriter
  in a later version of the project
  ![checked file](<cheked file.png>)
  