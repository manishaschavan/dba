Imports System
Imports System.IO
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.VisualBasic.Strings
Imports Microsoft.VisualBasic.Conversion

Public Class clsdb2x : Inherits System.Web.UI.Page
    Protected connect As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
    Protected WithEvents ListBox1 As System.Web.UI.WebControls.ListBox
    Protected WithEvents message As System.Web.UI.WebControls.Label
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmdXML As SqlCommand
        Dim DScmdXML As SqlDataAdapter
        Dim DSXML As New DataSet()
        Dim sqlXML As String
        Dim i, j As Integer
        Dim strPCode As String = ""
        Dim arrpcode As System.Array
        Dim xmlSW As System.IO.StreamWriter

        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).Selected Then
                If strPCode = "" Then
                    strPCode = ListBox1.Items(i).Text
                Else
                    strPCode = strPCode + "," + ListBox1.Items(i).Text
                End If
            End If
        Next
        arrpcode = strPCode.ToString.Split(",")
        For j = 0 To arrpcode.Length - 1
            Try
                Select Case UCase(arrpcode(j))
                    Case "PRODUCT"
                        sqlXML = "Select ProductCode, ProductName from Product "
                        cmdXML = New SqlCommand(sqlXML, connect)
                        DScmdXML = New SqlDataAdapter(cmdXML)
                        DScmdXML.Fill(DSXML, "Product")
                        Response.Write("<font face=verdana size=1>" & "Successfully Converted Table " & arrpcode(j) & " to Product.xml" & "</font>")
                        Response.Flush()
                        DSXML.WriteXml("Product.xml", XmlWriteMode.WriteSchema)
                        Dim xmlSW2 As System.IO.StreamWriter = New System.IO.StreamWriter("Product.xml")
                        DSXML.WriteXml(xmlSW2, XmlWriteMode.WriteSchema)
                        xmlSW2.Flush()
                        xmlSW2.Close()
                End Select
            Catch ex As Exception
                Response.Write(ex.Message)
            End Try
        Next
    End Sub


End Class