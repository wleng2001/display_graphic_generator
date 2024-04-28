#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 64 // OLED display height, in pixels

// Declaration for an SSD1306 display connected to I2C (SDA, SCL pins)
// The pins for I2C are defined by the Wire-library. 
// On an arduino UNO:       A4(SDA), A5(SCL)
// On an arduino MEGA 2560: 20(SDA), 21(SCL)
// On an arduino LEONARDO:   2(SDA),  3(SCL), ...
#define OLED_RESET     -1 // Reset pin # (or -1 if sharing Arduino reset pin)
#define SCREEN_ADDRESS 0x3C ///< See datasheet for Address; 0x3D for 128x64, 0x3C for 128x32
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

const uint8_t PROGMEM tabNameWidth = 10;
const uint8_t PROGMEM tabNameHeight = 10;
const unsigned char PROGMEM tabName[] = {
  0b01010101, 0b010000000, 
  0b10101010, 0b100000000, 
  0b01010101, 0b010000000, 
  0b10101010, 0b100000000, 
  0b01010101, 0b010000000, 
  0b10101010, 0b100000000, 
  0b01010101, 0b010000000, 
  0b10101010, 0b100000000, 
  0b01010101, 0b010000000, 
  0b10101010, 0b100000000, 
};

void setup() {
  display.begin(SSD1306_SWITCHCAPVCC, SCREEN_ADDRESS);
  display.display();
  display.clearDisplay();
  display.setTextSize(2);      // Normal 1:1 pixel scale
  display.setTextColor(SSD1306_WHITE);
  display.print("Hello World!!!");
  display.display();
  delay(1000);
  display.clearDisplay();
  for(int j = 0; j<display.height(); j+=tabNameHeight){
    for(int i = 0; i<display.width();i+=tabNameWidth-1){
      display.drawBitmap(i, j, tabName, tabNameWidth, tabNameHeight, 1);
    }
  }
  display.display();
}

void loop() {
  // put your main code here, to run repeatedly:

}
