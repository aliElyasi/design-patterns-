﻿// See https://aka.ms/new-console-template for more information
using design_patterns.memento;
using design_patterns.State;

Console.WriteLine("Hello, World!");

#region memento
//editor editor = new editor();
//editor.content = "1";
//var editorState= editor.createState();
//var history =new History();

//history.push(editorState);
//var oldState=history.pop();
//editor.content = "2";
//editor.restore(oldState);

//Console.WriteLine(editor.content);
#endregion

Canvas canvas = new Canvas(new SelectionTool());
canvas.mouseDown();
canvas.mouseUp();


