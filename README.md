# ArduBoard-Project
A C# Application which is basically a Date/Time with Temperature display from Arduino and LM35 Sensor
The C# program shows the Date and the Time using standard DateAndTime library of C#, and fetches the temperatures in Celsius degrees from the Arduino board. 

The Arduino board runs the code provided in the Arduino folder and it is basically connected to a LM35 Temperature sensor with the following pinout:

<center><img src="https://user-images.githubusercontent.com/15067741/28342221-d8e58e48-6c1f-11e7-9f56-fc17f8aac988.JPG"></center>

The C# Application listens to the COM PORT specified in the code or in the Settings panel. By default it uses COM20. You need to change that according to your Arduino Board.
The temperature is being fetched in real-time from the Arduino Board using a Background Worker (to avoid freezing of the UI).
The user interface looks like this, and it is of course, customizable:
<center><img src="https://user-images.githubusercontent.com/15067741/28342220-d8c47abe-6c1f-11e7-902f-f318481bc481.JPG"></center>

The C# tool also prints the current temperature in the Notification Tray on Windows. You can strip that code off if you don't need it.
<center><img src="https://user-images.githubusercontent.com/15067741/28342219-d899780a-6c1f-11e7-8431-f8b316c3d622.JPG"></center>

<B>Questions</B>
* Twitter: https://twitter.com/FCE365
* YouTube: https://youtube.com/fce365official
