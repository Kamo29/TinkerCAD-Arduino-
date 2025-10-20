#include <LiquidCrystal_I2C.h>

// C++ code
//Human Detector

int switchState = 0;
LiquidCrystal_I2C lcd(32, 16,2);

void setup()
{
  lcd.begin(16, 2);
  pinMode(3, OUTPUT);
  pinMode(4, INPUT);
  pinMode(5, INPUT);
  pinMode(6, OUTPUT);
  lcd.init();
  lcd.setCursor(0,0);
  lcd.backlight();
  lcd.display();
  Serial.begin(9600);
}

void loop()
{
  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  digitalWrite(6, LOW);
  
  int sensor = digitalRead(4);
  int switchState = digitalRead(5);
  Serial.println(sensor);
  
  if(sensor == HIGH)
  {
    digitalWrite(3,HIGH);
    digitalWrite(6,HIGH);
    tone(6, 220, 100);
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("ALERT");
    lcd.setCursor(0,1);
    lcd.print("HUMAN DETECTED");
    delay(1000);
    
    if(switchState == LOW)//if button is pressed
  	{
    	digitalWrite(3, LOW);
      	digitalWrite(6, LOW);
    	lcd.clear();
      	lcd.setCursor(0, 0);
  		lcd.print("System Reset");
  		delay(2000);
    }
  }
  
  else
  {
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("NONE");
    lcd.setCursor(0,1);
    lcd.print("DETECTED");
    delay(1000);
  }
  
  delay(10);
}
