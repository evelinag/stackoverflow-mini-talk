#load "packages/FsLab/FsLab.fsx"

open System
open System.IO
open FSharp.Data

type CountryNames = CsvProvider<"/Users/evelina/OtherProjects/StackOverflow/data/country-lookup.csv">
let countryNameLookup =
  CountryNames.GetSample().Rows
  |> Seq.map (fun row -> row.Name, row.UniqueName)
  |> Seq.append [| "Hong Kong", "China"; "Bahamas", "The Bahamas" |]
  |> dict

let countryNames =
  countryNameLookup.Keys |> Array.ofSeq


// Load resuls and compute relative frequency of programmers
// unit: programmers-per-milion

// total registered users: 5277831
// localized users: 760045
let samplingRatio = 760045.0/5277831.0

type Population = HtmlProvider<"https://en.wikipedia.org/w/index.php?title=List_of_countries_and_dependencies_by_population&oldid=738660700">
let populationData = 
      Population.GetSample().Tables.``Countries and dependencies by population``

let population = 
  populationData.Rows
  |> Seq.map (fun row -> 
      let country = 
        let name = row.``Country (or dependent territory)``
        if name.Contains "[" then
          name.[0..name.IndexOf("[")-1]
        else if name.Contains "(" then
          name.[0..name.IndexOf("(")-1]
        else
          name
      if countryNameLookup.ContainsKey(country) then
        countryNameLookup.[country], row.Population
      else
        printfn "Country not found: %s" country
        country, row.Population)
  |> Array.ofSeq

let populationLookup = dict population

population

// Merge with tag data
type TagCountryData = CsvProvider<"/Users/evelina/OtherProjects/StackOverflow/data/countries-tags.csv">
let tagCountryData = 
  TagCountryData.GetSample().Rows 
  |> Array.ofSeq

let getTagCounts tag =
  tagCountryData
  |> Array.filter (fun row -> row.Tag = tag )
  |> Array.map (fun row -> row.Country, float row.Count)

let getRelativeCounts tag =
  tagCountryData
  |> Array.filter (fun row -> row.Tag = tag )
  |> Array.choose (fun row -> 
      let n = float row.Count
      let country = row.Country
      if countryNameLookup.ContainsKey country then
        let country' = countryNameLookup.[country]
        if populationLookup.ContainsKey country' then 
          Some(country', n/(float populationLookup.[country']) * 1.0/samplingRatio * 1000000.0)
        else  
          //printfn "%s" country'
          None
      else  
        //printfn "%s" country
        None)

tagCountryData.Length

let tagCountryStr = 
  tagCountryData
  |> Array.choose (fun row -> 
      let n = float row.Count
      let country = row.Country
      if countryNameLookup.ContainsKey country then
        let country' = countryNameLookup.[country]
        if populationLookup.ContainsKey country' then 
          Some(country', row.Tag, n, n/(float populationLookup.[country']) * 1.0/samplingRatio * 1000000.0)
        else  
          None
      else  
        None)    
  |> Array.map (fun (country, tag, total, ppm) ->  country + "," + tag + "," + string total + "," + string ppm )
  |> Array.append [| "Country,Tag,Total,Frequency" |]
File.WriteAllLines("/Users/evelina/OtherProjects/StackOverflow/data/countries-tags-counts.csv", tagCountryStr)

open XPlot.GoogleCharts
open MathNet.Numerics.Statistics

let findOutliers (countryFreq : (string * float)[]) = 
  let stat = new DescriptiveStatistics(countryFreq |> Array.map snd)
  let std = stat.StandardDeviation
  let avg = stat.Mean
  countryFreq 
  |> Array.filter (fun (c,n) -> n > 2.0*std)

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

getTagCounts "c#" |> Chart.Geo
getRelativeCounts "c#" |> smoothOutliers |> Chart.Geo
getRelativeCounts "python" |> smoothOutliers |> Chart.Geo

