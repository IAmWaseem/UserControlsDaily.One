using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UserControlsDaily
{
	public sealed partial class SquareTileControl : UserControl
	{
		public SquareTileControl()
		{
			this.InitializeComponent();
		}



		public String Title
		{
			get { return ( String )GetValue( TitleProperty ); }
			set { SetValue( TitleProperty, value ); }
		}

		// Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty TitleProperty =
			DependencyProperty.Register( "Title", typeof( String ), typeof( SquareTileControl ), new PropertyMetadata( String.Empty ) );



		public String Description
		{
			get { return ( String )GetValue( DescriptionProperty ); }
			set { SetValue( DescriptionProperty, value ); }
		}

		// Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty DescriptionProperty =
			DependencyProperty.Register( "Description", typeof( String ), typeof( SquareTileControl ), new PropertyMetadata( String.Empty ) );



		public ImageSource Icon
		{
			get { return ( ImageSource )GetValue( IconProperty ); }
			set { SetValue( IconProperty, value ); }
		}

		// Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IconProperty =
			DependencyProperty.Register( "Icon", typeof( ImageSource ), typeof( SquareTileControl ), new PropertyMetadata( null ) );



		public int TileSize
		{
			get { return ( int )GetValue( TileSizeProperty ); }
			set { SetValue( TileSizeProperty, value ); }
		}

		// Using a DependencyProperty as the backing store for TileSize.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty TileSizeProperty =
			DependencyProperty.Register( "TileSize", typeof( int ), typeof( SquareTileControl ), new PropertyMetadata( 200 ) );

		public TextAlignment TitleAlignment
		{
			get
			{
				return tbTitle.TextAlignment;
			}
			set
			{
				tbTitle.TextAlignment = value;
			}
		}

		public TextAlignment DescriptionAlignment
		{
			get
			{
				return tbDescription.TextAlignment;
			}
			set
			{
				tbDescription.TextAlignment = value;
			}
		}

		public event EventHandler Click;
		private void Grid_Tapped( object sender, TappedRoutedEventArgs e )
		{
			if ( Click != null )
			{
				Click( this, EventArgs.Empty );
			}
		}

	}
}
