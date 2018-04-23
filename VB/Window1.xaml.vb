Imports Microsoft.VisualBasic
Imports System.Windows

Namespace WpfApplication1

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

            carSeries.DataSource = _
                New CarsDBDataSetTableAdapters.CarsTableAdapter().GetData()
		End Sub
	End Class
End Namespace
