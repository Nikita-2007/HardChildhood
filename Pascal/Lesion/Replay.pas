program Yrock_Replay;

var
  x: integer;
  statarr: array [0..5] of integer;

begin
  write('Введите число ');
  read(x);
  if (x < 100) and (x > 0)
    then writeln('x < 100')
  else writeln('x > 100');
  while x > 0 do
  begin
    x := x - 1;
    writeln(x);
  end;
  statarr[0] := 111;
  writeln(statarr[0]);
  
  writeln();
  writeln(5.555);
  writeln(trunc(5.555));
  writeln(round(5.555));
  writeln();
  writeln(IntToStr(5)+5);
  writeln(FloatToStr(5.555)+5);
end.