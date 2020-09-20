program Yrock_Replay;

var x:integer;

begin
  write('Введите число ');
  read(x);
  if (x < 100) and (x > 0)
  then writeln('x < 100')
  else writeln('x > 100');
  while x > 0 do
  begin
    x := x - 1;
    writeln (x);
  end;
end.