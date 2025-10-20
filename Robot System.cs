// C++ code
//
void setup()
{
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(13, OUTPUT);
}

int redN = 2;
int yellowN = 3;
int greenN = 4;
int redE = 5;
int yellowE= 6;
int greenE = 7;
int redS = 8;
int yellowS = 9;
int greenS = 10;
int redW = 11;
int yellowW = 12;
int greenW = 13;

void loop() 

{
  // Traffic Light Sequence for North-South
  digitalWrite(greenN, HIGH);
  digitalWrite(redS, HIGH);
  delay(2000);
 
  digitalWrite(greenN, LOW);
  digitalWrite(yellowN, HIGH);
  delay(2000);
 
  digitalWrite(redN, HIGH);
  digitalWrite(yellowN, LOW);
  delay(2000);
 
  digitalWrite(greenS, HIGH);
  digitalWrite(redS, LOW);
  delay(2000);
 
  digitalWrite(greenS, LOW);
  digitalWrite(yellowS, HIGH);
  delay(2000);
 
  digitalWrite(yellowS, LOW);

  // Traffic Light Sequence for East-West
  digitalWrite(greenE, HIGH);
  digitalWrite(redW, HIGH);
  delay(2000);
 
  digitalWrite(greenE, LOW);
  digitalWrite(yellowE, HIGH);
  delay(2000);
 
  digitalWrite(yellowE, LOW);
  digitalWrite(redE, HIGH);
  delay(2000);
 
  digitalWrite(redW, LOW);
  digitalWrite(greenW, HIGH);
  delay(2000);
 
  digitalWrite(greenW, LOW);
  digitalWrite(yellowW, HIGH);
  delay(2000);
 
  digitalWrite(yellowW, LOW);
}
