// C++ code

// create an array of notes

// the numbers below correspond to the frequencies of middle C, D, E, and F
//int notes[] = {262, 294, 330, 349};

//Mario main them tempo
int tempo[] = {
  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,

  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,

  9, 9, 9,
  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,

  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,

  9, 9, 9,
  12, 12, 12, 12,
  12, 12, 12, 12,
  12, 12, 12, 12,
};

void setup()
{
  //start serial communication
  Serial.begin(9600);
  pinMode(A0, INPUT);
  pinMode(A1, INPUT);
  pinMode(A2, INPUT);
  pinMode(A3, INPUT);
  pinMode(8, OUTPUT);
}
void loop() 
{
  // if button press on A0 is detected
  if (digitalRead(A0) == HIGH) 
  {
    //tone(8, 440, 100); // play tone 57 (440 Hz)
  }
  // if button press on A1 is detected
  if (digitalRead(A1) == HIGH) 
  {
    tone(8, 494, 100); // play tone 59 (494 Hz)
  }
  // if button press on A0 is detected
  if (digitalRead(A2) == HIGH) 
  {
    tone(8, 523, 100); // play tone 60 (523 Hz)
  }
  if (digitalRead(A3) == HIGH) 
  {
    tone(8, 550, 100); // play tone 60 (550 Hz)
  }
  delay(5); // Delay a little bit to improve simulation performance

}
