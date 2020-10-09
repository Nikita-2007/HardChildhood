program VM_01;

var i, x, n:integer;

begin
n := 1;
readln(x);
while x > 0 do
begin
  x := x - n;
  n := n*2; 
  i := i+1;
end;
writeln(i);
end.