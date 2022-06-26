namespace Note.Maui;

public partial class MainPage : ContentPage
{
	int count = 0;
	private string _fileName;

	public MainPage()
	{
		var notesHeading = new Label()
		{
			Text = "Notes",
			HorizontalOptions = LayoutOptions.Center,
			FontAttributes = FontAttributes.Bold
		};

		var editor = new Editor()
		{
			Placeholder="Ingrese su nota", HeightRequest = 100
		};
		editor.Text = File.Exists(_fileName) ? File.ReadAllText(_fileName) : string.Empty;
		
		var buttonsGrid = new Grid() { HeightRequest = 40.0};
		buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });
		buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30.0, GridUnitType.Absolute) });
		buttonsGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1.0, GridUnitType.Auto) });

		var saveButton = new Button() { WidthRequest = 100, Text = "Guardar" };
		saveButton.HorizontalOptions = LayoutOptions.Center;
		saveButton.Clicked += SaveButton_Clicked;
		buttonsGrid.Add(saveButton);

		Grid.SetColumn(saveButton, 0);

		var deleteButton = new Button() { WidthRequest = 100, Text = "Borrar" };
		deleteButton.HorizontalOptions = LayoutOptions.Center;
		deleteButton.Clicked += DeleteButton_Clicked;
		Grid.SetColumn(deleteButton, 2);

		buttonsGrid.Children.Add(deleteButton);

		var stackLoyout = new VerticalStackLayout
		{
			Padding = new Thickness(30, 60, 30, 30),
			Children = { notesHeading, editor, buttonsGrid }
		};

		Content = stackLoyout;

	}

	private void DeleteButton_Clicked(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	
}

