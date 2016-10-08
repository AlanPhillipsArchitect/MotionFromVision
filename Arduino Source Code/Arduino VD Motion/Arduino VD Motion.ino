//7.20

//#include <SerialReciever.h>

int pulseoutpin = 3;
int led = 2;
int dir = 6;  // The direction output
int inbyte = 100;   // for incoming serial data
int i = 0;
int j = 0;
float acc = 600;

float distcount = 0;
char data;
bool on = false;
String str;



void setup() 
{  
  
  Serial.begin(9600);
        pinMode(led, OUTPUT);   // initialize the digital pin as an output.  
        pinMode(dir, OUTPUT);
        
}

void loop() {
  
  
  
  
  
  
  if(str == "on" || on == true)
     {
      //stepper();
      digitalWrite(led,HIGH);
   delayMicroseconds(2);
   digitalWrite(led,LOW);
  delayMicroseconds(inbyte);
  on=true;
  }

  if(str == "off"){
   on=false; 
   //Serial.write(data);   
  }
  
  if(str == "slow")
  {
    inbyte = 60;
  }
  if(str == "fast")
  {
    inbyte = 10;
  }
  
  if(str == "arot")
  {
    digitalWrite(dir,HIGH);
    Serial.print(str);
  }
  if(str == "rot")
  {
    digitalWrite(dir,LOW);
    Serial.print(str);
  }
  str = "";
  
}

void serialEvent(){
  while(Serial.available() > 0)
  { 
//  data = Serial.read();
//  
//  
//  str.concat(data);
//  
//  
//  inbyte = str.toInt();
  
  str = Serial.readString();
  //data =   Serial.parseInt();
  //Serial.print(str);
  
  }
}



//
//void movestep(){
//  
//  if (data  = 1)
//      {
//    while(distcount < 3000){
//  digitalWrite(led,HIGH);
//   delayMicroseconds(10);
//   digitalWrite(led,LOW);
//  delayMicroseconds(700);
//distcount = distcount + 1;
//    }
//
//}
//}
//
void stepper()
{
    if(distcount < 180000)
 {  
          if(acc > 11)
        {acc = acc-0.5;
        }  
          
          //Turn on an LED
          //digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)
          for(i=1;i<acc;i++)
          { 
            PORTD &= ~(1<<2);  
           
          }                   
          for(j=1;j<2;j++)//5000
          { 
            PORTD |= 1<<2; // Set Pulse bit 2 high  
////      
          }   
         distcount = distcount + 1; 
 } 
}
////
//

  
  
 


//switch(data)
// {
//  case '1': on = 1;
//  break;
//  case '2': on = 2;
//  break;
// } 
