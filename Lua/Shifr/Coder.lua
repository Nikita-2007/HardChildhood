--Кодировщик
os.setlocale('rus_rus.1251')

print("Исходный текст: ")
text = io.read()

codeText = ''
origChar = {}
codeChar = {}
math.randomseed(os.time())

function rnd_Char()
	r = string.char(math.random(14, 127))
	for i = 1, #codeChar do
		if r == codeChar[i] then
			rnd_Char()
		end
	end
end

for i = 1, #text do
	c = string.lower(text: sub(i, i))
	temp = 0
	for j =1, #origChar do
		if c ~= origChar[j] then
			temp = temp + 1
		elseif c == origChar[j] then
			codeText = codeText..codeChar[j]
			break
		end
	end
	if temp == #origChar then
		origChar[#origChar+1] = c
		rnd_Char()
		codeChar[#codeChar+1] = r
		codeText = codeText..r
	end
end
print(codeText)
io.read()