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
text = text: gsub('y', '�')
text = text: gsub('T', '.')
text = text: gsub(',', 's')
text = text: gsub('e', ',')
text = text: gsub(':', '�')
text = text: gsub('5', '�')
text = text: gsub('w', '�')
text = text: gsub('9', '�')
text = text: gsub('w', '�')
text = text: gsub('7', '�')
text = text: gsub('3', '�')
text = text: gsub('q', '�')
text = text: gsub('e', '�')
text = text: gsub('p', '�')
text = text: gsub('2', '�')
text = text: gsub('a', '�')
text = text: gsub('g', '�')
text = text: gsub('G', '�')
text = text: gsub('v', '�')
text = text: gsub('C', '!')
text = text: gsub('1', '�')
text = text: gsub('-', '�')
text = text: gsub('s', '�')
text = text: gsub('f', '�')
text = text: gsub('J', '�')
text = text: gsub('M', '�')
text = text: gsub('A', '�')
text = text: gsub('I', '�')
text = text: gsub('f', '�')
text = text: gsub('6', '�')
text = text: gsub('0', '�')
text = text: gsub('~', '�')
text = text: gsub('>', '�')
text = text: gsub('#', '�')



print("����: \n"..text)

io.read()

--� � � � � �

--��� ��� ��� ���