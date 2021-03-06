import java.awt.*;
import java.awt.event.*;

public class	DialogCanc extends Dialog implements ActionListener
{


	private Button		itemAC;
	private Button		itemRC;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogCanc(Frame parent, boolean modal)
	{
		super(parent, "DialogCanc", modal);

		this.setTitle("DialogCanc");


		this.setLayout(new FlowLayout());

		itemAC = new Button("AC");
		this.add(itemAC);
		itemRC = new Button("RC");
		this.add(itemRC);

		buttonAnterior = new Button("Anterior");
		this.add(buttonAnterior);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAnterior.addActionListener(this);
		buttonSalir.addActionListener(this);
		itemAC.addActionListener(this);
		itemRC.addActionListener(this);


		this.setSize(300, 250);

	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == itemAC)
			System.exit(0);
		if (o == itemRC)
			System.exit(0);
		if (o == buttonAnterior)
			this.setVisible(false);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
