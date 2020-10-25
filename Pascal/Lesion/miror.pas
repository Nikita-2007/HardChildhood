program miror;

const
    M = 10;
    
var r:integer;
  arr: array [1..M] of integer;
  
  
 
begin
  
for var i := 1 to M do arr[i] := i * 2;
for var i := 1 to M do write(arr[i], ' ');
writeln;
writeln;

//3EPKALO
  for var i := 1 to M div 2 do
  begin
  r := arr[i];
  arr[i] := arr[M -i+1];
  arr[M -i+1] := r;
  end;
   
  for var i := 1 to M do write(arr[i], (' '));
  
end.