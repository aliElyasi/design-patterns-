// See https://aka.ms/new-console-template for more information
using design_patterns.iterator;
using design_patterns.memento;
using design_patterns.Observer;
using design_patterns.State;
using design_patterns.template;

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

//Canvas canvas = new Canvas(new SelectionTool());
//canvas.mouseDown();
//canvas.mouseUp();



//BrowserHistory history = new BrowserHistory();

//history.push("a");
//history.push("b");
//history.push("c");

//var iterator = history.createIterator();

//while (iterator.hasNext())
//{
//    Console.WriteLine(iterator.current());

//    iterator.next();
//}

//design_patterns.template.Task task=new TransferMoney();

//task.excute();

var dataSource = new DataSource();
var spreadSheet01 = new SpreadSheet(dataSource);
var chart = new chart(dataSource);

dataSource.Addobserver(spreadSheet01);
dataSource.Addobserver(chart);

dataSource.dataValue = 1;

