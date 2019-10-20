program grafika;
uses GraphABC; 

begin
  
  
  pen.color := RGB (8, 213, 200);
  Brush.Color := RGB (8, 213, 200);
  FillEllipse (100,50,500,300);
  pen.color := RGB (0,0,0);
  Brush.Color := RGB (8, 213, 200);
  FillEllipse (200,200,400,450);
  pen.color := RGB (0,0,255);
  DrawCircle (100,100,100);
  
end.