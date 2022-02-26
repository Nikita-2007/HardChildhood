os.setlocale('rus_rus.1251')
lib = require('lib')

text = [[
p<:5w92<73q95a<wg95Ga9vaC/:a1aq5<w95-<pGy,fJv<MAe/IfI<wyw5,aM95a<Gyqa9vae/IfI<ga9y-<7yJM5-<I1fJ5MAT/G<M5w,a9vp6<g13JMy<0a~9fqa595-e/G<M1aG5gf6<>3w95-<J3aMAe/~G37f,<w9a<q5,g5<g5,5J<9a59A-/y<J9y,yJv<wy,Aa<7a1MAT/>,y<g5qAT<031v<:51AG<wpMa59A-/1fJJap,<:1a59ya<wa7MAe/y<p<~f0A,<MG5-<g5,5J<9a59A-e/MG5y<9a0aJ9Aa<7a1MAT/G<g,3>ye<G5<w1fIa<~fM57a9vp/Mp93,yJv<My65<q9y<w5y/0a~<055aJMGfe<0a~<Gq5695Ga9vpe/0a~<J,a~e<0a~<5y~9ye<0a~<,20GyT/q3>a<9fJMf,5<:15035qa9vaC/y<G5M<5:pMv<pGy,fJv<MAe/IfI<wyw5,aM95a<Gyqa9vae/IfI<ga9y-<7yJM5-<I1fJ5MAT/y<Ja1q#a<0vaMJp<G<3:5a9vae/y<q,p<9ag5<G5JI1aJ,y<G95Gv/y<055aJMG5e<y<Gq5695Ga9vae/y<5y~9ve<y<J,a~Ae<y<,205GvT/
]]

abc(text)
num(text)
spectrum()

text = text: gsub('<', ' ')
text = text: gsub('/', '\n')
text = text: gsub('y', 'и')
text = text: gsub('T', '.')
text = text: gsub(',', 's')
text = text: gsub('e', ',')
text = text: gsub(':', 'п')
text = text: gsub('5', 'о')
text = text: gsub('w', 'м')
text = text: gsub('9', 'н')
text = text: gsub('w', 'ю')
text = text: gsub('7', 'ч')
text = text: gsub('3', 'у')
text = text: gsub('q', 'д')
text = text: gsub('e', 'е')
text = text: gsub('p', 'я')
text = text: gsub('2', 'ю')
text = text: gsub('a', 'е')
text = text: gsub('g', 'г')
text = text: gsub('G', 'в')
text = text: gsub('v', 'ь')
text = text: gsub('C', '!')
text = text: gsub('1', 'д')
text = text: gsub('-', 'ю')
text = text: gsub('s', 'л')
text = text: gsub('f', 'а')
text = text: gsub('J', 'с')
text = text: gsub('M', 'т')
text = text: gsub('A', 'ы')
text = text: gsub('I', 'к')
text = text: gsub('f', 'а')
text = text: gsub('6', 'х')
text = text: gsub('0', 'б')
text = text: gsub('~', 'з')
text = text: gsub('>', 'д')
text = text: gsub('#', 'ц')



print("Шифр: \n"..text)

io.read()

--о с у я к а

--еще или как оно