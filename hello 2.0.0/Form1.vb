
Imports System.Net



Public Class Form1
    Dim wc As WebClient

    Private pbStatus As Object

    Public Class frmDownload
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wc = New WebClient()

        FolderBrowserDialog1.SelectedPath = My.Settings.saveloc


    End Sub


    Private Sub RdToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CompanyDataAddToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DownloadDataToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub RestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Settings.Reset()
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangeDownlaodToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Afghanistan_Click(sender As Object, e As EventArgs) Handles Afghanistan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Afghanistan.zip"), FolderBrowserDialog1.SelectedPath + "/Afghanistan.zip")


    End Sub
    Private Sub ProgChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim totalSize As Long = e.TotalBytesToReceive
        Dim percentage As Integer = e.ProgressPercentage
        Dim downloadedBytes As Long = e.BytesReceived
        Label2.Text = String.Format("{0} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00") + "MB's")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowDialog()
        My.Settings.saveloc = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub hello_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblProgPerc_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Albania_Click(sender As Object, e As EventArgs) Handles Albania.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Albania.zip"), FolderBrowserDialog1.SelectedPath + "/Albania.zip")

    End Sub

    Private Sub Algeria_Click(sender As Object, e As EventArgs) Handles Algeria.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Algeria.zip"), FolderBrowserDialog1.SelectedPath + "/Algeria.zip")

    End Sub

    Private Sub All_Qatar_Click(sender As Object, e As EventArgs) Handles All_Qatar.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/All_Qatar.zip"), FolderBrowserDialog1.SelectedPath + "All_Qatar.zip")

    End Sub

    Private Sub Argentina_Click(sender As Object, e As EventArgs) Handles Argentina.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Argentina.zip"), FolderBrowserDialog1.SelectedPath + "Argentina.zip")

    End Sub

    Private Sub Austriaia_Click(sender As Object, e As EventArgs) Handles Austriaia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Austriaia.zip"), FolderBrowserDialog1.SelectedPath + "Austriaia.zip")

    End Sub

    Private Sub Azerbaijan_Click(sender As Object, e As EventArgs) Handles Azerbaijan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Azerbaijan.zip"), FolderBrowserDialog1.SelectedPath + "Azerbaijan.zip")

    End Sub

    Private Sub Bahrain_Click(sender As Object, e As EventArgs) Handles Bahrain.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Bahrain.zip"), FolderBrowserDialog1.SelectedPath + "Bahrain.zip")

    End Sub

    Private Sub Bangladesh_Click(sender As Object, e As EventArgs) Handles Bangladesh.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Bangladesh.zip"), FolderBrowserDialog1.SelectedPath + "Bangladesh.zip")

    End Sub

    Private Sub Belgium_Click(sender As Object, e As EventArgs) Handles Belgium.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Belgium.zip"), FolderBrowserDialog1.SelectedPath + "Belgium.zip")

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Bolivia.zip"), FolderBrowserDialog1.SelectedPath + "Bolivia.zip")

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Botswana.zip"), FolderBrowserDialog1.SelectedPath + "Botswana.zip")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/brazil.zip"), FolderBrowserDialog1.SelectedPath + "brazil.zip")
    End Sub

    Private Sub Brunei_Click(sender As Object, e As EventArgs) Handles Brunei.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Brunei.zip"), FolderBrowserDialog1.SelectedPath + "Brunei.zip")
    End Sub

    Private Sub Bulgaria_Click(sender As Object, e As EventArgs) Handles Bulgaria.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Bulgaria.zip"), FolderBrowserDialog1.SelectedPath + "Bulgaria.zip")
    End Sub

    Private Sub Burkina_Faso_Click(sender As Object, e As EventArgs) Handles Burkina_Faso.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Burkina_Faso.zip"), FolderBrowserDialog1.SelectedPath + "Burkina_Faso.zip")
    End Sub

    Private Sub Burundi_Click(sender As Object, e As EventArgs) Handles Burundi.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Burundi.zip"), FolderBrowserDialog1.SelectedPath + "Burundi.zip")
    End Sub

    Private Sub Cambodia_Click(sender As Object, e As EventArgs) Handles Cambodia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Cambodia.zip"), FolderBrowserDialog1.SelectedPath + "Cambodia.zip")
    End Sub

    Private Sub Chile_Click(sender As Object, e As EventArgs) Handles Chile.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Chile.zip"), FolderBrowserDialog1.SelectedPath + "Chile.zip")
    End Sub

    Private Sub Cameroon_Click(sender As Object, e As EventArgs) Handles Cameroon.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Cameroon.zip"), FolderBrowserDialog1.SelectedPath + "Cameroon.zip")
    End Sub

    Private Sub China_Click(sender As Object, e As EventArgs) Handles China.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/China.zip"), FolderBrowserDialog1.SelectedPath + "China.zip")
    End Sub

    Private Sub Colombia_Click(sender As Object, e As EventArgs) Handles Colombia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Colombia.zip"), FolderBrowserDialog1.SelectedPath + "Colombia.zip")
    End Sub

    Private Sub Costa_Rica_Click(sender As Object, e As EventArgs) Handles Costa_Rica.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Costa_Rica.zip"), FolderBrowserDialog1.SelectedPath + "Costa_Rica.zip")
    End Sub

    Private Sub Croatia_Click(sender As Object, e As EventArgs) Handles Croatia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Croatia.zip"), FolderBrowserDialog1.SelectedPath + "Croatia.zip")
    End Sub

    Private Sub Cyprus_Click(sender As Object, e As EventArgs) Handles Cyprus.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Cyprus.zip"), FolderBrowserDialog1.SelectedPath + "Cyprus.zip")
    End Sub

    Private Sub Czech_Republic_Click(sender As Object, e As EventArgs) Handles Czech_Republic.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Czech_Republic.zip"), FolderBrowserDialog1.SelectedPath + "Czech_Republic.zip")
    End Sub

    Private Sub Denmark_Click(sender As Object, e As EventArgs) Handles Denmark.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Denmark.zip"), FolderBrowserDialog1.SelectedPath + "Denmark.zip")
    End Sub

    Private Sub Dibouti_Click(sender As Object, e As EventArgs) Handles Dibouti.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Dibouti.zip"), FolderBrowserDialog1.SelectedPath + "Dibouti.zip")
    End Sub

    Private Sub Ecuador_Click(sender As Object, e As EventArgs) Handles Ecuador.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Ecuador.zip"), FolderBrowserDialog1.SelectedPath + "Ecuador.zip")
    End Sub

    Private Sub Egypt_Click(sender As Object, e As EventArgs) Handles Egypt.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Egypt_All.zip"), FolderBrowserDialog1.SelectedPath + "Egypt_All.zip")
    End Sub

    Private Sub El_Salvador_Click(sender As Object, e As EventArgs) Handles El_Salvador.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/El_Salvador.zip"), FolderBrowserDialog1.SelectedPath + "El_Salvador.zip")
    End Sub

    Private Sub Estonia_Click(sender As Object, e As EventArgs) Handles Estonia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Estonia.zip"), FolderBrowserDialog1.SelectedPath + "Estonia.zip")
    End Sub

    Private Sub Ethopia_Click(sender As Object, e As EventArgs) Handles Ethopia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Ethopia.zip"), FolderBrowserDialog1.SelectedPath + "Ethopia.zip")
    End Sub

    Private Sub Fiji_Click(sender As Object, e As EventArgs) Handles Fiji.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Fiji.zip"), FolderBrowserDialog1.SelectedPath + "Fiji.zip")
    End Sub

    Private Sub Finland_Text_Click(sender As Object, e As EventArgs) Handles Finland_Text.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Finland_Text.zip"), FolderBrowserDialog1.SelectedPath + "Finland_Text.zip")
    End Sub

    Private Sub France_Click(sender As Object, e As EventArgs) Handles France.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/France.zip"), FolderBrowserDialog1.SelectedPath + "France.zip")
    End Sub

    Private Sub Georgia_Click(sender As Object, e As EventArgs) Handles Georgia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Georgia.zip"), FolderBrowserDialog1.SelectedPath + "Georgia.zip")
    End Sub

    Private Sub Germany_Click(sender As Object, e As EventArgs) Handles Germany.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Germany.zip"), FolderBrowserDialog1.SelectedPath + "Germany.zip")
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Ghana.zip"), FolderBrowserDialog1.SelectedPath + "Ghana.zip")
    End Sub

    Private Sub Greece_Click(sender As Object, e As EventArgs) Handles Greece.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Greece.zip"), FolderBrowserDialog1.SelectedPath + "Greece.zip")
    End Sub

    Private Sub Guatemala_Click(sender As Object, e As EventArgs) Handles Guatemala.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Guatemala.zip"), FolderBrowserDialog1.SelectedPath + "Guatemala.zip")
    End Sub

    Private Sub Haiti_Click(sender As Object, e As EventArgs) Handles Haiti.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Haiti.zip"), FolderBrowserDialog1.SelectedPath + "Haiti.zip")
    End Sub

    Private Sub Honduras_Click(sender As Object, e As EventArgs) Handles Honduras.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Honduras.zip"), FolderBrowserDialog1.SelectedPath + "Honduras.zip")
    End Sub

    Private Sub Hong_Kong_Click(sender As Object, e As EventArgs) Handles Hong_Kong.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Hong_Kong.zip"), FolderBrowserDialog1.SelectedPath + "Hong_Kong.zip")
    End Sub

    Private Sub Hungary_Click(sender As Object, e As EventArgs) Handles Hungary.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Hungary.zip"), FolderBrowserDialog1.SelectedPath + "Hungary.zip")
    End Sub

    Private Sub Iceland_Click(sender As Object, e As EventArgs) Handles Iceland.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Iceland.zip"), FolderBrowserDialog1.SelectedPath + "Iceland.zip")
    End Sub

    Private Sub India_Click(sender As Object, e As EventArgs) Handles India.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/India.zip"), FolderBrowserDialog1.SelectedPath + "India.zip")
    End Sub

    Private Sub Indonesia_Click(sender As Object, e As EventArgs) Handles Indonesia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Indonesia.zip"), FolderBrowserDialog1.SelectedPath + "Indonesia.zip")
    End Sub

    Private Sub iran_Click(sender As Object, e As EventArgs) Handles iran.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/iran.zip"), FolderBrowserDialog1.SelectedPath + "iran.zip")
    End Sub

    Private Sub Ireland_Click(sender As Object, e As EventArgs) Handles Ireland.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Ireland.zip"), FolderBrowserDialog1.SelectedPath + "Ireland.zip")
    End Sub

    Private Sub Israel_Click(sender As Object, e As EventArgs) Handles Israel.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Israel.zip"), FolderBrowserDialog1.SelectedPath + "Israel.zip")
    End Sub

    Private Sub Italy_Click(sender As Object, e As EventArgs) Handles Italy.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Italy.zip"), FolderBrowserDialog1.SelectedPath + "Italy.zip")
    End Sub

    Private Sub Jamaica_Click(sender As Object, e As EventArgs) Handles Jamaica.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Jamaica.zip"), FolderBrowserDialog1.SelectedPath + "Jamaica.zip")
    End Sub

    Private Sub Japan_A_Click(sender As Object, e As EventArgs) Handles Japan_A.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Japan_A.zip"), FolderBrowserDialog1.SelectedPath + "Japan_A.zip")
    End Sub

    Private Sub Jordan_Click(sender As Object, e As EventArgs) Handles Jordan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Jordan.zip"), FolderBrowserDialog1.SelectedPath + "Jordan.zip")
    End Sub

    Private Sub Kazakhstan_Click(sender As Object, e As EventArgs) Handles Kazakhstan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Kazakhstan.zip"), FolderBrowserDialog1.SelectedPath + "Kazakhstan.zip")
    End Sub

    Private Sub Kuwait_Click(sender As Object, e As EventArgs) Handles Kuwait.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Kuwait.zip"), FolderBrowserDialog1.SelectedPath + "Kuwait.zip")
    End Sub

    Private Sub Lebanon_Text_Click(sender As Object, e As EventArgs) Handles Lebanon_Text.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Lebanon_Text.zip"), FolderBrowserDialog1.SelectedPath + "Lebanon_Text.zip")
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Libya_Click(sender As Object, e As EventArgs) Handles Libya.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Libya.zip"), FolderBrowserDialog1.SelectedPath + "Libya.zip")
    End Sub

    Private Sub Luxemburj_Click(sender As Object, e As EventArgs) Handles Luxemburj.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Luxemburj.zip"), FolderBrowserDialog1.SelectedPath + "Luxemburj.zip")
    End Sub

    Private Sub Macao_Click(sender As Object, e As EventArgs) Handles Macao.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Macao.zip"), FolderBrowserDialog1.SelectedPath + "Macao.zip")
    End Sub

    Private Sub Malaysia_Click(sender As Object, e As EventArgs) Handles Malaysia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Malaysia.zip"), FolderBrowserDialog1.SelectedPath + "Malaysia.zip")
    End Sub

    Private Sub Maldives_Click(sender As Object, e As EventArgs) Handles Maldives.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Maldives.zip"), FolderBrowserDialog1.SelectedPath + "Maldives.zip")
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Malta.zip"), FolderBrowserDialog1.SelectedPath + "Malta.zip")
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Mauritus.zip"), FolderBrowserDialog1.SelectedPath + "Mauritus.zip")
    End Sub

    Private Sub Mexico_Click(sender As Object, e As EventArgs) Handles Mexico.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Mexico.zip"), FolderBrowserDialog1.SelectedPath + "Mexico.zip")
    End Sub

    Private Sub Moldova_Click(sender As Object, e As EventArgs) Handles Moldova.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Moldova.zip"), FolderBrowserDialog1.SelectedPath + "Moldova.zip")
    End Sub

    Private Sub Morocco_Click(sender As Object, e As EventArgs) Handles Morocco.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Morocco.zip"), FolderBrowserDialog1.SelectedPath + "Morocco.zip")
    End Sub

    Private Sub Namibia_Click(sender As Object, e As EventArgs) Handles Namibia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Namibia.zip"), FolderBrowserDialog1.SelectedPath + "Namibia.zip")
    End Sub

    Private Sub Netherland_Click(sender As Object, e As EventArgs) Handles Netherland.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Netherland.zip"), FolderBrowserDialog1.SelectedPath + "Netherland.zip")
    End Sub

    Private Sub Nigeria_Click(sender As Object, e As EventArgs) Handles Nigeria.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Nigeria.zip"), FolderBrowserDialog1.SelectedPath + "Nigeria.zip")
    End Sub

    Private Sub Norway_Click(sender As Object, e As EventArgs) Handles Norway.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Norway.zip"), FolderBrowserDialog1.SelectedPath + "Norway.zip")
    End Sub

    Private Sub Oman_Click(sender As Object, e As EventArgs) Handles Oman.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Oman.zip"), FolderBrowserDialog1.SelectedPath + "Oman.zip")
    End Sub

    Private Sub Palestine_Click(sender As Object, e As EventArgs) Handles Palestine.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Palestine.zip"), FolderBrowserDialog1.SelectedPath + "Palestine.zip")
    End Sub

    Private Sub Panama_Click(sender As Object, e As EventArgs) Handles Panama.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Panama.zip"), FolderBrowserDialog1.SelectedPath + "Panama.zip")
    End Sub

    Private Sub Peru_Complete_Click(sender As Object, e As EventArgs) Handles Peru_Complete.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Peru_Complete.zip"), FolderBrowserDialog1.SelectedPath + "Peru_Complete.zip")
    End Sub

    Private Sub Philpine_Click(sender As Object, e As EventArgs) Handles Philpine.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Philpine.zip"), FolderBrowserDialog1.SelectedPath + "Philpine.zip")
    End Sub

    Private Sub Poland_Click(sender As Object, e As EventArgs) Handles Poland.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Poland.zip"), FolderBrowserDialog1.SelectedPath + "Poland.zip")
    End Sub

    Private Sub Portugal_Click(sender As Object, e As EventArgs) Handles Portugal.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Portugal.zip"), FolderBrowserDialog1.SelectedPath + "Portugal.zip")
    End Sub

    Private Sub Puerto_Rico_Click(sender As Object, e As EventArgs) Handles Puerto_Rico.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Puerto_Rico.zip"), FolderBrowserDialog1.SelectedPath + "Puerto_Rico.zip")
    End Sub

    Private Sub Russia_Click(sender As Object, e As EventArgs) Handles Russia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Russia.zip"), FolderBrowserDialog1.SelectedPath + "Russia.zip")
    End Sub

    Private Sub serbia_Click(sender As Object, e As EventArgs) Handles serbia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/serbia.zip"), FolderBrowserDialog1.SelectedPath + "serbia.zip")
    End Sub

    Private Sub Singapore1_Click(sender As Object, e As EventArgs) Handles Singapore1.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Singapore1.zip"), FolderBrowserDialog1.SelectedPath + "Singapore1.zip")
    End Sub

    Private Sub Slovenia_Click(sender As Object, e As EventArgs) Handles Slovenia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Slovenia.zip"), FolderBrowserDialog1.SelectedPath + "Slovenia.zip")
    End Sub

    Private Sub South_Africa_Click(sender As Object, e As EventArgs) Handles South_Africa.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/South_Africa.zip"), FolderBrowserDialog1.SelectedPath + "South_Africa.zip")
    End Sub

    Private Sub South_Korea_Click(sender As Object, e As EventArgs) Handles South_Korea.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/South_Korea.zip"), FolderBrowserDialog1.SelectedPath + "South_Korea.zip")
    End Sub

    Private Sub sudan_Click(sender As Object, e As EventArgs) Handles sudan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/sudan.zip"), FolderBrowserDialog1.SelectedPath + "sudan.zip")
    End Sub

    Private Sub Switzerland_Click(sender As Object, e As EventArgs) Handles Switzerland.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Switzerland.zip"), FolderBrowserDialog1.SelectedPath + "Switzerland.zip")
    End Sub

    Private Sub Syria_Click(sender As Object, e As EventArgs) Handles Syria.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Syria.zip"), FolderBrowserDialog1.SelectedPath + "Syria.zip")
    End Sub

    Private Sub Taiwan_Click(sender As Object, e As EventArgs) Handles Taiwan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Taiwan.zip"), FolderBrowserDialog1.SelectedPath + "Taiwan.zip")
    End Sub

    Private Sub Tunisia_Click(sender As Object, e As EventArgs) Handles Tunisia.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Tunisia.zip"), FolderBrowserDialog1.SelectedPath + "Tunisia.zip")
    End Sub

    Private Sub Turkey_Click(sender As Object, e As EventArgs) Handles Turkey.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Turkey.zip"), FolderBrowserDialog1.SelectedPath + "Turkey.zip")
    End Sub

    Private Sub Turkmenistan_Click(sender As Object, e As EventArgs) Handles Turkmenistan.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Turkmenistan.zip"), FolderBrowserDialog1.SelectedPath + "Turkmenistan.zip")
    End Sub

    Private Sub UAE_Click(sender As Object, e As EventArgs) Handles UAE.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/UAE.zip"), FolderBrowserDialog1.SelectedPath + "UAE.zip")
    End Sub

    Private Sub uk_Click(sender As Object, e As EventArgs) Handles uk.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/uk.zip"), FolderBrowserDialog1.SelectedPath + "uk.zip")
    End Sub

    Private Sub Uruguay_Click(sender As Object, e As EventArgs) Handles Uruguay.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Uruguay.zip"), FolderBrowserDialog1.SelectedPath + "Uruguay.zip")
    End Sub

    Private Sub USA_Click(sender As Object, e As EventArgs) Handles USA.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/USA.zip"), FolderBrowserDialog1.SelectedPath + "USA.zip")
    End Sub

    Private Sub Yemen_Click(sender As Object, e As EventArgs) Handles Yemen.Click
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadDataAsync(New Uri("ftp://viewer@hellostore.tk/Yemen.zip"), FolderBrowserDialog1.SelectedPath + "Yemen.zip")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub SelectDownloadLocaitonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectDownloadLocaitonToolStripMenuItem.Click
        FolderBrowserDialog1.ShowDialog()
        My.Settings.saveloc = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        My.Settings.saveloc = FolderBrowserDialog1.SelectedPath
    End Sub
End Class
