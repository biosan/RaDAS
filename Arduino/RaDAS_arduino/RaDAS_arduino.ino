/*
---RaDAS Arduino Software---

Developed by Alessandro Biondi (aka BioSan) and 
Lancia Stefano at IIS C.Rosatelli.

Thanks to Prof. Sergio Pantaloni

Please contact us for info and bugs at:
      biosan222@gmail.com

Schematics, App and Arduino source code at:
      http://github.com/biosan/RaDAS

*/

//-----Defining parameters-----
#define sPins 3    // define the number.
#define numberOfSensors 6    // define the number of sensors.
#define interruptPin 0    // set the interrupt pin at 0 ( pin 2 ).
#define freqTimer 15625  // timer1 clock frequency f=16Mhz/1024=15625Hz ( prescaler setted at 1024 ).
//-----Constants-----
const int numberOfIntervals = 5;//numberOfSensors-1;
const int selectMuxPins[sPins] = {5, 6, 7};  // set the selection/address pins of the demux, {A0, A1, A2}.
//-----Variables-----
byte counter = 0;    // counter variable.
boolean count=false;
byte prevCounter = 0;    // store the previous value of counter.
//-----Data-----
unsigned long times[numberOfSensors] = {0, 0, 0, 0, 0, 0};    // data vector used to store passages times.
//--------------

void setup()
{
  //---setup timer---
  TCCR1A = 0x00; // normal operation page 148 (mode0).
  TCCR1B = 0x00;
  //-----------------
  attachInterrupt(interruptPin, firstCross, RISING);  // set first interrupt function on pin 2 (interrupt 0) as interrupt on rising edge.
  for(int i=0; i<sPins; i++)    // iterate over all mux's selection pins
  {
    pinMode(selectMuxPins[i], OUTPUT);    // set all mux selction pins as output
    digitalWrite(selectMuxPins[i], LOW);    // set all mux selction pins LOW
  }
  Serial.begin(9600);
}

void loop()
{
  countLoop();
  delay(20);
}

long instant = 0;
long prev_inst = 0;
long diff = 0;

void cross()
{
  instant = micros();
  diff = instant - prev_inst;
  if(diff > 10000)
  {
    times[counter]+=TCNT1;    // store the value of the atmega's 328 TIMER1 16-bit counter in times[] array. Use counter as index.
    //Serial.println(TCNT1);
    TCNT1 = 0;    // reset the TIMER1 so it restart count from 0.
    counter++;    // increase counter.
    prev_inst = instant;
  }
}

void firstCross()
{
  TCNT1 = 0;        // reset the TIMER1 so it restart count from 0.
  TIMSK1 |= 1;      // enable global and timer overflow interrupt;
  TCCR1B = 0x05;    // set timer1 prescaler at 1024, f=16Mhz/1024=15625Hz.
  delay(200);
  detachInterrupt(interruptPin);
  attachInterrupt(interruptPin, cross, RISING);    // set a new interrupt function
  count = true;
  counter++;
  digitalWrite(selectMuxPins[0], HIGH);
  digitalWrite(selectMuxPins[1], LOW);
  digitalWrite(selectMuxPins[2], LOW);
}

//-----timer1 overflow interruput function-----
ISR(TIMER1_OVF_vect)
{
  times[counter] += 0xFFFF;    // increment the current time variable in array times[] by 65536
}
//---------------------------------------------

void countLoop()
{
  while(counter != numberOfSensors)
  {
    delay(1);
    if(counter != prevCounter)    // if counter has been incresed by the interrupt.
    {
      for(int i=0; i<(sPins+1); i++)    // used iterate over the mux's selection/address pins (setted in selectDemuxPins array).
      {
        digitalWrite(selectMuxPins[i], bitRead(counter, i));    // set mux selection/address pins as the least-significant 3-bits of counter byte.
      }
      prevCounter = counter;    // assign counter value to prevCounter so the if condition can be true only when counter increments again.
    }
  }
  counter = 0;
  prevCounter = 0;
  count = false;
  //-----Code to disable counting-----
  detachInterrupt(interruptPin);
  attachInterrupt(interruptPin, firstCross, RISING);  // set first interrupt function on pin 2 (interrupt 0) as interrupt on rising edge.
  TCNT1 = 0;
  TCCR1A = 0x00; // normal operation page 148 (mode0).
  TCCR1B = 0x00; // stop timer1 ( set clock to 0 ).
  TIMSK1 = 0;
  digitalWrite(selectMuxPins[0], LOW);
  digitalWrite(selectMuxPins[1], LOW);
  digitalWrite(selectMuxPins[2], LOW);
  sendData();
}

void sendData()
{
  for(int i=0; i<(numberOfIntervals+1); i++)
  {
    Serial.print(times[i]);
    Serial.print("-");
    times[i] = 0;
  }
  Serial.print("\n");
}

