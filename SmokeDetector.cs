# define RED 4
# define Buzzer 5
# define Gas_SENSOR A0
#define Button 3


#include <Adafruit_LiquidCrystal.h>

Adafruit_LiquidCrystal lcd(0);

//CODE LOGIC: If no gas - green light on
//             If small amount of gas detected - Orange warning will glow for 2 seconds
//             Heavy smoke detected: Red light ON with Buzzer for 10 mins straight until RESET, then back to normal OP

void setup()
{
  lcd.begin(16, 2);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(A0, INPUT);
  pinMode(Button, INPUT_PULLUP);
  
  lcd.setCursor(0, 0);
  lcd.print("System Ready");
  delay(2000);
  lcd.clear();
  
  Serial.begin(9600);
}

void loop()
{
  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  
  int SIN = analogRead(A0);
  
  Serial.println(SIN);
  
  if(SIN>20){
  digitalWrite(RED, HIGH);	
  digitalWrite(Buzzer, HIGH);
  tone(5, 220, 100);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("ALERT! SMOKE!");
  lcd.setCursor(0, 1);
  lcd.print("EVACUATE NOW!");
  delay(1000);
   
  if (digitalRead(Button) == HIGH) {
  digitalWrite(RED, LOW);     // Turn off red LED
  digitalWrite(Buzzer, LOW);  // Turn off buzzer
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("System Reset");
  delay(2000);  // Wait 2 seconds after reset

  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("System Ready");
  }
  }
  
  else 
  {
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("System Ready");
  lcd.setCursor(0, 1);
  lcd.print("No Smoke");
  }
  
  delay(10);
}
