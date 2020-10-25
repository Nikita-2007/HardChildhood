program VM_04;

var x, n, i:integer;

begin
readln(x);
while x > 0 do
begin
  x := x div 10;
  i := i+1;
end;
write(i);
end.