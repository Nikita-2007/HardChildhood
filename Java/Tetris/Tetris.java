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
		
		ctx.setColor(Color.green);
		ctx.fillRect(x*block, y*block+25, 25, 25);
		ctx.fillRect(x*block, y*block+50, 25, 25);
		ctx.fillRect(x*block, y*block+75, 25, 25);
		ctx.fillRect(x*block+25, y*block+75, 25, 25);
	}
}