using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChurrasApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ParForecastList.HeightRequest = 250;
            ConForecastList.HeightRequest = 250;
            this.BindingContext = this;
        }

        public List<Participante> Participantes { get => ParData(); }

        private List<Participante> ParData()
        {
            var tempList = new List<Participante>();
            tempList.Add(new Participante { Val = "40", Name = "Você", Icon = "pago.png" });
            tempList.Add(new Participante { Val = "40", Name = "Thiago Peixoto", Icon = "pago.png" });
            tempList.Add(new Participante { Val = "20", Name = "Zezinho Santos", Icon = "nop.png" });
            tempList.Add(new Participante { Val = "20", Name = "Raimunda de Costa", Icon = "pago.png" });
            tempList.Add(new Participante { Val = "20", Name = "Jão Oliveira", Icon = "nop.png" });
            tempList.Add(new Participante { Val = "20", Name = "Vitoria Souza", Icon = "pago.png" });
            tempList.Add(new Participante { Val = "40", Name = "Manu de Paula", Icon = "pago.png" });
            return tempList;

        }

        public List<Convidado> Convidados { get => ConData(); }

        private List<Convidado> ConData()
        {
            var cList = new List<Convidado>();
            cList.Add(new Convidado { Npar = "Você", Ncon = "Guilherme Rosa", Icon = "pago.png" });
            cList.Add(new Convidado { Npar = "Thiago Peixoto", Ncon = "Rafaela Oliveira", Icon = "pago.png" });
            cList.Add(new Convidado { Npar = "Manu de Paula", Ncon = "Ricardo Pereira", Icon = "pago.png" });

            return cList;
        }

    }

    public class Participante
    {
        public string Val { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }



    }
    public class Convidado
    {
        public string Npar { get; set; }
        public string Ncon { get; set; }
        public string Icon { get; set; }
    }

}
