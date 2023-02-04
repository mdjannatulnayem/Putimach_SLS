#include <SPI.h>
#include <LoRa.h>

String data,_cmdString;
bool launched,terminated;
long interval = 2000;
long lastSendTime = 0;
byte localAddress = 0xAA;
byte destinationAddress = 0xBB;
long count = 0;

void setup() 
{
  Serial.begin(9600);
//  Serial.println("Start LoRa duplex");
  if (!LoRa.begin(433E6)) {
//    Serial.println("LoRa init failed. Check your connections.");
    while (true) {}
  }
  launched = false;
  pinMode(6,OUTPUT);
}

void loop() 
{
  if(Serial.available() > 0)
  {
    _cmdString = Serial.readString();
  }

  if (millis() - lastSendTime > interval) 
  {
    sendMessage(_cmdString);
//    Serial.print("Sending data " + _cmdString);
//    Serial.print(" from 0x" + String(localAddress, HEX));
//    Serial.println(" to 0x" + String(destinationAddress, HEX));
    lastSendTime = millis();
    interval = random(500) + 1000;
  }
    
    receiveMessage(LoRa.parsePacket());

    //Preplanned delay!
    if(count >= 5000){
      Serial.println(data);
      count = 0;
    }

    count += 1; //Iterate on each loop!
}

void sendMessage(String outgoing) {
  LoRa.beginPacket();
  LoRa.write(destinationAddress);
  LoRa.write(localAddress);
  LoRa.write(outgoing.length());
  LoRa.print(outgoing);
  LoRa.endPacket();
}

void receiveMessage(long int packetSize) {
  if (packetSize == 0) return;

  long int recipient = LoRa.read();
  byte sender = LoRa.read();
  byte incomingLength = LoRa.read();

  String incoming = "";

  while (LoRa.available()) {
    incoming += (char)LoRa.read();
  }

 if (incomingLength != incoming.length()) {
//    Serial.println("Error: Message length does not match length");
   return;
 }

 if (recipient != localAddress) {
//    Serial.println("Error: Recipient address does not match local address");
   return;
 }

  data = incoming;

  launched = data != "1" ? false : true;

//  Serial.print("Received data " + incoming);
//  Serial.print(" from 0x" + String(sender, HEX));
//  Serial.println(" to 0x" + String(recipient, HEX));
}
