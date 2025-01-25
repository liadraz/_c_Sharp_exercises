
# Requirements

Create 2 applications - Ping & Pong
* using a named pipe
* using an anonymous pipe
* using a mapped_file

## Named Pipe
### Server Side
    * Create a Server, instantiate NamedPipeServerStream
    * Waiting for Client connection
    * reading/writing, using StreamWriter or StreamReader
    * Disconnecting, use 'using' statement to discoonect automatically

### Client Side
    * Create a Client, instantiate NamedPipeClientStream
    * Connecting to the named Pipe server
    * reading/writing, using StreamWriter or StreamReader
    * Closing the connection

## Anonymous Pipe

## Mapped File