import java.awt.*;
import java.awt.event.*;

public class	DialogTime extends Dialog implements ActionListener
{

	private DialogSeat	windowSeat;

	private MenuItem	item14;
	private MenuItem	item17;
	private MenuItem	item19;
	private MenuItem	item22;

	private Button		buttonAtrás;
	private Button		buttonSalir;

	public DialogTime(Frame parent, boolean modal)
	{
		super(parent, "DialogTime", modal);

		this.setTitle("DialogTime");

		windowSeat = new DialogSeat(this, true);

		this.setLayout(new FlowLayout());

		MenuBar MB = new MenuBar();
		this.setMenuBar(MB);

		Menu menuSession = new Menu("Session");
		item14 = new MenuItem("14");
		menuSession.add(item14);
		item17 = new MenuItem("17");
		menuSession.add(item17);
		item19 = new MenuItem("19");
		menuSession.add(item19);
		item22 = new MenuItem("22");
		menuSession.add(item22);
		MB.add(menuSession);


		buttonAtrás = new Button("Atrás");
		this.add(buttonAtrás);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAtrás.addActionListener(this);
		buttonSalir.addActionListener(this);
		item14.addActionListener(this);
		item17.addActionListener(this);
		item19.addActionListener(this);
		item22.addActionListener(this);


		this.setSize(300, 250);
		this.setVisible(true);
	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == item14)
			windowTime.setVisible(true);
		else if (o == item17)
			windowTime.setVisible(true);
		else if (o == item19)
			windowTime.setVisible(true);
		else if (o == item22)
			windowTime.setVisible(true);
		else SHITY THINGS
		else if (o == buttonSalir)
			System.exit(0);
	}
}
