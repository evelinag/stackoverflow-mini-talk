open System
open System.IO

let csv = 
    File.ReadAllLines("/Users/evelina/OtherProjects/Fable-SO/data/ts.csv").[1..]
    |> Array.map (fun row -> 
        let items = row.Split ','
        items.[0].[1..items.[0].Length-2], (
        )
    
