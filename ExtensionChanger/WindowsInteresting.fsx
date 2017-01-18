open System
open System.IO

let source = 
    Environment.UserName
    |> sprintf """C:\Users\%s\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets""" 
    |> DirectoryInfo

type FileSystemInfo with
    static member getFullName (info:FileSystemInfo) = info.FullName

let checkDimension file = 
    file
    |> FileSystemInfo.getFullName
    |> Drawing.Image.FromFile
    |> fun p -> p.Width, p.Height
    |> function 
    | 1920, 1080 | 1080, 1920 -> true 
    | _ -> false

let sourceFiles = 
    source
    |> FileSystemInfo.getFullName
    |> Directory.GetFiles
    |> Seq.map FileInfo
    |> Seq.filter checkDimension
    |> List.ofSeq

let destination = """C:\WindowsInteresting""" |> DirectoryInfo

let changeDirectory newDirectory path = 
    path
    |> Path.GetFileName
    |> fun p -> Path.Combine (newDirectory, p)

let changeExtension extension path = Path.ChangeExtension (path, extension)

let copyFiles () =
    let copyImage file = File.Copy (file |> FileSystemInfo.getFullName, file.FullName |> changeDirectory destination.FullName |> changeExtension ".jpg", true) 
    if Directory.Exists destination.FullName |> not 
        then Directory.CreateDirectory destination.FullName |> ignore; destination.Refresh()
    sourceFiles |> List.iter copyImage

copyFiles ()