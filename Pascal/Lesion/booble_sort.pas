program booble_sort;

uses GraphABC;

const
  M = 100;

var
  r, k: integer;
  arr: array [1..M] of integer;

procedure print;
begin
  for var i := 1 to M do write(arr[i], ' ');
end;

begin
  
  for var i := 1 to M do arr[i] := random(0, 999);
  
  
  
  print;
  writeln;
  writeln;
  for var i := 1 to M do
  begin
    pen.color := RGB(255, 0, 0);
    setBrushColor(RGB(0, 0, 0));
    Rectangle(15 + i * 6, 460, 19 + i * 6, 460 - arr[i] div 3);
    sleep(20);
    setBrushColor(RGB(255, 255, 255));
  end;
  //COPTUPOBKA
  k := M;
  for var j := 1 to M - 1 do
  begin
    k := k - 1;
    for var i := 1 to k do
    begin
      if arr[i] > arr[i + 1] then
      begin
        r := arr[i];
        arr[i] := arr[i + 1];
        arr[i + 1] := r;
      end;
    end;
  end;
  
  print;
  
end.