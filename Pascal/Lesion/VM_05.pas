program VM_05;
var x, j:integer;
       n:string;
begin
readln(x);
while x > 0 do
begin
  n := n + x mod 10;
  x := x div 10;
end;
writeln(n);
end.