
float xStart = 20;
float xEnd = 780;

float timeTotal = 3;
float timeCurrent = 0;

float prevTime = 0;

void setup(){
  size(800, 500);
}

void draw(){
  background(64);
  
  float timeStamp = millis()/1000.0;
  float dt = timeStamp - prevTime;
  prevTime = timeStamp;
  
  timeCurrent += dt;
  
  float p = timeCurrent / timeTotal;
  p = constrain(p, 0, 1); //clamp
  
  float x = lerp(xStart, xEnd, p);
  
  ellipse(x, height/2, 30, 30);
  
}

void mousePressed(){
 timeCurrent = 0; 
}
