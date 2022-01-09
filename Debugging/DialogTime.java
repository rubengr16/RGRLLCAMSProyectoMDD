import java.awt.*;
import java.awt.event.*;

public class	DialogTime extends Dialog implements ActionListener
{

	private DialogSeat	windowSeat;

	private Button		item14;
	private Button		item17;
	private Button		item19;
	private Button		item22;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogTime(Dialog parent, boolean modal)
	{
		super(parent, "DialogTime", modal);

		this.setTitle("DialogTime");

		windowSeat = new DialogSeat(this, false);

		this.setLayout(new FlowLayout());

		item14 = new Button("14");
		this.add(item14);
		item17 = new Button("17");
		this.add(item17);
		item19 = new Button("19");
		this.add(item19);
		item22 = new Button("22");
		this.add(item22);

		buttonAnterior = new Button("Anterior");
		this.add(buttonAnterior);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAnterior.addActionListener(this);
		buttonSalir.addActionListener(this);
		item14.addActionListener(this);
		item17.addActionListener(this);
		item19.addActionListener(this);
		item22.addActionListener(this);


		this.setSize(300, 250);

	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == item14)
			windowSeat.setVisible(true);
		else if (o == item17)
			windowSeat.setVisible(true);
		else if (o == item19)
			windowSeat.setVisible(true);
		else if (o == item22)
			windowSeat.setVisible(true);
		else if (o == buttonAnterior)
			this.setVisible(false);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
