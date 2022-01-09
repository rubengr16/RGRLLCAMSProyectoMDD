import java.awt.*;
import java.awt.event.*;

public class	FrameCINESIA extends Frame implements ActionListener
{

	private DialogCity	windowCity;
	private DialogCanc	windowCanc;

	private MenuItem		itemBook;
	private MenuItem		itemCancel;

	private Button		buttonSalir;

	public FrameCINESIA()
	{
		super();

		this.setTitle("FrameCINESIA");

		windowCity = new DialogCity(this, false);
		windowCanc = new DialogCanc(this, false);

		this.setLayout(new FlowLayout());

		MenuBar MB = new MenuBar();
		this.setMenuBar(MB);

		Menu menuQuestion = new Menu("Question");
		itemBook = new MenuItem("Book");
		menuQuestion.add(itemBook);
		itemCancel = new MenuItem("Cancel");
		menuQuestion.add(itemCancel);
		MB.add(menuQuestion);


		buttonSalir = new Button("Salir");
		this.add(buttonSalir);

		buttonSalir.addActionListener(this);
		itemBook.addActionListener(this);
		itemCancel.addActionListener(this);


		this.setSize(500, 300);
		this.setVisible(true);
	}

	public void	actionPerformed(ActionEvent ae)
	{
		Object o = ae.getSource();

		if (o == itemBook)
			windowCity.setVisible(true);
		else if (o == itemCancel)
			windowCanc.setVisible(true);
		else if (o == buttonSalir)
			System.exit(0);
	}
}
