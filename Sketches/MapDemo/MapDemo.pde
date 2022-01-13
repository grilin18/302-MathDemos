void setup(){
  size(500,500);
}

void draw(){
  background(128);
  
  //float p = mouseX / (float) width;
  //float a = lerp(0, 3, p); //angle in radians
  
  float a = map(mouseX, 0, width, 0, 3); //angle in radians
  
  pushMatrix();
  
  translate(width/2, height/2);
  
  rotate(a);
  
  rect(-200, -200, 400, 400);
  
  popMatrix();
}
