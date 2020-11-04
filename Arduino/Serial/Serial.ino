char received;
int red=17;
int green=18;
int blue=19;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()){
    received = Serial.read();
    if (received == '1') {
      digitalWrite(red,HIGH);
    }else if (received == '2') {
      digitalWrite(red,LOW);
    }else if (received == '3') {
      digitalWrite(green,HIGH);
    }else if (received == '4') {
      digitalWrite(green,LOW);
    }else if (received == '5') {
      digitalWrite(blue,HIGH);
    }else if (received == '6') {
      digitalWrite(blue,LOW);
    }
    Serial.println("OK");
  }
}