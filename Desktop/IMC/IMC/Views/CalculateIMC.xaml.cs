namespace IMC.Views;

public partial class CalculateIMS : ContentPage
{
	public CalculateIMS()
	{
		InitializeComponent();
	}
	private void OnClicCalcular(object sender, EventArgs e)
	{
		int valor = Convert.ToInt32(txt_num1.Text);
		res_cal.Text = valor.ToString();
	}
}
