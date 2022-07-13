//type casting = Converting a value to a different data type
//               Useful when we accept user input (string)              
//               Different data types can do different things 


double a = 3.14;
int b = Convert.ToInt32(a);

int c =123;
double d = Convert.ToDouble(c) + 0.1;

int e = 321; 
String f = Convert.ToString(e);

string g = "$";
char h = Convert.ToChar(g);

string i = "true";
bool j = Convert.ToBoolean(i);


Console.WriteLine(b.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(h);
Console.WriteLine(j);

Console.ReadKey();



  
