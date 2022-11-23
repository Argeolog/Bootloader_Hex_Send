Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Argeoloji_Usb_HID_Library
Public Class Anasayfa
    '********************************************
    'Hasan Atmaca 23.11.2022
    'argelojik@gmail.com
    '*******************************************

    Private ReadOnly Usb1 As New Usb_HID_Port(&H7E6, &H7E6)
    ReadOnly FlashYaz As Integer = 150
    ReadOnly FlashSil As Integer = 151
    ReadOnly CihazAyarFlashSil As Integer = 152
    ReadOnly YazmaTamamlandi As Integer = 153
    ReadOnly CihazAdiEslestir As Integer = 154
    ReadOnly CihazAdiYaz As Integer = 155
    ReadOnly CihazAdiOku As Integer = 156

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Usb1.RegisterHandleNotifications(Me.Handle)
        AddHandler Usb1.Usb_Plug_Event, AddressOf Usb_Takildi_Cikarildi
        If Usb1.CheckDevicePresent() = False Then
            Cihaz_Durumu_Label.Text = "Cihaz Bağlı Değil"
            Cihaz_Durumu_Label.ForeColor = Color.Red
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        Try
            Usb1.ParseMessages(m)
            MyBase.WndProc(m)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Usb_Takildi_Cikarildi(ByVal o As Object, ByVal e As EventArgs)

        If Usb1.CihazBagli = True Then
            Cihaz_Durumu_Label.Text = "Cihaz Bağlı"
            Cihaz_Durumu_Label.ForeColor = Color.Green
        Else
            Cihaz_Durumu_Label.Text = "Cihaz Bağlı Değil"
            Cihaz_Durumu_Label.ForeColor = Color.Red
        End If
    End Sub
    Sub DataGrid_Hazirla()
        For i = 0 To 20
            Hex_Datagrid.Rows.Add("")
        Next
    End Sub



    Private Sub Hex_Sec_Buton_Click(sender As Object, e As EventArgs) Handles Hex_Sec_Buton.Click


        Dim Op As New OpenFileDialog With {
            .Filter = "Mikro İşlemci Dosyası(*.hex,*.bin)|*.hex;*.bin"
        }

        If Op.ShowDialog = DialogResult.OK Then
            Verileri_Yerlestir(Op.FileName)
        End If

        Dim AyarYaz As New StreamWriter("Ayar.ini")
        AyarYaz.WriteLine(Op.FileName)
        AyarYaz.Close()

    End Sub


    Sub Verileri_Yerlestir(Dosyayolu As String)

        Dosya_Yolu_Text.Text = Dosyayolu
        Application.DoEvents()
        Hex_Datagrid.BeginEdit(True)
        Hex_Datagrid.Rows.Clear()
        Me.Cursor = Cursors.WaitCursor
        Dim Dosya() As String = Dosyayolu.Split(".")
        Dim DosyaAdi As String = Dosya(Dosya.Count - 1)
        Dim ArrList(17) As String
        Dim BinBaslangic As Integer = 0
        If DosyaAdi = "bin" Then
            Try

                Dim bin() As Byte
                Using s As New FileStream(Dosyayolu, FileMode.Open, FileAccess.Read)
                    bin = New Byte(s.Length - 1) {}
                    s.Read(bin, 0, bin.Length)
                End Using
                Dim Say As Integer
                Dim Adres As String
                Dim ileriAkis As Integer
                Dim ArraylistSay As Integer
                Dim Strx As String
                For ir = 0 To bin.Count - 1 Step 16
                    Adres = CStr((Say * 16))
                    ArraylistSay = 0
                    ArrList(ArraylistSay) = "0x" & Hex(Adres).PadLeft(9, "0")
                    ileriAkis = ir + 16
                    Strx = ""
                    For ix = ir To ileriAkis - 1


                        If ix >= bin.Count Then
                            Exit For
                        End If

                        ArraylistSay += 1
                        ArrList(ArraylistSay) = Hex(bin(ix)).PadLeft(2, "0")

                        Dim intx As Integer = Convert.ToInt32(ArrList(ArraylistSay), 16)
                        If intx < 32 Then
                            Strx &= "."
                        Else
                            Strx &= Chr(intx)
                        End If


                    Next
                    ArrList(17) = Strx
                    Hex_Datagrid.Rows.Add(ArrList)
                    BinBaslangic += 16
                    Say += 1

                Next
            Catch ex As Exception
                MsgBox(BinBaslangic & " " & ex.Message)
            End Try


        Else

            Dim St As New StreamReader(Dosyayolu)
            Dim HxStr As String = St.ReadToEnd
            St.Close()
            HxStr = HxStr.Replace(":", "")
            HxStr = HxStr.Replace(vbCr, "")
            Dim HxArray() As String = HxStr.Split(vbLf)
            Dim HxAll As String
            Dim Checkdijit As String
            For ir = 1 To HxArray.Count - 4
                Try
                    HxAll = HxArray(ir)
                    If HxAll.Length > 0 Then
                        Dim HexUzunlugu As Double = HxAll.Length - 2
                        If HexUzunlugu Mod 2 = 0 Then
                            Checkdijit = IntelHexChecksum(HxAll.Substring(0, HexUzunlugu))
                            If HxArray(ir).Substring(HxAll.Length - 2, 2) = Checkdijit Then

                                Dim HamHexData As String = HxArray(ir).Substring(8, HxAll.Length - 10)
                                Dim HexCharArray() As Char = HamHexData.ToCharArray
                                Dim Ascx As String = ""
                                Dim Sayac As Integer = 0
                                Dim TumHex As String
                                For Ax = 0 To HexCharArray.Count - 1 Step 2
                                    TumHex = HexCharArray(Ax) & HexCharArray(Ax + 1)
                                    Sayac += 1
                                    ArrList(Sayac) = TumHex
                                    Dim intx As Integer = Convert.ToInt32(TumHex, 16)
                                    If intx < 32 Then
                                        Ascx &= "."
                                    Else
                                        Ascx &= Chr(intx)
                                    End If
                                Next

                                Dim Sonuc As String = Hex((ir - 1) * 16)
                                ArrList(0) = "0x" & Sonuc.PadLeft(9, "0")
                                ArrList(17) = Ascx
                                Hex_Datagrid.Rows.Add(ArrList)
                            Else
                                MsgBox(ir + 1 & ".Satırda Check Dijit Hatalı !")
                                Exit For
                            End If
                        Else
                            MsgBox("Geçersiz Hex Uzunluğu")
                            Exit For
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If

        Me.Cursor = Cursors.Default
        Hex_Datagrid.EndEdit()
    End Sub





    Function IntelHexChecksum(MyData As String) As String
        Dim checksum As Integer
        checksum = 0
        For a = 1 To Len(MyData) Step 2
            checksum += CDec("&H" & Mid(MyData, a, 2))
        Next
        checksum = ((checksum Xor 255) + 1) And 255
        Return Hex(checksum).PadLeft(2, "0")
    End Function

    Enum Data_Record_Type
        DataRecord = 0
        EndOfFile = 1
        ExtendedSegmentAdres = 2
        StartSegmentAdress = 3
        ExtendedLineerAdres = 4
        StartLineerAdress = 5
    End Enum


    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGrid_Hazirla()
        Dim AyarYolu As String
        Try
            Dim AyarOku As New StreamReader("Ayar.ini")
            AyarYolu = AyarOku.ReadLine
            AyarOku.Close()
            If File.Exists(AyarYolu) Then
                Verileri_Yerlestir(AyarYolu)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        Application.DoEvents()

    End Sub

    Private Sub Hex_Datagrid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Hex_Datagrid.CellPainting
        If e.Value = "00" Then
            e.CellStyle.BackColor = Color.YellowGreen
        End If

    End Sub

    Private Sub Gonder_Buton_Click(sender As Object, e As EventArgs) Handles Gonder_Buton.Click
        Dim SendBuffer(64) As Byte
        Dim GelenVeri(64) As Byte
        Dim HataOlustu As Boolean
        For Ex = 0 To SendBuffer.Length - 1
            SendBuffer(Ex) = 255
        Next
        Veri_ilerleme_Progress.Value = 0
        Application.DoEvents()
        Dim Valuex As String
        For i = 0 To Hex_Datagrid.RowCount - 1
            SendBuffer(1) = FlashYaz
            For ix = 1 To 16
                Valuex = Hex_Datagrid.Rows(i).Cells(ix).Value
                If Valuex <> "" Then
                    SendBuffer(ix + 1) = Convert.ToInt32(Valuex, 16)
                Else
                    SendBuffer(ix + 1) = 255
                End If
            Next

            Usb1.Send_Data(SendBuffer) ' Cihaza Soru Soruyoruz ve Ardından Cevap Bekliyoruz.
            Dim Deger As Integer = i * 100 / CInt(Hex_Datagrid.RowCount)
            Veri_ilerleme_Progress.Value = Deger

            If Usb1.Read_Data(GelenVeri, 250) Then
                If GelenVeri(2) <> 1 Then
                    HataOlustu = True
                    Exit For
                End If
            End If


            For ixr = 0 To 80000000 ' Bekleme İçin.. Çok hızlı yazmasın diye bekleme koydum.

            Next



            Application.DoEvents()
        Next
        If HataOlustu = False Then
            SendBuffer(1) = YazmaTamamlandi
            Usb1.Send_Data(SendBuffer) ' Cihaza Soru Soruyoruz ve Ardından Cevap Bekliyoruz.
            MsgBox("Yazma İşlemi Tamamlandı.")
        Else
            MsgBox("Hata Oluştu Cihaz Adı Doğrulanmadı veya Veri Yazılamadı")
        End If



    End Sub

    Private Sub Veri_ilerleme_Progress_Click(sender As Object, e As EventArgs) Handles Veri_ilerleme_Progress.Click

    End Sub

    Private Sub Flash_Hafiza_Sil_Buton_Click(sender As Object, e As EventArgs) Handles Flash_Hafiza_Sil_Buton.Click
        Dim SendBuffer(64) As Byte
        SendBuffer(1) = FlashSil
        Usb1.Send_Data(SendBuffer)
        If Usb1.Read_Data(SendBuffer, 1000) Then
            If SendBuffer(2) = 1 Then
                MsgBox("işlem Başarılı")
            Else
                MsgBox("işlem Başarısız")
            End If
        Else
            MsgBox("Cihazdan Bilgi Gelmedi.")
        End If


    End Sub

    Private Sub Cihaz_Adi_Yaz_Click(sender As Object, e As EventArgs) Handles Cihaz_Adi_Yaz.Click
        Dim SendBuffer(64) As Byte
        Dim CihazAdi() As Char = Cihaz_Adi_Text.Text.ToCharArray
        SendBuffer(1) = CihazAdiYaz
        SendBuffer(2) = 91 '[
        Dim Yaziuzunlugu As Integer = CihazAdi.Length
        For i = 0 To Yaziuzunlugu - 1
            SendBuffer(i + 3) = AscW(CihazAdi(i))
        Next
        SendBuffer(Yaziuzunlugu + 3) = 93 ']
        Usb1.Send_Data(SendBuffer)

        If Usb1.Read_Data(SendBuffer, 1000) Then
            If SendBuffer(2) = 1 Then
                MsgBox("işlem Başarılı")
            Else
                MsgBox("işlem Başarısız")
            End If
        Else
            MsgBox("Cihazdan Bilgi Gelmedi.")
        End If

    End Sub

    Private Sub Cihaz_Adi_Dogru_mu_Buton_Click(sender As Object, e As EventArgs) Handles Cihaz_Adi_Dogru_mu_Buton.Click


        Dim SendBuffer(64) As Byte
        Dim CihazAdi() As Char = Cihaz_Adi_Text.Text.ToCharArray
        SendBuffer(1) = CihazAdiEslestir
        SendBuffer(2) = 91 '[
        Dim Yaziuzunlugu As Integer = CihazAdi.Length
        For i = 0 To Yaziuzunlugu - 1
            SendBuffer(i + 3) = Asc(CihazAdi(i))
        Next
        SendBuffer(Yaziuzunlugu + 3) = 93 ']
        Usb1.Send_Data(SendBuffer)

        If Usb1.Read_Data(SendBuffer, 1000) Then
            If SendBuffer(2) = 1 Then
                MsgBox("Evet İşlemcinin İçindeki Yazılım " & Cihaz_Adi_Text.Text)
            Else
                MsgBox("Hayır İşlemcinin İçindeki Yazılım " & Cihaz_Adi_Text.Text & " Değil")
            End If
        Else
            MsgBox("Cihazdan Bilgi Gelmedi.")
        End If

    End Sub

    Private Sub Cihaz_Adi_Oku_Buton_Click(sender As Object, e As EventArgs) Handles Cihaz_Adi_Oku_Buton.Click
        Dim SendBuffer(64) As Byte
        SendBuffer(1) = CihazAdiOku
        Usb1.Send_Data(SendBuffer)

        If Usb1.Read_Data(SendBuffer, 1000) Then
            If SendBuffer(2) = 1 Then
                Dim CihazAdi As String = ""
                Dim CharCode As Char
                For i = 4 To 9
                    CharCode = ChrW(SendBuffer(i))
                    If CharCode = "]" Then
                        Exit For
                    End If
                    CihazAdi &= CharCode

                Next


                MsgBox("Cihaz Adı:" & CihazAdi & vbCrLf & "işlem Başarılı")
            Else
                MsgBox("işlem Başarısız")
            End If
        Else
            MsgBox("Cihazdan Bilgi Gelmedi.")
        End If
    End Sub

    Private Sub Cihaz_Ayar_Page_Sil_Buton_Click(sender As Object, e As EventArgs) Handles Cihaz_Ayar_Page_Sil_Buton.Click
        Dim SendBuffer(64) As Byte
        SendBuffer(1) = CihazAyarFlashSil
        Usb1.Send_Data(SendBuffer)

        If Usb1.Read_Data(SendBuffer, 1000) Then
            If SendBuffer(2) = 1 Then
                MsgBox("işlem Başarılı")
            Else
                MsgBox("işlem Başarısız")
            End If
        Else
            MsgBox("Cihazdan Bilgi Gelmedi.")
        End If

    End Sub


End Class
