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
	protected static int block = 40, x = 3, y = -3, randForm;
	public int ground[][][] = new int [20][10][3];
	public int form[][][] = {
		{{0, 2}, {1, 2}, {2, 2}, {3, 2}, {  0, 255, 255}}, //I
		{{1, 2}, {2, 2}, {2, 1}, {2, 0}, {  0,   0, 255}}, //J
		{{1, 2}, {2, 2}, {1, 1}, {1, 0}, {255, 165,   0}}, //L
		{{1, 2}, {2, 2}, {1, 1}, {2, 1}, {255, 255,   0}}, //O
		{{0, 2}, {1, 2}, {1, 1}, {2, 1}, {  0, 255,   0}}, //S
		{{1, 2}, {0, 1}, {1, 1}, {2, 1}, {255,   0, 255}}, //T
		{{1, 2}, {2, 2}, {0, 1}, {1, 1}, {255,   0,   0}}  //Z 
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
			switch(event.getKeyCode()) {
				case 37: x--; break; //Влево (🡸)
				case 38: y--; break; //Вниз  (🡻)
				case 39: x++; break; //Вправо(🡺)
				case 40: y++; break; //Вверх (🡹)
			}
		}
	 });
		while (true) {
			tetris.game();
			tetris.repaint();
			try {
				Thread.sleep(500);
			} catch (Exception e) {}
		}
	}
	
	/*Логика
	 *  |
	 *  |
	 *  🡻
	 */
	private void game() {	
		y++;
		if (y == 20) random();
	}
	
	private void random() {
		randForm = random.nextInt(7);
		y = -3;
		x = 3;
	}
	
	/*Графика
	 *  |
	 *  |
	 *  🡻
	 */

	public void paint(Graphics ctx) {
		super.paint(ctx);
		
		//Дно
		for(int i = 0; i < 20; i++){
			for(int j = 0; j < 10; j++) {
				ctx.setColor(new Color(ground[i][j][0], ground[i][j][1], ground[i][j][2]));
				ctx.fillRect(j*block, i*block, block, block);
			}
		}
		// фигуры
		for(int i = 0; i < 4; i++) {
			ctx.setColor(new Color(form[randForm][4][0], form[randForm][4][1], form[randForm][4][2]));
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