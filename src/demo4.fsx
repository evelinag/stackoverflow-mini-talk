#load "packages/FsLab/FsLab.fsx"

open System
open System.IO
open FSharp.Data
open XPlot.GoogleCharts
open MathNet.Numerics.Statistics

[<Literal>]
let CountryTagFile = "/Users/evelina/OtherProjects/StackOverflow/data/countries-tags-counts.csv"
type CountryTagCounts = CsvProvider<CountryTagFile>

let countryTagCounts = 
    CountryTagCounts.GetSample().Rows
    |> Seq.map (fun row -> row.Tag, (row.Country, float row.Frequency))
    |> Seq.groupBy fst
    |> Seq.map (fun (tag, xs) -> tag, xs |> Seq.map snd |> Array.ofSeq)
    |> dict

let smoothOutliers (countryFreq : (string * float)[]) = 
  let stat = new DescriptiveStatistics(countryFreq |> Array.map snd)
  let std = stat.StandardDeviation
  let avg = stat.Mean
  countryFreq 
  |> Array.map (fun (c,n) ->
      if n > 2.0*std then 
        printfn "Outlier: %s (%.1f)" c n
        c, 2.8 * std 
      else c, n)

countryTagCounts.["apl"] |> smoothOutliers |> Chart.Geo

