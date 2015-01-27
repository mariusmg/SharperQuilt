namespace SharpQuilt.Server


open System
open System.Net
open System.Collections.Generic

type Server(port : int) =
     class      
         let source  = new Dictionary<String,string>()
                
         let socket = new Sockets.TcpListener(port)
         
         member this.Start() = 

                socket.Start()
                
                Console.WriteLine("start server")
            
          member this.Stop()=
                Console.WriteLine("stopped server")
                
     end
