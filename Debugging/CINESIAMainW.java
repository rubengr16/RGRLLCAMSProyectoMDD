import java.awt.*;
import java.awt.event.*;

public class	FrameMainW extends Frame implements ActionListener
{

	private DialogCity	windowCity;
	private DialogCanc	windowCanc;

	private MenuItem	itemBook;
	private MenuItem	itemCancel;

	private Button		buttonSalir;

	public FrameMainW()
	{
		super();

		this.setTitle("FrameMainW");

		windowCity = new DialogCity(this, true);
		windowCanc = new DialogCanc(this, true);

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

