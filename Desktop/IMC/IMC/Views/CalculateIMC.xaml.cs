namespace IMC.Views;

public partial class CalculateIMS : ContentPage
{
	public CalculateIMS()
	{
		InitializeComponent();
	}
	private void OnClicCalcular(object sender, EventArgs e)
	{
		try
		{
			double peso = Convert.ToDouble(txtzPeso.Text);
			double altura = Convert.ToDouble(txtAltura.Text);
			double imc = peso / (altura * altura);
			string message;

			if (imc <= 18.5)
			{
				message= "Su peso se encuentra por debajo del rango especificado";

			}
			else if (imc > 18.5 && imc <24.9)
			{
				message = "Su peso es el adecuado, eres una persona saludable";
			}
			else if (imc >= 25 && imc <= 29.9)
			{
				message = "Usted se encuentra con sobrepeso";
			}
			else if (imc >= 30 && imc <= 39.9)
			{
				message = "Usted padece de obesidad";
			}
            lblResult.Text = $"{imc:F2}. {message}";
        }
		catch (FormatException ex)
		{
            lblMessaje.Text = "Ocurrió un error, usted no dijitó valores válidos ";
        }
	}
}
