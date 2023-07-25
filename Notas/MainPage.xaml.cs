namespace Notas;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite calcular el resultado de cinco notas al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void BtnCalcularNota_Clicked(object sender, EventArgs e)
    {
		double nota1, nota2, nota3, nota4, nota5, Promedio;

		if(!string.IsNullOrEmpty(Nota1.Text)
         && !string.IsNullOrEmpty(Nota2.Text)
         && !string.IsNullOrEmpty(Nota3.Text)
         && !string.IsNullOrEmpty(Nota4.Text)
         && !string.IsNullOrEmpty(Nota5.Text))
		{
			nota1 = Convert.ToDouble(Nota1.Text);
			nota2 = Convert.ToDouble(Nota2.Text);
			nota3 = Convert.ToDouble(Nota3.Text);
			nota4 = Convert.ToDouble(Nota4.Text);
			nota5 = Convert.ToDouble(Nota5.Text);

			Promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
			Prom.Text = Promedio.ToString();
		}
		else
		{
			DisplayAlert("Error", "ingrese todos los digitos", "OK");
		}
    }

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite cerrar el programa al presionar un boton designado
    ///por medio de una funcion lambda
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void Cerrar_Clicked(object sender, EventArgs e) => Close();

    private void Close()
    {
        throw new NotImplementedException();
    }
}

