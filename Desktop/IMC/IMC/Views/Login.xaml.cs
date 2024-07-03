namespace IMC.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    private class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    private void OnLoginRegisterClicked(object sender, EvenArgs e)
	{
		string email = txtLoginRegisterEmail.Text;
		string contrase�a = txtLoginResgisterContrase�a.Text;
		if (IsValidEmail(email) && IsValidContrase�a(contrase�a))
		{
			users.Add(new User { Email = email, Contrase�a = contrase�a });
			lblRegisterMessage.Text = "Inicio de sesi�n realizado exitosamente";
			ShowLoginForm(sender, e);
		}
		else
		{
			lbLoginlRegisterMessage.Txt = "Ocurri� un error, susuario o contrase�a incorrectos";
		}
	}
    private void OnLoginClicked(object sender, EventArgs e)
	{
        string email = txtLoginEmail.Text;
        string contrase�a = txtLoginContrase�a.Text;

		var user = users.Find(x => x.Email == email && x.Contrsae�a ==contrase�a);
		if (user != null)
		{
			lblSuccessMessage.Text = "Inicio de sesi�n correcto.";
            lblSuccessMessage.IsVisible = true;
        }
		else
		{
            lblLoginMessage.Text = "Correo o contrase�a incorrectos.";
            lblLoginMessage.IsVisible = true;
        }
    }
    private void ClearRegisterLogin()
    {
        txtRegisterEmail.Txt = string.Empty;
        txtRegisterContrase�a.Txt = string.Empty;
    }
	private bool IsValidEmail(string email)
	{
		return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
	}
	private bool IsValidContrase�a(string contrase�a)
	{
		return contrase�a.Legth > 8 && contrase�a.Any(char.IsDigit) && contrase�a.Any(char.IsUpper);
	}
	private void OnEmailTextChanged(object sender, TextChangedEventArgs e)
    {
            if (sender is Entry entry)
            {
                entry.Text = entry.Text.ToLower();
            }
    }
    private void txtRegisterPassword_Focused(object sender, FocusEventArgs e)
    {

    }
}
