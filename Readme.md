# How to bind a chart to data from an MDB file


<p>The following example demonstrates how to bind a DXCharts control to an MDB database. For this, it is necessary to add a corresponding DataSet to a project, set the <strong>ArgumentScaleType</strong>, <strong>ArgumentDataMember</strong>, <strong>ValueScaleType</strong> and <strong>ValueDataMember</strong> properties to the required values. Then, in a code-behind <strong>Window.Initialize</strong> method, you can obtain all data from a DataSet using the data adapter's <strong>GetData</strong> method, and assign these data to a series' <strong>DataSource</strong> property.</p>

<br/>


