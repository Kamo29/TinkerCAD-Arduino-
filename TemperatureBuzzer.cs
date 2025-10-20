// C++ code
//
int sensorPin;
int baselineTemp = 50;

void setup()
{
  Serial.begin(9600);
  pinMode(A0, INPUT);
  pinMode(3, OUTPUT);
}

void loop()
{
  int sensorVal = analogRead(A0);
  Serial.print("Sensor Value: ");
  Serial.print(sensorVal);
  
  Serial.print("Degrees C: ");
  float voltage = (sensorVal / 1024.0) * 5.0;
  float temp = (voltage - 0.5) * 100;
  Serial.println(temp);
  
  if(temp >= baselineTemp)
  {
    digitalWrite(3, HIGH);
    tone(8, 494, 100);
  }
  
  else if(temp <= baselineTemp)
  {
    digitalWrite(3, LOW);
  }
}
