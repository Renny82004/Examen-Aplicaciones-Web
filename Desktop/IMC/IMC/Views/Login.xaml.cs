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
		string contraseña = txtLoginResgisterContraseña.Text;
		if (IsValidEmail(email) && IsValidContraseña(contraseña))
		{
			users.Add(new User { Email = email, Contraseña = contraseña });
			lblRegisterMessage.Text = "Inicio de sesión realizado exitosamente";
			ShowLoginForm(sender, e);
		}
		else
		{
			lbLoginlRegisterMessage.Txt = "Ocurrió un error, susuario o contraseña incorrectos";
		}
	}
    private void OnLoginClicked(object sender, EventArgs e)
	{
        string email = txtLoginEmail.Text;
        string contraseña = txtLoginContraseña.Text;

		var user = users.Find(x => x.Email == email && x.Contrsaeña ==contraseña);
		if (user != null)
		{
			lblSuccessMessage.Text = "Inicio de sesión correcto.";
            lblSuccessMessage.IsVisible = true;
        }
		else
		{
            lblLoginMessage.Text = "Correo o contraseña incorrectos.";
            lblLoginMessage.IsVisible = true;
        }
    }
    private void ClearRegisterLogin()
    {
        txtRegisterEmail.Txt = string.Empty;
        txtRegisterContraseña.Txt = string.Empty;
    }
	private bool IsValidEmail(string email)
	{
		return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
	}
	private bool IsValidContraseña(string contraseña)
	{
		return contraseña.Legth > 8 && contraseña.Any(char.IsDigit) && contraseña.Any(char.IsUpper);
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
