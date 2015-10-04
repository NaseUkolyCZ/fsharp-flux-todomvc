namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("fsharp-flux-todomvc")>]
[<assembly: AssemblyProductAttribute("fsharp-flux-todomvc")>]
[<assembly: AssemblyDescriptionAttribute("Flux TodoMVC Example with server implemented in FSharp")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
