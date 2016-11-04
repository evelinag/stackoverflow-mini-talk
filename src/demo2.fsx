#load "config.fs"
#load "packages/FsLab/FsLab.fsx"

open FSharp.Data

[<Literal>] 
let BingSample = 
    "http://dev.virtualearth.net/REST/v1/Locations?query=Prague&includeNeighborhood=1&maxResults=5&key=" + GeoSearch.bingKey

    