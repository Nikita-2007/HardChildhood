program БМ;

    var x:word;
        r:word;

begin
    randomize;
    r := Random(0,1000);
    writeln ('Я задумал число, угодай его');
 Repeat
   readln (x);
    if x > r then
     writeln ('Моё число Меньше')
    else if x < r then
     writeln ('Моё число Больше')
    else writeln ('Вы угодали число')
 until x = r;
  end.