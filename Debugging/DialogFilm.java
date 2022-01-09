import java.awt.*;
import java.awt.event.*;

public class	DialogFilm extends Dialog implements ActionListener
{

	private DialogTime	windowTime;

	private Button		itemDanger;
	private Button		itemPlanet;
	private Button		itemMision;
	private Button		itemRobot;
	private Button		itemIPS;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogFilm(Dialog parent, boolean modal)
	{
		super(parent, "DialogFilm", modal);

		this.setTitle("DialogFilm");

		windowTime = new DialogTime(this, false);

		this.setLayout(new FlowLayout());

		itemDanger = new Button("Danger");
		this.add(itemDanger);
		itemPlanet = new Button("Planet");
		this.add(itemPlanet);
		itemMision = new Button("Mision");
		this.add(itemMision);
		itemRobot = new Button("Robot");
		this.add(itemRobot);
		itemIPS = new Button("IPS");
		this.add(itemIPS);

		buttonAnterior = new Button("Anterior");
		this.add(buttonAnterior);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAnterior.addActionListener(this);
		buttonSalir.addActionListener(this);
		itemDanger.addActionListener(this);
		itemPlanet.addActionListener(this);
		itemMision.addActionListener(this);
		itemRobot.addActionListener(this);
		itemIPS.addActionListener(this);


		this.setSize(300, 250);

	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == itemDanger)
			windowTime.setVisible(true);
		else if (o == itemPlanet)
			windowTime.setVisible(true);
		else if (o == itemMision)
			windowTime.setVisible(true);
		else if (o == itemRobot)
			windowTime.setVisible(true);
		else if (o == itemIPS)
			windowTime.setVisible(true);
		else if (o == buttonAnterior)
			this.setVisible(false);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
