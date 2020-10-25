program prog02;
var
  x, l, temp:integer;
  arr: array of integer;

begin
read(x);
temp := x;
while true do
begin
x := x div 10;
if x >= 0 then l := l+1
else
  break;
end;
setLength(arr, l);

for var i := 0 to l-1 do
begin
  arr[i] := x mod 10;
  x := x div 10;
end;

for var i := 0 to l-1 do
  for var j := i to l-1 do
  begin
  if arr[i] < arr[j] then
    begin
      temp := arr[i];
      arr[i] := arr[j];
      arr[j] := temp;
    end;
  end;
x := 0;
for var i := 0 to l-1 do
begin
  x := x*10 + arr[i];
end;

write(x);
end.