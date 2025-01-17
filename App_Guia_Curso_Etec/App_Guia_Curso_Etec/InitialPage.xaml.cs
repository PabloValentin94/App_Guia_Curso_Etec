﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class InitialPage : ContentPage
    {

        public InitialPage()
        {

            InitializeComponent();

            imgbtn_hallowtec.Source = ImageSource.FromResource("App_Guia_Curso_Etec.View.Images.hallowtec.png");

            /*lbl_sobre_unidade.Text = "A unidade iniciou as atividades em 1928, com cursos de Fundição, " +
                                       "de Mecânica de Máquinas, de Marcenaria e de Corte e Costura. Em 1985, " +
                                       "a Etec passou a integrar as escolas da Divisão de Supervisão e Apoio as Escolas " +
                                       "Técnicas Estaduais e, em 1991, foi transferida para a Divisão Estadual de Ensino " +
                                       "Técnico (D.E.E.T.) da Secretaria de Ciência, Tecnologia e Desenvolvimento Econômico. " +
                                       "Foi incorporada ao Centro Paula Souza em 1994.";*/

            /*lbl_endereco.Text = "País: Brasil.\n\nEstado: São Paulo (S.P.).\n\nCidade: Jaú.\n\n" +
                                  "Rua: Humaitá.\n\nNº: 1090 - Centro.\n\nCEP: 17.201-320";*/

        }

        private async void imgbtn_hallowtec_Clicked(object sender, EventArgs e)
        {

            try
            {

                Device.OpenUri(new Uri("https://www.instagram.com/hallowtec2022"));

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_vestibulinho_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new View.Pages.Vestibulinho());

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_meios_contato_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new View.Pages.Meios_Contato());

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}