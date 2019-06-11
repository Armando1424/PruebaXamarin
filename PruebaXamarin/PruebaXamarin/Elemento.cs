using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaXamarin
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos
    {
        public List<Elemento> _elementos { get; set; }
        public ListaElementos()
        {
            _elementos = new List<Elemento>();
            LoadElements();
        }

        private void LoadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre = "MainPage",
                Descripcion = "Uso de Button, entry, image e intent"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "MainStart",
                Descripcion = "TableView y atributos"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "HomePage",
                Descripcion = "Permanencia de datos"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "SliderPage",
                Descripcion = "Uso de Slider"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "PickerElementPage",
                Descripcion = "Selector desplegable"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "DatePickerElementPage",
                Descripcion = "Selector de fechas"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "ActivityIndicatorPage",
                Descripcion = "Barra de progreso"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "HamburgerMenuPage",
                Descripcion = "Menu Hamburguesa"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "TabAppPage",
                Descripcion = "Página con tabs"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "MasterDetailPage1",
                Descripcion = "Página con tabs"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "ListViewPage1",
                Descripcion = "Página con tabs"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "View1",
                Descripcion = "Página con tabs"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "TabbedPage1",
                Descripcion = "Página con tabs"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "CarouselPage1",
                Descripcion = "Pagina tipo Carrusel"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "GridLayoutPage",
                Descripcion = "Pagina Con Grid"
            });

        }
    }
}
