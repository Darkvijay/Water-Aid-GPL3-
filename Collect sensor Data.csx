special thanks to Aurdino and my team members Nisha & Paras for collabrating.
Serial.println("Taking Sample");
 Serial.println("________________________________________");
 Serial.println("Taking Sample");
 Serial.println("  OK - Warming Up");
 delay(6000); // delay for sensor calibration
 colourLED(50);
 Serial.println("  OK - Taking Sample");
 Serial.print("  ");
 for (int i = 0; i < 16; i++)
 {
   if (mode == 1)
   {
     strip.setPixelColor(i, strip.Color(0, 255, 0));
     strip.show();
   }
   else
   {
     strip.setPixelColor(i, strip.Color(0, 0, 255));
     strip.show();
   }
   // going to take multiple water samples - sensors not that precise
   waterTurbidity += getWaterTurbidity();
   waterPh += getWaterPh();
   if (i > 14)
   {
     // take a single sample for high precision sensors
     waterTemperature = getWaterTemp();
     atmoTemperature = getAtmoTemp();
     atmoHumidity = getAtmoHumidity();
   }
   Serial.print(".");
   delay(500);
 }
 Serial.println("");
 Serial.println("  Success - Samples Taken");
 for (int i = 0; i <= 16; i++)
 {
   strip.setPixelColor(i, strip.Color(0, 0, 0));
   strip.show();
   delay(30);
 }
 Serial.println("________________________________________");
 Serial.println("");
 delay(500);
