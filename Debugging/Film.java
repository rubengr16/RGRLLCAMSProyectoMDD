import java.awt.*;
import java.awt.event.*;

public class	DialogFilm extends Dialog implements ActionListener
{

	private DialogTime	windowTime;

	private MenuItem	itemDanger;
	private MenuItem	itemPlanet;
	private MenuItem	itemMision;
	private MenuItem	itemRobot;
	private MenuItem	itemIPS;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogFilm(Frame parent, boolean modal)
	{
		super(parent, "DialogFilm", modal);

		this.setTitle("DialogFilm");

		windowTime = new DialogTime(this, true);
		windowCity = new DialogCity(this, true);

		this.setLayout(new FlowLayout());

		MenuBar MB = new MenuBar();
		this.setMenuBar(MB);

		Menu menuFilm = new Menu("Film");
		itemDanger = new MenuItem("Danger");
		menuFilm.add(itemDanger);
		itemPlanet = new MenuItem("Planet");
		menuFilm.add(itemPlanet);
		itemMision = new MenuItem("Mision");
		menuFilm.add(itemMision);
		itemRobot = new MenuItem("Robot");
		menuFilm.add(itemRobot);
		itemIPS = new MenuItem("IPS");
		menuFilm.add(itemIPS);
		MB.add(menuFilm);


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
		this.setVisible(true);
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
			windowCity.setVisible(true);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
