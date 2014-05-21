const int numberOfIntervals=7;
//-----DATA-----
unsigned int times[numberOfIntervals]={0, 6000, 6000, 6000, 6000, 6000, 6000};
byte timesOverflow[numberOfIntervals]={0,0,0,0,0,0,0};
unsigned int out;

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  delay(1000);
  for(int i=0; i<numberOfIntervals; i++)
  {
    out=timesOverflow[i]*65536+times[i];
    Serial.print(out);
    Serial.print("-");
  }
  Serial.print("\n");
}
