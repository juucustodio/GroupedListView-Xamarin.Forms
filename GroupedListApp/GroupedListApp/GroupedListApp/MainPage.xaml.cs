using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroupedListApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Categoria> ListaAgrupada { get; set; }
        public MainPage()
        {
            InitializeComponent();

            ListaAgrupada = new ObservableCollection<Categoria>();

            //Avião
            var aviaoCategoria = new Categoria() { LongName = "Avião", ShortName = "A" };
            
            aviaoCategoria.Add(new Transporte { Nome = "Airbus A380", Descricao = "Aeronave widebody quadrimotor a jato" });
            aviaoCategoria.Add(new Transporte { Nome = "Antonov An-225 Mriya", Descricao = "Aeronave de transporte cargueiro estratégico" });
            aviaoCategoria.Add(new Transporte { Nome = "Boeing 777", Descricao = "Aeronave widebody bimotor turbofan" });

            ListaAgrupada.Add(aviaoCategoria);

            //Carro
            var carroCategoria = new Categoria() { LongName = "Carro", ShortName = "C" };

            carroCategoria.Add(new Transporte { Nome = "Bentley Continental GTC", Descricao = "Grand tourer de duas portas com capacidade para 4 passageiros" });
            carroCategoria.Add(new Transporte { Nome = "LaFerrari", Descricao = "Carro esportivo coupé, duas portas, dois lugares, de motor central traseiro" });
            carroCategoria.Add(new Transporte { Nome = "Maserati Ghibli", Descricao = "Motor V6 turbodiesel de 250 cv ou 275 cv" });

            ListaAgrupada.Add(carroCategoria);

            //Moto
            var motoCategoria = new Categoria() { LongName = "Moto", ShortName = "M" };

            motoCategoria.Add(new Transporte { Nome = "BMW R 1200 GS", Descricao = "Motocicleta com motor boxer bicilíndrico de 4 tempos, Refrigeração líquida e a ar" });
            motoCategoria.Add(new Transporte { Nome = "Suzuki Hayabusa", Descricao = "Motocicleta Hyper Sport originalmente apresentada pela Suzuki em 1999" });
            motoCategoria.Add(new Transporte { Nome = "Yamaha YZF-R1", Descricao = "Motocicleta superesportiva fabricada pela Yamaha a partir do ano de 1998" });
            
            ListaAgrupada.Add(motoCategoria);

            listView.ItemsSource = ListaAgrupada;
        }
    }
}
