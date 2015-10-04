module ``fsharp-flux-todomvc``.Tests

open ``fsharp-flux-todomvc``
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)
