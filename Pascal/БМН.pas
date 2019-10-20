program БМН;

var a,b,x,k,y:integer;
label m;

begin
  a := 0;
  b := 1000;
  writeln ('-Задумайте число от 1 до 1000 а я попытаюсь его отгодать');
  m:
  k := k + 1;
    write ('-Ваше число попыток: ');
    writeln (k);
    writeln ('0-Больше');
    writeln ('1-Меньше');
    writeln ('Любое другое число/буква-Угодал');
    x := (b - a) div 2 + a;
    write ('-');
    writeln (x);
    read (y);
case y of
      0:
      begin
      writeln ('-Нет, больше');
      a := x
      end;
      1:
      begin
      writeln ('-Нет, меньше');
      b := x
      end;
      else
        writeln ('-Да');
        writeln ('-Я победил');
end;
  goto m;  

end.