public class Usuario
{

    public string UserName{get;set;}
    public string Contraseña{get;set;}
    public string Nombre{get;set;}
    public string Email{get;set;}
    public int Telefono {get;set;}

    public Usuario()
    {

    }

    public Usuario(string usuario,string contra,string nombreP, string mail,int tel)
    {
        UserName = usuario;
        Contraseña = contra;
        Nombre = nombreP;
        Email = mail;
        Telefono = tel;
    }

}