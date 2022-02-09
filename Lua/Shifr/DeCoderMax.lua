os.setlocale('rus_rus.1251')
lib = require('lib')

text = [[
p<:5w92<73q95a<wg95Ga9vaC/:a1aq5<w95-<pGy,fJv<MAe/IfI<wyw5,aM95a<Gyqa9vae/IfI<ga9y-<7yJM5-<I1fJ5MAT/G<M5w,a9vp6<g13JMy<(a'9fqa595-e/G<M1aG5gf6<>3w95-<J3aMAe/'G37f,<w9a<q5,g5<g5,5J<9a59A-/y<J9y,yJv<wy,Aa<7a1MAT/>,y<g5qAT<(31v<:51AG<wpMa59A-/1fJJap,<:1a59ya<wa7MAe/y<p<'f(A,<MG5-<g5,5J<9a59A-e/MG5y<9a(aJ9Aa<7a1MAT/G<g,3>ye<G5<w1fIa<'fM57a9vp/Mp93,yJv<My65<q9y<w5y/(a'<(55aJMGfe<(a'<Gq5695Ga9vpe/(a'<J,a'e<(a'<5y'9ye<(a'<,2(GyT/q3>a<9fJMf,5<:15(35qa9vaC/y<G5M<5:pMv<pGy,fJv<MAe/IfI<wyw5,aM95a<Gyqa9vae/IfI<ga9y-<7yJM5-<I1fJ5MAT/y<Ja1q#a<(vaMJp<G<3:5a9vae/y<q,p<9ag5<G5JI1aJ,y<G95Gv/y<(55aJMG5e<y<Gq5695Ga9vae/y<5y'9ve<y<J,a'Ae<y<,2(5GvT/
]]

abc(text)
num(text)

text = text: gsub('<', ' ')
text = text: gsub('/', '\n')
text = text: gsub('y', 'и')
text = text: gsub('T', '.')
text = text: gsub(',', 's')
text = text: gsub('e', ',')
text = text: gsub('e', ',')


print("Шифр: \n"..text)

io.read()

--а в к о с у я

--еще или как оно