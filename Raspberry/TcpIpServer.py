#pip3 install pyserial

from socket import *
import serial

arduinoPort = '/dev/ttyACM0'
serialPort = serial.Serial(arduinoPort, 9600)

# host = "192.168.0.10"
host = "192.168.0.45"
# host = "127.0.0.1"
port = 7999        # PortNum

serverSocket = socket(AF_INET, SOCK_STREAM)             # create socket
serverSocket.bind((host,port))                          # HOST and PORT mapping
serverSocket.listen(1)                                  # connect waiting
print("Waiting...") 

connectionSocket,addr = serverSocket.accept()           # 

print(str(addr),"Conecting Success.")

over = False

while not over:
    data = connectionSocket.recv(1024)
    data = data.decode("utf-8")
    print("received Data :", data)
    if data=='close':
        serverSocket.close()
        over = True
    else:
        if data=='1':
            sentData = 'RED ON'
        elif data=='2':
            sentData = 'RED OFF'
        elif data=='3':
            sentData = 'GREEN ON'
        elif data=='4':
            sentData = 'GREEN OFF'
        elif data=='5':
            sentData = 'BLUE ON'
        elif data=='6':
            sentData = 'BLUE OFF'
        else:
            sentData = 'ERROR!'
    
        serialPort.write(data.encode())
        serialResult = serialPort.readline().decode()
        if serialResult == "OK":
            pass
        print(serialResult,end='')
        connectionSocket.send(("server : " + sentData).encode("utf-8"))
    