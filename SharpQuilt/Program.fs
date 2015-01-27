// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

namespace SharpQuilt.Server

open SharpQuilt.Server
open System.Configuration
open System

module test = 
    [<EntryPoint>]
    let main argv = 

        let reader = new AppSettingsReader()

        let port : int = Convert.ToInt32(reader.GetValue("port", typedefof<Int32>))
                                              
        let s = Server(port)
        s.Start()
                                
        0 // return an integer exit code
