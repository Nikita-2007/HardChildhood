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

public class Tetris extends JPanel {
	

	/*Переменные
	 *  |
	 *  |
	 *  🡻
	 */
	protected static int block = 40, x = 0, y = 0;
	public int form[][][] = {
		{{0, 2}, {1, 2}, {2, 2}, {3, 2}, {  0, 255, 255}}, //I
		{{1, 2}, {2, 2}, {2, 1}, {2, 0}, {  0,   0, 255}}, //J
		{{1, 2}, {2, 2}, {1, 1}, {1, 0}, {255, 165,   0}}, //L
		{{1, 2}, {2, 2}, {1, 1}, {2, 1}, {255, 255,   0}}, //O
		{{0, 2}, {1, 2}, {1, 1}, {2, 1}, {  0, 255,   0}}, //S
		{{1, 2}, {0, 1}, {1, 1}, {2, 1}, {255,   0, 255}}, //T
		{{1, 2}, {2, 2}, {0, 1}, {1, 1}, {255,   0,   0}}  //Z
	};
	
	public static void main(String[] args) {
		
	/*Окно прилажения
	 *  |
	 *  |
	 *  🡻
	 */
		JFrame jFrame = new JFrame("Tetris");
		jFrame.setDefaultLookAndFeelDecorated(true);
		jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jFrame.setSize(block*10, block*20);
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

	}
	
	/*Графика
	 *  |
	 *  |
	 *  🡻
	 */
	public void paint(Graphics ctx) {
		super.paint(ctx);
		setBackground(Color.black);
		
		for(int i = 0; i < 4; i++) {
			int r = 0; // 🡸-- Удалить
			ctx.setColor(new Color(form[r][4][0], form[r][4][1], form[r][4][2]));
			ctx.fillRect(block*form[r][i][0]+x*block, block*form[r][i][1]+y*block, block, block);
		}
	}
}