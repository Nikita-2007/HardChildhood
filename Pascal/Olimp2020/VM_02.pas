program VM_02;

var i, x, n:integer;

begin
n := 1;
readln(x);
while i < x do
begin
  n := n*2; 
  i := i+1;
end;
writeln(n);
end.