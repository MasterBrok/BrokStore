using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrokStore.Controls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokStore.Controls"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BrokStore.Controls;assembly=BrokStore.Controls"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:ccItem/>
    ///
    /// </summary>
    public class ccItem : MenuItem
    {
        static ccItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccItem), new FrameworkPropertyMetadata(typeof(ccItem)));
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ccItem), new PropertyMetadata(default));



        public string SubTitle
        {
            get { return (string)GetValue(SubTitleProperty); }
            set { SetValue(SubTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubTitleProperty =
            DependencyProperty.Register("SubTitle", typeof(string), typeof(ccItem), new PropertyMetadata(default));



        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(ccItem), new PropertyMetadata(default));



        public string TitleDescription
        {
            get { return (string)GetValue(TitleDescriptionProperty); }
            set { SetValue(TitleDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleDescriptionProperty =
            DependencyProperty.Register("TitleDescription", typeof(string), typeof(ccItem), new PropertyMetadata(default));





        public Geometry PathGeometry
        {
            get { return (Geometry)GetValue(PathGeometryProperty); }
            set { SetValue(PathGeometryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PathGeometry.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PathGeometryProperty =
            DependencyProperty.Register("PathGeometry", typeof(Geometry), typeof(ccItem), new PropertyMetadata(default));




        public string SubItem1
        {
            get { return (string)GetValue(SubItem1Property); }
            set { SetValue(SubItem1Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubItem1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubItem1Property =
            DependencyProperty.Register("SubItem1", typeof(string), typeof(ccItem), new PropertyMetadata(default));

        public string SubItem2
        {
            get { return (string)GetValue(SubItem2Property); }
            set { SetValue(SubItem2Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubItem3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubItem2Property =
            DependencyProperty.Register("SubItem2", typeof(string), typeof(ccItem), new PropertyMetadata(default));
        public string SubItem3
        {
            get { return (string)GetValue(SubItem3Property); }
            set { SetValue(SubItem2Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubItem3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubItem3Property =
            DependencyProperty.Register("SubItem3", typeof(string), typeof(ccItem), new PropertyMetadata(default));

        public string SubItem4
        {
            get { return (string)GetValue(SubItem4Property); }
            set { SetValue(SubItem2Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubItem4.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubItem4Property =
            DependencyProperty.Register("SubItem4", typeof(string), typeof(ccItem), new PropertyMetadata(default));






        public string ThisContent
        {
            get { return (string)GetValue(ThisContentProperty); }
            set { SetValue(ThisContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThisContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThisContentProperty =
            DependencyProperty.Register("ThisContent", typeof(string), typeof(ccItem), new PropertyMetadata(default));







    }
}
