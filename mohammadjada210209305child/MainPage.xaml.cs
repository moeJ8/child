namespace mohammadjada210209305child;

public partial class MainPage : ContentPage
{
	string gender;
	string si1, si2;

	List<child> childList = new List<child>();

	public MainPage()
	{
		InitializeComponent();
	}

	private void add_Clicked(object sender, EventArgs e)
	{
		if (male.IsChecked)
			gender = "male";
        else if (female.IsChecked)
            gender = "female";
		if (football.IsChecked)
			si1 = "Team football";
        if (football.IsChecked)
            si1 = "Team sail";
		int dobday;
		int.TryParse(day.Text, out dobday);
        int dobmonth;
        int.TryParse(month.Text, out dobmonth);
        int dobyear;
        int.TryParse(year.Text, out dobyear);
		childList.Add(new child(name.Text, lastName.Text, dobday, dobmonth, dobyear, gender, si1, si2));
    }

	private void show_Clicked(object sender, EventArgs e)
	{
        var sortedList = childList.OrderBy(c => c.dobYear).ToList();
        listXaml.ItemsSource = null;
        listXaml.ItemsSource = sortedList;

    }
}

