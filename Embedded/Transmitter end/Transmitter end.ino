#include <SPI.h>
#include <LoRa.h>
#define relay_pin 8

String statusString;
byte localAddress = 0xBB;
byte destinationAddress = 0xAA;
long lastSendTime = 0;
long int interval = 2000;
long int count = 0;
bool relay;float i;
bool launched,terminated;

void setup() {
  Serial.begin(9600);
  Serial.println("Start LoRa duplex");
  Serial.print("Local address: ");
  Serial.println(String(localAddress, HEX));
  Serial.print("Destination address: ");
  Serial.print(String(destinationAddress, HEX));

  if (!LoRa.begin(433E6)) {
    Serial.println("LoRa init failed. Check your connections.");
    while (true) {}
  }
  pinMode(relay_pin,OUTPUT);
}

void loop()
{
  //Read command  
  receiveMessage(LoRa.parsePacket());

  //Take action
  digitalWrite(relay_pin,relay);  
  
  //Send feedback
  if (millis() - lastSendTime > interval) {
    statusString = String(relay);
    sendMessage(statusString);

    Serial.print("Sending data " + statusString);
    Serial.print(" from source 0x" + String(localAddress, HEX));
    Serial.println(" to destination 0x" + String(destinationAddress, HEX));

    lastSendTime = millis();
    interval = random(759) + 1000;
  }
  
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
    Serial.println("Error: Message length does not match length");
    return;
  }

  if (recipient != localAddress) {
    Serial.println("Error: Recipient address does not match local address");
    return;
  }
  
  relay = incoming == "L" ? true : false;

  Serial.print("Received data " + incoming);
  Serial.print(" from 0x" + String(sender, HEX));
  Serial.println(" to 0x" + String(recipient, HEX));
}
