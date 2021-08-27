<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1270)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to bind a chart to data from an MDB file


<p>The following example demonstrates how to bind a DXCharts control to an MDB database. For this, it is necessary to add a corresponding DataSet to a project, set the <strong>ArgumentScaleType</strong>, <strong>ArgumentDataMember</strong>, <strong>ValueScaleType</strong> and <strong>ValueDataMember</strong> properties to the required values. Then, in a code-behind <strong>Window.Initialize</strong> method, you can obtain all data from a DataSet using the data adapter's <strong>GetData</strong> method, and assign these data to a series' <strong>DataSource</strong> property.</p>

<br/>


