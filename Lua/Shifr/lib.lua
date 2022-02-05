os.setlocale('rus_rus.1251')
function abc(text)
origSim = {}
numSim = {}
print("Алфовит: ")
for i = 1, #text do
	S = text: sub(i, i)
	temp = 0
	for j = 1, #origSim do
		if S ~= origSim[j] then
			temp = temp + 1
		elseif S == origSim[j] then
			break
		end
	end
	if temp == #origSim then
		origSim[#origSim+1] = S
		x = 0
		for n = 1, #text do
			Stemp = text: sub(n, n)
			if S == Stemp then
				x = x+1
			end
		end
		numSim[#numSim+1] = x
	end
end

for i = 1, #origSim do
	io.write(origSim[i].."-"..numSim[i].."\n")
end
end