os.setlocale('rus_rus.1251')
lib = require('lib')

text = [[
yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8?@yoy0?vyoy0v`ivo"N|ewy|8vNevN�eyGv�e`ewy|eG?@yoy0?vyoy0vNvki$iPiv8k`i�v6i6"`8v6e2yo8?@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8�@@�yN`i?v�yN`i?v`iv8#"Syve69w!v�yN`i?@iv6iSi`i0vNeNyoN|"0?v|i|v"v0`y?v`yvoevN`i?@|ew>?v|ew>ve$i#"v�ive|`e0vN|ew>?@$�i#"v`iv|8N|"v0`yvo8M8?vkoyvPyvw>?vkoyvPyvw>���@e`i?ve`i?ve`iv0y`9vNv80ivN�y#i?@e`i?ve`iv6e|eGv"v�e##v�i2$i#i?@"v6efy08vwi|vN#ioeNw`evewv2e#"?@6e�i2>#v9v�Nyv68w"?v6ewy$9#v6i$e#"+@@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8?@yoy0?vyoy0v`ivo"N|ewy|8vNevN�eyGv�e`ewy|eG?@yoy0?vyoy0vNvki$iPiv8k`i�v6i6"`8v6e2yo8?@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8�@@`8vfweveNe2y``ekev�vXweGv`yv6eG08veNe2yK@9v`"fykevNvNe2eGv6eoy#iw!?v`yvN6eNe2y`?@`yv�`i#v9?vfwev|v2yoyvwi|eGv`yv6$"N6eNe2#y`?@oiv8P?vwi|"0v|i|v9?v`yvoi#wv6$y0"#v'`e2y#!0�@`evNi0"v`ek"?v|v`yGv0y`9vN"#|e0v�yo8w?@`ivo"N|ewy|8?vNi0"?vNi0"v�v6#9Nv"o8w?@0y`9ve|8wi#ev2y�8oy$P`e0vw80i`e0?@�ewve`iv6$"M#iv##2e�!zve|eIe|e9``i9zzz@@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8?@yoy0?vyoy0v`ivo"N|ewy|8vNevN�eyGv�e`ewy|eG?@yoy0?vyoy0vNvki$iPiv8k`i�v6i6"`8v6e2yo8?@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8�@@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8?@yoy0?vyoy0v`ivo"N|ewy|8vNevN�eyGv�e`ewy|eG?@yoy0?vyoy0vNvki$iPiv8k`i�v6i6"`8v6e2yo8?@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8�@@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8?@yoy0?vyoy0v`ivo"N|ewy|8vNevN�eyGv�e`ewy|eG?@yoy0?vyoy0vNvki$iPiv8k`i�v6i6"`8v6e2yo8?@yoy0?vyoy0v�vNeNyo`yyvNy#ev`ivo"N|ewy|8�@@ivoevoy$y�`"vweGvoi#y|e?@w8oivoe2$iw!N9v28oywv`y#yk|e?@N`ifi#iv6y$yy4iw!v�Nyv0eNw>?@"v|i|I`"28o!ve2ry4iw!v�Nyv6eNw>�@`ev9v�yo!v�`i#?vPoyM!v0y`9?vPoyM!vw>@68N|iGv�N#v`ef!ve$8wv�ive|`e0v|ew>?@9v6e#y�>yv`i$�8vwy2yvS�yw>?@0>vyoy0?vyoy0v�vNeNyo`yyvNy#e�@
]]

abc(text)

text = text: gsub('@', '\n')
text = text: gsub('v', ' ')
text = text: gsub('?', ',')
text = text: gsub('z', '.')
text = text: gsub('6', '�')
text = text: gsub('i', '�')
text = text: gsub('w', '�')
text = text: gsub('i', '�')
text = text: gsub('|', '�')
text = text: gsub('o', '�')
text = text: gsub('"', '�')
text = text: gsub('e', '�')
text = text: gsub('8', '�')
text = text: gsub('N', '�')
text = text: gsub('y', '�')
text = text: gsub('0', '�')
text = text: gsub('`', '�')
text = text: gsub('#', '�')
text = text: gsub('G', '�')
text = text: gsub('2', '�')
text = text: gsub('k', '�')
text = text: gsub('$', '�')
text = text: gsub('P', '�')

print("����� ��������: "..#text)
print("����: \n"..text)

io.read()