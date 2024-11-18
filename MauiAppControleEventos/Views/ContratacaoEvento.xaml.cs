using MauiAppControleEventos.Models;

namespace MauiAppControleEventos.Views;

public partial class ContratacaoEvento : ContentPage
{
	public ContratacaoEvento()
	{
		InitializeComponent();
	}
	public void Button_Clicked(object sender, EventArgs e)
	{
        try
        {
            Evento evento = new Evento
            {
                Nome = txt_nome.Text,
                LocalEvento = txt_local.Text,
                ValorParticipante = Convert.ToDouble(txt_valor.Text),
                QntParticipantes = Convert.ToInt32(txt_qntParticipante.Text),
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date,
            };

            Navigation.PushAsync(new EventoContratado()
            {
                BindingContext = evento
            });

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}