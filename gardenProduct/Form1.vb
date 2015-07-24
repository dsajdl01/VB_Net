Public Class Form1
    Dim FileName As String
    Dim NumberOfRecord As Short
    Dim MyFormat As String = "{0, -5}{1, -21}{2, -12}{3, -10}{4, -5}"

    Structure ProductType
        Dim ProductID As Short
        <VBFixedString(18)> Public Description As String
        Dim Price As Decimal
        Dim QuantityStock As Short
        Dim RecordLevel As Short
    End Structure
    Dim OpenProduct As ProductType
        
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim OneProduct As ProductType
        FileName = "Products.txt"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OneProduct))
        NumberOfRecord = LOF(1) / Len(OneProduct)
        lblNumOfRecord.Text = NumberOfRecord
        FileClose(1)
    End Sub

    Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecord.Click
        Dim OneProduct As ProductType
        OneProduct.ProductID = txtProductID.Text
        OneProduct.Description = txtDescription.Text
        OneProduct.Price = txtPrice.Text
        OneProduct.QuantityStock = txtQuantity.Text
        OneProduct.RecordLevel = cboRecord.Text
        FileOpen(1, FileName, OpenMode.Random, , , Len(OneProduct))
        FilePut(1, OneProduct, NumberOfRecord + 1)
        FileClose(1)
        NumberOfRecord = NumberOfRecord + 1
        lblNumOfRecord.Text = NumberOfRecord
        txtProductID.Clear()
        txtProductID.Focus()
        txtDescription.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cboRecord.Text = 50
    End Sub

    Private Sub btnDisplayFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFile.Click
        Dim i As Integer
        Dim OneProduct As ProductType
        lstDisplayFile.Items.Clear()
        FileOpen(1, FileName, OpenMode.Random, , , Len(OneProduct))
        For i = 1 To NumberOfRecord
            FileGet(1, OneProduct)
            lstDisplayFile.Items.Add(String.Format(MyFormat, OneProduct.ProductID, OneProduct.Description, Format(OneProduct.Price, "Currency"), OneProduct.QuantityStock, OneProduct.RecordLevel))
        Next i
        FileClose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim RecordNumber As Integer
        Dim OneProduct As ProductType
        RecordNumber = txtSearchRecord.Text
        If (RecordNumber > 0) And (RecordNumber <= NumberOfRecord) Then
            FileOpen(1, FileName, OpenMode.Random, , , Len(OneProduct))
            FileGet(1, OneProduct, RecordNumber)
            Call DisplayOneProcedure(OneProduct)
            FileClose()
        Else
            MsgBox("Invalid record number")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim RecordNumber As Integer
        Dim Found As Boolean = False
        Dim ProductID As String
        Dim OneProduct As ProductType
        ProductID = txtSearchProduct.Text
        FileOpen(1, FileName, OpenMode.Random, , , Len(OneProduct))
        Do While (Not EOF(1)) And Found = False
            RecordNumber = RecordNumber + 1
            FileGet(1, OneProduct, RecordNumber)
            If OneProduct.ProductID = ProductID Then
                Found = True
            End If
        Loop
        FileClose(1)
        If Found Then
            Call DisplayOneProcedure(OneProduct)
        Else
            MsgBox("Invalid Product ID ")
        End If
    End Sub
    Private Sub DisplayOneProcedure(ByVal Product As ProductType)
        lblProductID.Text = Product.ProductID
        lblDescription.Text = Product.Description
        lblPrice.Text = Product.Price
        lblQuantity.Text = Product.QuantityStock
        lblRecord.Text = Product.RecordLevel
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MyTitleFont As New Font("Arial", 16, FontStyle.Bold Or FontStyle.Underline)
        Dim MyHeadFont As New Font("Arial", 14, FontStyle.Bold)
        Dim MyFont As New Font("Arial", 12, FontStyle.Regular)
        Dim MyHeadFormat As String = "{0, -16}{1, -30}{2, -14}{3, -18}{4, -18}"
        Dim MyBodyFormat As String = "{0, -24}{1, -30}"
        Dim LineToPrint As String
        Dim x, y, FontHeight As Integer
        Dim TotalStock, TotalQnt As Double
        Dim OneProduct As ProductType
        FontHeight = MyFont.GetHeight(e.Graphics)
        x = 250
        y = 50
        LineToPrint = "Report on Garden Centre stock"
        e.Graphics.DrawString(LineToPrint, MyTitleFont, Brushes.Black, x, y)
        y = y + FontHeight + 50
        x = 50
        LineToPrint = String.Format(MyHeadFormat, "Product ID", "Description", "Price", "Qty in Stock", "Stock Value")
        e.Graphics.DrawString(LineToPrint, MyHeadFont, Brushes.Black, x, y)
        y = y + 2
        x = 40
        LineToPrint = ""
        For z As Short = 0 To 76
            LineToPrint = LineToPrint & "_"
        Next z
        e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
        y = y + FontHeight + 6

        FileOpen(1, FileName, OpenMode.Random, , , Len(OneProduct))
        For i As Short = 1 To NumberOfRecord
            FileGet(1, OneProduct)
            TotalQnt = OneProduct.Price * OneProduct.QuantityStock
            TotalStock = TotalStock + TotalQnt
            x = 60
            LineToPrint = String.Format(MyBodyFormat, OneProduct.ProductID, OneProduct.Description)
            e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
            LineToPrint = Format(OneProduct.Price, "Currency")
            x = 400
            e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
            x = 520
            LineToPrint = OneProduct.QuantityStock
            e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
            x = 660
            LineToPrint = Format(TotalQnt, "Currency")
            e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
            y = y + FontHeight
        Next i
        FileClose()
        y = y - 17
        x = 173
        LineToPrint = ""
        For z As Short = 0 To 48
            LineToPrint = LineToPrint & "_"
        Next z
        'e.Graphics.DrawString(LineToPrint, MyTitleFont, Brushes.Black, x, y)
        y = y + FontHeight + 20
        x = 400
        LineToPrint = "Total stock value:"
        e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, x, y)
        x = 660
        e.Graphics.DrawString(Format(TotalStock, "Currency"), MyFont, Brushes.Black, x, y)
    End Sub
End Class
