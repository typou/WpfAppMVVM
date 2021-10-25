using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using static WpfAppMVVM.Model;

namespace WpfAppMVVM
{
    class ViewModel 
    {
        public ObservableCollection<Company> Elements { get; set; }
        public ObservableCollection<ElementN> ElEx {get; set; }
        public ViewModel()
        {
            Random rnd = new Random();

            Elements = new ObservableCollection<Company>();
            
            for (var i = 1; i < 11; i++)
            {
                ElEx = new ObservableCollection<ElementN>();
                var r = rnd.Next(0, 10);
                for (var j = 0; j < r; j++)
                {
                    ElEx.Add(new ElementN
                    {
                        Title = $"Элемент {rnd.Next(0, 10)}"
                    });
                }

                Elements.Add(new Company {
                    Category = $"Категория {i}",
                    ElementsEx = ElEx
                });

            }

        }
        public void AddElements()
        {
            Random rnd = new Random();

            var count = Elements.Count + 11;

            for (var i = Elements.Count + 1; i < count; i++)
            {
                ElEx = new ObservableCollection<ElementN>();
                var r = rnd.Next(0, 10);
                for (var j = 0; j < r; j++)
                {
                    ElEx.Add(new ElementN
                    {
                        Title = $"Элемент {rnd.Next(0, 10)}"
                    });
                }

                Elements.Add(new Company
                {
                    Category = $"Категория {i}",
                    ElementsEx = ElEx
                });

            }
        }
    }
}
