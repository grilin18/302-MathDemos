
void setup(){
  size(500, 500);
}


void draw(){
  background(0);
  
  float d = mappy(mouseX, 0, width, 10, 400);
  
  ellipse(width/2, height/2, d, d);
  
}


float lerpy(float min, float max, float p){
  return (max - min) * p + min;
}

float mappy(float val, float inMin, float inMax, float outMin, float outMax){
  
  float p = (val - inMin) / (inMax - inMin);
  return lerpy(outMin, outMax, p);
}
