/*
 * Тетрис
 * Никита
 * Октябрь
 * 2019
 */
 
import java.awt.Color;
import java.awt.Graphics;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyListener;
import java.awt.event.KeyEvent;
import javax.swing.JFrame;
import javax.swing.JPanel;
import java.util.Random;


public class Tetris extends JPanel {
	

	/*Переменные
	 *  |
	 *  |
	 *  🡻
	 */
	protected static int speed = 400, block = 40, x = 3, y = -3, randForm, test;
	public int ground[][][] = new int [20][10][1];
	public int form[][][] = {
		{{0, 2}, {1, 2}, {2, 2}, {3, 2}, {0x00FFFF}}, //I
		{{1, 2}, {2, 2}, {2, 1}, {2, 0}, {0x0000FF}}, //J
		{{1, 2}, {2, 2}, {1, 1}, {1, 0}, {0xFFa500}}, //L
		{{1, 2}, {2, 2}, {1, 1}, {2, 1}, {0xFFFF00}}, //O
		{{0, 2}, {1, 2}, {1, 1}, {2, 1}, {0x00FF00}}, //S
		{{1, 2}, {0, 1}, {1, 1}, {2, 1}, {0xFF00FF}}, //T
		{{1, 2}, {2, 2}, {0, 1}, {1, 1}, {0xFF0000}}  //Z 
	};
	Random random = new Random();
	
	public static void main(String[] args) {
		
	/*Окно прилажения
	 *  |
	 *  |
	 *  🡻
	 */
		JFrame jFrame = new JFrame("Tetris");
		jFrame.setDefaultLookAndFeelDecorated(true);
		jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jFrame.setSize(block*10+17, block*21);
		jFrame.setResizable(false);
		jFrame.setLocationRelativeTo(null);
		jFrame.setVisible(true);
		Tetris tetris = new Tetris();
		jFrame.add(tetris);
		
	/*Упровление
	 *  |
	 *  |
	 *  🡻
	 */
	 jFrame.addKeyListener(new KeyAdapter() {
		public void keyPressed(KeyEvent event) {
			tetris.repaint();
			switch(event.getKeyCode()) {
				case 37: tetris.move(-1); break; //Влево (🡸)
				case 38: tetris.rotate(); break; //Поворот)
				case 39: tetris.move(1); break; //Вправо(🡺)
				case 40: speed = 40; break; //Вниз (🡻)
			}
		}
	 });
		while (true) {
			tetris.game();
			tetris.repaint();
			try {
				Thread.sleep(speed);
			} catch (Exception e) {}
		}
	}
	
	/*Логика
	 *  |
	 *  |
	 *  🡻
	 */
	private void game() {
	test = 0;
	for (int i = 0; i < 4; i++) {
			if (form[randForm][i][1]+y+1 < 20) test++;
		}
		if (test == 4) y++; 
		else {
			for (int i = 0; i < 4; i++) {
				ground[form[randForm][i][1]+y][form[randForm][i][0]+x][0] = form[randForm][4][0];
			}
			random();
		}
	}
	
	//Граница по оси x
	private void move(int move) {
		x = x+move;
	}
	
	private void random() {
		speed = 400;
		randForm = random.nextInt(7);
		y = -3;
		x = 3;
	}
	
	//Поворот
	private void rotate() {
		int temp;
		for (int i = 0; i < 4; i++){
			temp = form[randForm][i][0];
			form[randForm][i][0] = -form[randForm][i][1]+3;
			form[randForm][i][1] = temp;
		}
	}
	
	/*Графика
	 *  |
	 *  |
	 *  🡻
	 */
	public void paint(Graphics ctx) {		
		//Дно
		for(int i = 0; i < 20; i++){
			for(int j = 0; j < 10; j++) {
				ctx.setColor(new Color(ground[i][j][0]));
				ctx.fillRect(j*block, i*block, block, block);
			}
		}
		// фигуры
		for(int i = 0; i < 4; i++) {
			ctx.setColor(new Color(form[randForm][4][0]));
			ctx.fillRect(block*form[randForm][i][0]+x*block, block*form[randForm][i][1]+y*block, block, block);
		}
		
		//сетка
		ctx.setColor(Color.gray);
		for(int i = 0; i < 10; i++) ctx.drawLine(block*i,0 ,block*i , block*20);
		for(int i = 0; i < 20; i++) ctx.drawLine(0, block*i, block*10, block*i);
	}
}
	/*Твоя самооценка
	 *  |
	 *  |
	 *  🡻
	 *  .
*/ 
	
	 