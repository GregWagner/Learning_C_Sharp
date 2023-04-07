static void FormatString(string stringToFormat) {
    stringToFormat.Replace("World", "Mars");
}

static string FormatReturningString(string stringToFormat) {
    return stringToFormat.Replace("World", "Mars");
}

var greetings = "Hello World!";
FormatString(greetings);
Console.WriteLine(greetings);
Console.WriteLine(FormatReturningString(greetings));

var anotherGreetings = "Good morning Earth!";
Console.WriteLine(FormatReturningString(anotherGreetings));
