Program Чёт_не_чёт;

var X,Y:integer;
label m;

begin
  
  m:
  writeln ('Введите число');
  read (X);
  Y := X mod 2;
  if Y = 0 then
    begin
    writeln ('Ваша число чёткое');
    goto m;
    end
    else
      begin
      writeln ('Ваша число не чёткое');
  goto m;
  end
  
end.