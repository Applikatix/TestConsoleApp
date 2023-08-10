
// Alle typer (klasser, structs, interfaces, etc.) er defineret i et namespace.
// Namespaces hjælper med at organisere typer man definere.
// Ting i et namespace kan tilgåes igennem det namespace, med mindre det har access modifieren "private".
// namespace [name] { }
namespace TestClassLibrary;

// Klasse
// [access modifier] class [name] { }
public class Name {
    // field
    // "_input" med access modifieren "private" kan ikke tilgåes uden for klassen
    // [access modifier] [type] [name];
    private string _input;

    // constructor
    // [access modifier] [class name] ([parameters]) { [body] }
    public Name(string input) {
        // field instantiation
        // [field name] = [argument];
        _input = input;
    }

    // Method
    // [access modifier] [return type] [name] ([parameters]) { [body] }
    public int CountInput() {
        // Return from method
        // return [field name].[property];
        return _input.Length;
    }
    // Static method
    // [access modifier] static [return type] [name] ([parameters]) { [body] }
    public static int CountString(string input) {
        return input.Length;
    }
}