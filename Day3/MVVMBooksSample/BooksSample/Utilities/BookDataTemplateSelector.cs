using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BooksSample.Utilities
{
    public class BookDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultBookTemplate { get; set; }
        public DataTemplate WroxBookTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate currentTemplate = null;
            if (item is Book book)
            {
                switch (book.Publisher)
                {
                    case "Wrox Press":
                        currentTemplate = WroxBookTemplate;
                        break;
                    default:
                        currentTemplate = DefaultBookTemplate;
                        break;
                }
            }
            return currentTemplate;
        }
    }
}
