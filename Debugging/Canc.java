import java.awt.*;
import java.awt.event.*;

public class	DialogCanc extends Dialog implements ActionListener
{


	private MenuItem	itemAC;
	private MenuItem	itemRC;

	private Button		buttonAtrás;
	private Button		buttonSalir;

	public DialogCanc(Frame parent, boolean modal)
	{
		super(parent, "DialogCanc", modal);

		this.setTitle("DialogCanc");


		this.setLayout(new FlowLayout());

		MenuBar MB = new MenuBar();
		this.setMenuBar(MB);

		Menu menuCancel = new Menu("Cancel");
		itemAC = new MenuItem("AC");
		menuCancel.add(itemAC);
		itemRC = new MenuItem("RC");
		menuCancel.add(itemRC);
		MB.add(menuCancel);


		buttonAtrás = new Button("Atrás");
		this.add(buttonAtrás);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAtrás.addActionListener(this);
		buttonSalir.addActionListener(this);
		itemAC.addActionListener(this);
		itemRC.addActionListener(this);


		this.setSize(300, 250);
		this.setVisible(true);
	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == itemAC)
			System.exit(0);
		if (o == itemRC)
			System.exit(0);
		if (o == buttonSalir)
			System.exit(0);
	}
}
