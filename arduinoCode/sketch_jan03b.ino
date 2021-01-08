int ledPin = 13; 
void setup() 
{ 
  pinMode(ledPin, OUTPUT); 
  Serial.begin(9600); 
  Serial.setTimeout(10);
} 
void loop() 
{ 
  if (Serial.read() == '1') 
  { 
    digitalWrite(ledPin, HIGH); 
  } 
  else if (Serial.read() == '0') 
  { 
    digitalWrite(ledPin, LOW); 
  } 
} 