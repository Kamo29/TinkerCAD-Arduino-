// C++ code
//
int photoSensor = 0;

void setup()
{
  pinMode(A0, INPUT);
  Serial.begin(9600);
  pinMode(3, OUTPUT);
}

void loop()
{
  photoSensor = analogRead(A0);
  Serial.println(photoSensor);
  analogWrite(3, map(photoSensor, 0, 1023, 0, 255));
  //digitalWrite(3, HIGH);
  delay(100); // Wait for 1000 millisecond(s)
}
