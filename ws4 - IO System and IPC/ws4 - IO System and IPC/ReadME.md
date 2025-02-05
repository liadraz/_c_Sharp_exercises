
# Process Ping Ping Exercise

Create 2 applications - Ping & Pong
* using a named pipe
* using an anonymous pipe
* using a mapped_file

## Named Pipe
A form of IPC that allows data to be exchanged between processes on the same machine or over a network.
Named Pipes provide a way for a server process and one or more client processes to communicate using a named resource.

### Server Side
 * Create a Server, instantiate NamedPipeServerStream with direction OUT
 * Waiting for Client connection
 * reading/writing, using StreamWriter or StreamReader
 * Disconnecting, use 'using' statement to discoonect automatically

### Client Side
 * Create a Client, instantiate NamedPipeClientStream with direction IN
 * Connecting to the named Pipe server
 * reading/writing, using StreamWriter or StreamReader
 * Closing the connection

## Anonymous Pipe
A form of IPC that are limited to communication between processes on the same machine. 
Anonymous pipes do not have a name, and their scope is restricted to the parent and child processes. 
They are simpler and typically used for one-way communication.

### Parent Process
 * Instantiate AnonymousPipeServerStream with direction OUT
 * Share the pipe's handle with the child process via GetClientHandleAsString()
 * Write data to the pipe using a StreamWriter
 
### Child Process
 * Get the pipe handle
 * Connects to the parent process using AnonymousPipeClientStream with the provided handle
 * Reads the data sent by the parent process using a StreamReader.
NOTE Since anonymous pipes are unidirectional, you must create separate pipes for two-way communication.

## Mapped File


# Text File Comparison Exercise

Make an application that receives the path of two text files 
and prints the lines that are different between them to the screen. 