import java.awt.*;
import java.awt.event.*;

public class	DialogCanc extends Dialog implements ActionListener
{

	private FrameCINESIA	frameCINESIA;

	private Button		itemAC;
	private Button		itemRC;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogCanc(Frame parent, boolean modal)
	{
		super(parent, "DialogCanc", modal);

		this.setTitle("DialogCanc");

		frameCINESIA = new FrameCINESIA();

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
		this.setVisible(true);
	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == itemAC)
			System.exit(0);
		if (o == itemRC)
			System.exit(0);
		if (o == buttonAnterior)
			frameCINESIA.setVisible(true);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
