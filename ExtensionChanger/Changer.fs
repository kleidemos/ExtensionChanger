module Changer

open System.IO

let setExtension ext (directory:DirectoryInfo) =
    directory.GetFiles()
    |> Seq.iter (fun p -> File.Move(p.FullName, Path.ChangeExtension(p.FullName, ext)))
