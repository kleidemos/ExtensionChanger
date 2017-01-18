module Changer

open System.IO

let setExtension ext (directory:DirectoryInfo) =
    directory.GetFiles()
    |> Seq.filter (fun p -> Path.GetExtension(p.FullName) = "")
    |> Seq.iter (fun p -> 
        let newFilePath = Path.ChangeExtension(p.FullName, ext)
        if File.Exists(newFilePath) 
        then File.Delete(newFilePath)
        File.Move(p.FullName, newFilePath)
        )
