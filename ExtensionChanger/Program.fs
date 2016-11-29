// Дополнительные сведения о F# см. на http://fsharp.org
// Дополнительную справку см. в проекте "Учебник по F#".
open System.IO

[<EntryPoint>]
let main argv = 
    @"C:\Assets"
    |> DirectoryInfo
    |> Changer.setExtension "png"
    0
