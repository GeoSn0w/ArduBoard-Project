#define LM35_PIN 0 //We're talking A0 and LM35 Temp sensor
//Created by GeoSn0w
//WTFPL license

float temperature = 0;
int sensor_data = 0; 

void setup() { 
  Serial.begin(9600); 
} 
void loop() { 
  tempfromsensor();
  Serial.println(temperature); 
  delay(500); //Delay 0.5 sec
}
void tempfromsensor(){
  sensor_data = analogRead(LM35_PIN);
  temperature = (sensor_data * 0.0049) *100; //Convert to Celsius degrees
}
