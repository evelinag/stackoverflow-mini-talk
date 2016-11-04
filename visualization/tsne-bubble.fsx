
#r "node_modules/fable-core/Fable.Core.dll"
#load "node_modules/fable-import-d3/Fable.Import.D3.fs"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser

let width, height = 1000., 700.
let size = width, height
let margin = 100.

let inline f2 (f: 'a->'b->'c) = Func<_,_,_> f
let inline f3 (f: 'a->'b->'c->'d) = Func<_,_,_,_> f

[<Emit("(function(a,b,c) { var t=this; return $0(t)([a,b,c]); })")>]
let withThis(f:'T -> ('T1 * 'T2 * 'T3) -> 'R) : Func<'T1', 'T2, 'T3', 'R> = failwith "!" 

let svg = 
  D3.Globals.select("body")
    .append("svg")
    .attr("width", unbox<D3.Primitive> (width + 2.0*margin) )
    .attr("height", unbox<D3.Primitive> (height + 2.0*margin) )
    .attr("class", unbox<D3.Primitive> "graph-svg-component")

let scaleX xmin xrange x =
    let xscale = (x - xmin)/xrange
    (xscale * width) + x + margin

let scaleY ymin yrange y =
    let yscale = (y - ymin)/yrange
    (yscale * height) + y + margin

let rNormal = unbox<D3.Primitive> 3
let rFocus = unbox<D3.Primitive> 10
let rSearch = unbox<D3.Primitive> 15

let draw data =

   console.log("begin drawing data")

   let xmin, xmax = 
     let ds = data |> Seq.map (fun d -> d?x |> unbox<float>)
     ds |> Seq.min, ds |> Seq.max
   let xrange = xmax - xmin

   let ymin, ymax = 
     let ds = data |> Seq.map (fun d -> d?y |> unbox<float>)
     ds |> Seq.min, ds |> Seq.max
   let yrange = ymax - ymin

   let circles =
    ((svg.selectAll("circle")
        .data(data |> unbox<obj[]>)
        |> unbox<D3.Selection.Update<obj>>)
        .enter()
        .append("circle")
        .attr("r", rNormal))
        .attr("cx", f3 (fun d _ _ -> unbox<D3.Primitive> (unbox<float> d?x |> scaleX xmin xrange) ) )
        .attr("cy", f3 (fun d _ _ -> unbox<D3.Primitive> (unbox<float> d?y |> scaleY ymin yrange)) )
        .on("mouseover", withThis(fun t _ -> 
            D3.Globals.select(t:string)
              .classed("focus", true)
              .attr("r", rFocus)
              |> unbox ))
        .on("mouseout", withThis(fun t _ -> 
            D3.Globals.select(t:string)
              .classed("focus", false)
              .attr("r", rNormal) |> unbox ))  
        .attr("id", f3 (fun d _ _ -> ("name" + unbox<string> d?tag) |> unbox<D3.Primitive> ))
   circles    
        .append("title")
        .text(f3 (fun d _ _ ->  unbox<D3.Primitive> d?tag ))
        |> ignore

   console.log("finished drawing data")
   ()

D3.Globals.json("data/ts.json", f2 (fun error data -> 
    if (unbox error) then error |> unbox |> raise
    else draw (data |> unbox<obj seq>)))

// Search for specific tag
let input = document.getElementById("tag") :?> HTMLTextAreaElement

let run() =
    D3.Globals.selectAll( "circle" ).classed("focus", false)
      .classed("search", false)
      .attr("r", rNormal)
    |> ignore


    D3.Globals.select( "circle[id='name\"" + input.value + "\"']" )
      .classed("search", true)
      .attr("r", rSearch)
    |> ignore

input.addEventListener_keyup(fun _ -> run(); box())