// Animate 3 electrons orbiting around a nucleus.
// Each electron should follow a path and match
// colors with its respective path.

// Don't use rotate()
// Use vectors and trigonometry

void setup(){
  size(400, 400);
}
void draw(){
  
  drawBackground();
  
  ///////////////// START YOUR CODE HERE:
  PVector e1 = new PVector();
  PVector e2 = new PVector();
  PVector e3 = new PVector();
  float time = (float)millis()/1000;
  
  e1.x = 150 * cos(time);
  e1.y = 50 * sin(time);
  
  float mag = sqrt(e1.x * e1.x + e1.y *e1.y);
  float ang = atan2(e1.y, e1.x) - radians(60);
  float ang2 = atan2(e1.y, e1.x) - radians(-60);
  
  e2.x = mag * cos(ang);
  e2.y = mag * sin(ang);
  
  e3.x = mag * cos(ang2);
  e3.y = mag * sin(ang2);
  
  noStroke();
  fill(255,100,100);
  ellipse(e1.x + 200, e1.y + 200, 20, 20);
  
  fill(100,255,100);
  ellipse(e2.x + 200, e2.y + 200, 20, 20);
  
  fill(100,100,255);
  ellipse(e3.x + 200, e3.y + 200, 20, 20);
  
  
  
  
  ///////////////// END YOUR CODE HERE
  
}
void drawBackground(){
  background(0);
  noStroke();
  fill(255);
  ellipse(200,200,50,50);
  noFill();
  strokeWeight(5);
  
  pushMatrix();
  translate(200,200);
  stroke(255,100,100);
  ellipse(0,0,300,100);
  popMatrix();
  
  pushMatrix();
  translate(200,200);
  rotate(PI/1.5);
  stroke(100,255,100);
  ellipse(0,0,300,100);
  popMatrix();
  
  pushMatrix();
  translate(200,200);
  rotate(2*PI/1.5);
  stroke(100,100,255);
  ellipse(0,0,300,100);
  popMatrix();
}
