namespace SharpQuilt.Server

open System
open System.Net.Sockets
open System.Collections.Generic
open System.Threading

type Server(port : int) = 
    class
        let source = new Dictionary<String, string>()
        let thread = null
        let socket = new TcpListener(port)
        
        member this.Start() = 
            startServer
            Console.WriteLine("start server")
        
        member this.Stop() = Console.WriteLine("stopped server")


        member private this.startServer() = 
            thread = new Thread(fun () -> 
                        socket.Start()
                        while (true) do
                            //use networkStream : NetworkStream = socket.GetStream()
                            //                        let bytesFrom = new byte[10025]; 
                            //                        networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize); string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);                                                                 
             )
            ()

    end
