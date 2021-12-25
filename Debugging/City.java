import java.awt.*;
import java.awt.event.*;

public class	DialogCity extends Dialog implements ActionListener
{

	private DialogFilm	windowFilm;

	private MenuItem	itemMadrid;
	private MenuItem	itemBarcelona;
	private MenuItem	itemSevilla;
	private MenuItem	itemCinesa;
	private MenuItem	itemYelmo;
	private MenuItem	itemSinFin;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogCity(Frame parent, boolean modal)
	{
		super(parent, "DialogCity", modal);

		this.setTitle("DialogCity");

		windowFilm = new DialogFilm(this, true);
		windowCINESIA = new DialogCINESIA(this, true);

		this.setLayout(new FlowLayout());

		MenuBar MB = new MenuBar();
		this.setMenuBar(MB);

		Menu menuTown = new Menu("Town");
		itemMadrid = new MenuItem("Madrid");
		menuTown.add(itemMadrid);
		itemBarcelona = new MenuItem("Barcelona");
		menuTown.add(itemBarcelona);
		itemSevilla = new MenuItem("Sevilla");
		menuTown.add(itemSevilla);
		MB.add(menuTown);

		Menu menuCinema = new Menu("Cinema");
		itemCinesa = new MenuItem("Cinesa");
		menuCinema.add(itemCinesa);
		itemYelmo = new MenuItem("Yelmo");
		menuCinema.add(itemYelmo);
		itemSinFin = new MenuItem("SinFin");
		menuCinema.add(itemSinFin);
		MB.add(menuCinema);


		buttonAnterior = new Button("Anterior");
		this.add(buttonAnterior);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAnterior.addActionListener(this);
		buttonSalir.addActionListener(this);
		itemMadrid.addActionListener(this);
		itemBarcelona.addActionListener(this);
		itemSevilla.addActionListener(this);
		itemCinesa.addActionListener(this);
		itemYelmo.addActionListener(this);
		itemSinFin.addActionListener(this);


		this.setSize(300, 250);
		this.setVisible(true);
	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == itemCinesa)
			windowFilm.setVisible(true);
		else if (o == itemYelmo)
			windowFilm.setVisible(true);
		else if (o == itemSinFin)
			windowFilm.setVisible(true);
		else if (o == buttonAnterior)
			windowCINESIA.setVisible(true);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
