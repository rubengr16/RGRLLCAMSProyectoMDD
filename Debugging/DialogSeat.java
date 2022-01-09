import java.awt.*;
import java.awt.event.*;

public class	DialogSeat extends Dialog implements ActionListener
{


	private Button		item21;
	private Button		item22;
	private Button		item32;
	private Button		item41;
	private Button		item11;
	private Button		item12;
	private Button		item31;
	private Button		item14;
	private Button		item13;
	private Button		item42;
	private Button		item34;
	private Button		item33;
	private Button		item24;
	private Button		item44;
	private Button		item43;
	private Button		item23;

	private Button		buttonAnterior;
	private Button		buttonSalir;

	public DialogSeat(Dialog parent, boolean modal)
	{
		super(parent, "DialogSeat", modal);

		this.setTitle("DialogSeat");


		this.setLayout(new FlowLayout());

		item21 = new Button("21");
		this.add(item21);
		item22 = new Button("22");
		this.add(item22);
		item32 = new Button("32");
		this.add(item32);
		item41 = new Button("41");
		this.add(item41);
		item11 = new Button("11");
		this.add(item11);
		item12 = new Button("12");
		this.add(item12);
		item31 = new Button("31");
		this.add(item31);
		item14 = new Button("14");
		this.add(item14);
		item13 = new Button("13");
		this.add(item13);
		item42 = new Button("42");
		this.add(item42);
		item34 = new Button("34");
		this.add(item34);
		item33 = new Button("33");
		this.add(item33);
		item24 = new Button("24");
		this.add(item24);
		item44 = new Button("44");
		this.add(item44);
		item43 = new Button("43");
		this.add(item43);
		item23 = new Button("23");
		this.add(item23);

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
			this.setVisible(false);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
