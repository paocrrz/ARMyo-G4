// C++ code
//
#include <Wire.h>
#include <avr/interrupt.h>
volatile int frecuencia = 500;
void setup()
{

  DDRB = 0x00;
  PORTB = 0xC0;

  Wire.begin(1);
  Wire.onReceive(receiveEvent);
  Serial.begin(9600);
  TCCR0A = 0b00000010;
  TCCR0B = 0b00000001;
  TIMSK1 = (1<<OCIE1A);
  OCR1A = 15999;
}

void loop()
{
  
 
  delay(300);
}

ISR(TIMER1_COMPA_vect){
  PORTB ^= (1<<DDB1);

}

void receiveEvent(int howMany){
  char letra;
  if(Wire.available() == 1){
    letra = Wire.read();
    Serial.println(letra);
    Serial.println(frecuencia);

  }
  if(letra == 's'){
    frecuencia = frecuencia/2;
    if(frecuencia<125) frecuencia=125;
  }
  else if(letra == 'f'){
    frecuencia = frecuencia*2;
    if(frecuencia>8000) frecuencia=8000;
  }
  else if(letra == 'k'){
    frecuencia = 500;
  }
  else if (letra == 'e'){
    Serial.println("No se hizo nada");
  }
  OCR1A = ((16000000)/(2*1*frecuencia))-1;
}