program massivi;
var
  statArr: array[0..5] of integer;
  dynArr: array of integer;
  x: byte;

begin
  statArr[0] := 111;
  writeln(statArr[0]);
  
  read(x);
  setlength(dynArr, x);
  dynArr[0] := 222;
  writeln(dynArr);
end.