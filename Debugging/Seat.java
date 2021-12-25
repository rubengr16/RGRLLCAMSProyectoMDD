import java.awt.*;
import java.awt.event.*;

public class	DialogSeat extends Dialog implements ActionListener
{


	private MenuItem	item21;
	private MenuItem	item22;
	private MenuItem	item32;
	private MenuItem	item41;
	private MenuItem	item11;
	private MenuItem	item12;
	private MenuItem	item31;
	private MenuItem	item14;
	private MenuItem	item13;
	private MenuItem	item42;
	private MenuItem	item34;
	private MenuItem	item33;
	private MenuItem	item24;
	private MenuItem	item44;
	private MenuItem	item43;
	private MenuItem	item23;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogSeat(Frame parent, boolean modal)
	{
		super(parent, "DialogSeat", modal);

		this.setTitle("DialogSeat");

		windowCity = new DialogCity(this, true);

		this.setLayout(new FlowLayout());

		MenuBar MB = new MenuBar();
		this.setMenuBar(MB);

		Menu menu = new Menu("");
		item21 = new MenuItem("21");
		menu.add(item21);
		item22 = new MenuItem("22");
		menu.add(item22);
		item32 = new MenuItem("32");
		menu.add(item32);
		item41 = new MenuItem("41");
		menu.add(item41);
		item11 = new MenuItem("11");
		menu.add(item11);
		item12 = new MenuItem("12");
		menu.add(item12);
		item31 = new MenuItem("31");
		menu.add(item31);
		item14 = new MenuItem("14");
		menu.add(item14);
		item13 = new MenuItem("13");
		menu.add(item13);
		item42 = new MenuItem("42");
		menu.add(item42);
		item34 = new MenuItem("34");
		menu.add(item34);
		item33 = new MenuItem("33");
		menu.add(item33);
		item24 = new MenuItem("24");
		menu.add(item24);
		item44 = new MenuItem("44");
		menu.add(item44);
		item43 = new MenuItem("43");
		menu.add(item43);
		item23 = new MenuItem("23");
		menu.add(item23);
		MB.add(menu);


		buttonAnterior = new Button("Anterior");
		this.add(buttonAnterior);
		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonAnterior.addActionListener(this);
		buttonSalir.addActionListener(this);
		item21.addActionListener(this);
		item22.addActionListener(this);
		item32.addActionListener(this);
		item41.addActionListener(this);
		item11.addActionListener(this);
		item12.addActionListener(this);
		item31.addActionListener(this);
		item14.addActionListener(this);
		item13.addActionListener(this);
		item42.addActionListener(this);
		item34.addActionListener(this);
		item33.addActionListener(this);
		item24.addActionListener(this);
		item44.addActionListener(this);
		item43.addActionListener(this);
		item23.addActionListener(this);


		this.setSize(300, 250);
		this.setVisible(true);
	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == item21)
			System.exit(0);
		if (o == item22)
			System.exit(0);
		if (o == item32)
			System.exit(0);
		if (o == item41)
			System.exit(0);
		if (o == item11)
			System.exit(0);
		if (o == item12)
			System.exit(0);
		if (o == item31)
			System.exit(0);
		if (o == item14)
			System.exit(0);
		if (o == item13)
			System.exit(0);
		if (o == item42)
			System.exit(0);
		if (o == item34)
			System.exit(0);
		if (o == item33)
			System.exit(0);
		if (o == item24)
			System.exit(0);
		if (o == item44)
			System.exit(0);
		if (o == item43)
			System.exit(0);
		if (o == item23)
			System.exit(0);
		if (o == buttonAnterior)
			windowCity.setVisible(true);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
