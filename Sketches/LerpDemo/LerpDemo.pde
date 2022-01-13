void setup(){
  size(500,500);
}


void draw(){
  background(128);
  
  float p2 = mouseY/ (float)height;
  
  float w = lerp(1, 50, p2);
  
  strokeWeight(w);
  
  float p = mouseX/ (float)width;
  
  
  float d = lerp(50, 500, p);
  
  ellipse(width/2, height/2, d, d);
  
}
