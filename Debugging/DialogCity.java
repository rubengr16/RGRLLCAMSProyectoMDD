import java.awt.*;
import java.awt.event.*;

public class	DialogCity extends Dialog implements ActionListener
{

	private DialogFilm	windowFilm;
	private FrameCINESIA	frameCINESIA;

	private Button		itemMadrid;
	private Button		itemBarcelona;
	private Button		itemSevilla;
	private Button		itemCinesa;
	private Button		itemYelmo;
	private Button		itemSinFin;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogCity(Frame parent, boolean modal)
	{
		super(parent, "DialogCity", modal);

		this.setTitle("DialogCity");

		windowFilm = new DialogFilm(parent, true);
		frameCINESIA = new FrameCINESIA();

		this.setLayout(new FlowLayout());

		itemMadrid = new Button("Madrid");
		this.add(itemMadrid);
		itemBarcelona = new Button("Barcelona");
		this.add(itemBarcelona);
		itemSevilla = new Button("Sevilla");
		this.add(itemSevilla);
		itemCinesa = new Button("Cinesa");
		this.add(itemCinesa);
		itemYelmo = new Button("Yelmo");
		this.add(itemYelmo);
		itemSinFin = new Button("SinFin");
		this.add(itemSinFin);

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
			frameCINESIA.setVisible(true);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
