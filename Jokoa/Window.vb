Imports IxaKliker


Public Class Window

    Dim Kliker As New IxaKliker.IxaKliker()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim eragiketa As Integer = (Convert.ToInt32(ZPS.Text) / 100 * 50) * Kliker.Nibela


        If eragiketa = 0 Then
            Kliker.ZuzenketakGuztira = Kliker.ZuzenketakGuztira + 1
        Else
            Kliker.ZuzenketakGuztira = Kliker.ZuzenketakGuztira + eragiketa
        End If

        ZuzenkGuztira.Text = Kliker.ZuzenketakGuztira
    End Sub

    Private Sub Window_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If MsgBox("Jokoa itxi nahi duzu?", vbYesNo) = vbNo Then

            e.Cancel = True
        End If

        Kliker.Gorde()

    End Sub


    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PlayLoopingBackgroundSoundFile()
        ZuzenkGuztira.Text = Kliker.ZuzenketakGuztira
        ZPS.Text = Kliker.kalkulatuZps()

        If Kliker.Nibela = 1 Then
            textua.Text = "Bazan bein Manes hizeneko mutil bat. gutxi gohora behera ohogei urte zituen. Leioa hirekita zuen bitartean kartak idazten zizkion bere nobiari bidaltzeko hasmoarekin itsasoko brisak hilea antiorrazten zion bitartean. Batzutan leiotik bera beitzezun eta hurruti itxasoa beitzezun."
        End If

        If Kliker.Nibela = 2 Then
            nibela.Text = ""
            textua.Text = "Bazen behin Manex hizeneko mutil bat. Gutxi gora behera ogei urte zituen. Leihoa irekita zuen bitartean kartak idazten zizkion bere neska-lagunari bidaltzeko asmoarekin itsasoko aizeak ilea desorrazten zion bitartean. Batzutan leihotik behera beitzen zun eta urruti itxasoa beitzen zun."
            If Kliker.Objetuak(5) > 0 Then
                textua.Text = "Bazen behin Manex izeneko mutiko bat. Hogei urte zituen gutxi gora behera eta leihoa irekita zuen bitartean gutunak idaztea oso laket zuen, bere neskalagunari bidaltzeko asmotan ahal bezain beste lantzen zituelarik haiek. Noizean behin, begirada kaieratik kendu eta urrunean ikus zitzakeen olatuak behatzen zituen, itsas-brisak bere ilea leunki laztantzen zuelarik."
            End If
        End If


        'bakoitzatik zenbat elementu dauden idazten da
        eguneratuKopuruak()


        'hasierako konprobazioa ea zerbait eros dezakezun

        arkatzPrezioa.Text = Kliker.kostuaKalkulatu(0)
        If Convert.ToInt32(arkatzPrezioa.Text) >= Convert.ToInt32(ZuzenkGuztira.Text) Then
            arkatza.Enabled = False
        End If

        tippexPrezioa.Text = Kliker.kostuaKalkulatu(1)
        If Convert.ToInt32(tippexPrezioa.Text) >= Convert.ToInt32(ZuzenkGuztira.Text) Then
            tippex.Enabled = False
        End If

        boligrafoPrezioa.Text = Kliker.kostuaKalkulatu(2)
        If Convert.ToInt32(boligrafoPrezioa.Text) >= Convert.ToInt32(ZuzenkGuztira.Text) Then
            boligrafo.Enabled = False
        End If

        idazPrezioa.Text = Kliker.kostuaKalkulatu(3)
        If Convert.ToInt32(boligrafoPrezioa.Text) >= Convert.ToInt32(ZuzenkGuztira.Text) Then
            idazmakina.Enabled = False
        End If

        filoPrezioa.Text = Kliker.kostuaKalkulatu(4)
        If Convert.ToInt32(filoPrezioa.Text) >= Convert.ToInt32(ZuzenkGuztira.Text) Then
            filologoa.Enabled = False
        End If

        xuxenPrezioa.Text = Kliker.kostuaKalkulatu(5)
        If Convert.ToInt32(xuxenPrezioa.Text) >= Convert.ToInt32(ZuzenkGuztira.Text) Then
            xuxen.Enabled = False
        End If


        'Dirulaguntza lortzeko prest dagoen begiratzen du

        If Kliker.Nibela = 1 And Convert.ToInt32(ZuzenkGuztira.Text) > 9999 Then
            lvlUp.Enabled = True
        End If


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Eguneraketa.Tick
        ZuzenkGuztira.Text = Kliker.ZuzenketakGuztira
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Segunduro.Tick

        Kliker.ZuzenketakGuztira += Kliker.kalkulatuZps()

        'hemen arkatzaz gain, tippexa, boligrafo gorria eta bestelako botoien konprobazioak gehitu, hau da, puntu kopuru minimoa gaindituz gero bakarrik izango zara hauek erosteko gai.

        If Not arkatza.Enabled Then
            If Convert.ToInt32(ZuzenkGuztira.Text) >= Convert.ToInt32(arkatzPrezioa.Text) Then
                arkatza.Enabled = True
            Else
                arkatza.Enabled = False
            End If
        End If

        If Not tippex.Enabled Then
            If Convert.ToInt32(ZuzenkGuztira.Text) >= Convert.ToInt32(tippexPrezioa.Text) Then
                tippex.Enabled = True
            Else
                tippex.Enabled = False
            End If
        End If

        If Not boligrafo.Enabled Then
            If Convert.ToInt32(ZuzenkGuztira.Text) >= Convert.ToInt32(boligrafoPrezioa.Text) Then
                boligrafo.Enabled = True
            Else
                boligrafo.Enabled = False
            End If
        End If

        If Not idazmakina.Enabled Then
            If Convert.ToInt32(ZuzenkGuztira.Text) >= Convert.ToInt32(idazPrezioa.Text) Then
                idazmakina.Enabled = True
            Else
                idazmakina.Enabled = False
            End If
        End If

        If Not filologoa.Enabled Then
            If Convert.ToInt32(ZuzenkGuztira.Text) >= Convert.ToInt32(filoPrezioa.Text) Then
                filologoa.Enabled = True
            Else
                filologoa.Enabled = False
            End If
        End If

        If Not xuxen.Enabled Then
            If Convert.ToInt32(ZuzenkGuztira.Text) >= Convert.ToInt32(xuxenPrezioa.Text) Then
                xuxen.Enabled = True
            Else
                xuxen.Enabled = False
            End If
        End If


        If Kliker.Nibela = 1 And Convert.ToInt32(ZuzenkGuztira.Text) > 9999 Then
            lvlUp.Enabled = True
        End If

    End Sub

    Private Sub zuzenketaksegunduko_Tick(sender As Object, e As EventArgs) Handles zuzenketaksegunduko.Tick
        ZPS.Text = Kliker.kalkulatuZps()
    End Sub


    'botoietan klik egiteak objetuak gehitzeko

    Private Sub arkatza_Click(sender As Object, e As EventArgs) Handles arkatza.Click
        Kliker.Objetuak(0) += 1
        Dim prezioberria As Integer = Kliker.kostuaKalkulatu(0)
        If prezioberria >= ZuzenkGuztira.Text Then
            arkatza.Enabled = False
        End If
        arkatzPrezioa.Text = prezioberria
        arkatzKop.Text += 1
    End Sub

    Private Sub tippex_Click(sender As Object, e As EventArgs) Handles tippex.Click
        Kliker.Objetuak(1) += 1
        Dim prezioberria As Integer = Kliker.kostuaKalkulatu(1)
        If prezioberria >= ZuzenkGuztira.Text Then
            tippex.Enabled = False
        End If
        tippexPrezioa.Text = prezioberria
        tippexKop.Text += 1
    End Sub

    Private Sub boligrafo_Click(sender As Object, e As EventArgs) Handles boligrafo.Click

        Kliker.Objetuak(2) += 1
        Dim prezioberria As Integer = Kliker.kostuaKalkulatu(2)
        If prezioberria >= ZuzenkGuztira.Text Then
            boligrafo.Enabled = False
        End If
        boligrafoPrezioa.Text = prezioberria
        boligrafoKop.Text += 1

    End Sub

    Private Sub idazmakina_Click(sender As Object, e As EventArgs) Handles idazmakina.Click
        Kliker.Objetuak(3) += 1
        Dim prezioberria As Integer = Kliker.kostuaKalkulatu(3)
        If prezioberria >= ZuzenkGuztira.Text Then
            idazmakina.Enabled = False
        End If
        idazPrezioa.Text = prezioberria
        idazKop.Text += 1
    End Sub

    Private Sub filologoa_Click(sender As Object, e As EventArgs) Handles filologoa.Click
        Kliker.Objetuak(4) += 1
        Dim prezioberria As Integer = Kliker.kostuaKalkulatu(4)
        If prezioberria >= ZuzenkGuztira.Text Then
            filologoa.Enabled = False
        End If
        filoPrezioa.Text = prezioberria
        filoKop.Text += 1
    End Sub

    Private Sub xuxen_Click(sender As Object, e As EventArgs) Handles xuxen.Click
        Kliker.Objetuak(5) += 1
        Dim prezioberria As Integer = Kliker.kostuaKalkulatu(5)
        If prezioberria >= ZuzenkGuztira.Text Then
            xuxen.Enabled = False
        End If
        xuxenPrezioa.Text = prezioberria
        xuxenKop.Text += 1
        textua.Text = "Bazen behin Manex izeneko mutiko bat. Hogei urte zituen gutxi gora behera eta leihoa irekita zuen bitartean gutunak idaztea oso laket zuen, bere neskalagunari bidaltzeko asmotan ahal bezain beste lantzen zituelarik haiek. Noizean behin, begirada kaieratik kendu eta urrunean ikus zitzakeen olatuak behatzen zituen, itsas-brisak bere ilea leunki laztantzen zuelarik."
    End Sub



    Private Sub lvlUp_Click(sender As Object, e As EventArgs) Handles lvlUp.Click
        Kliker.nibelaIgo()
        hasieratuKopuruak()
        kostuakEguneratu()
        lvlUp.Enabled = False
        botoiakHasieratu()
        nibela.Text = ""
        textua.Text = "Bazen behin Manex hizeneko mutil bat. Gutxi gora behera ogei urte zituen. Leihoa irekita zuen bitartean kartak idazten zizkion bere neska-lagunari bidaltzeko asmoarekin itsasoko aizeak ilea desorrazten zion bitartean. Batzutan leihotik behera beitzen zun eta urruti itxasoa beitzen zun."


    End Sub



    '====================================== EGUNERAKETAK ===================================



    Private Sub kostuakEguneratu()
        arkatzPrezioa.Text = Kliker.kostuaKalkulatu(0)
        tippexPrezioa.Text = Kliker.kostuaKalkulatu(1)
        boligrafoPrezioa.Text = Kliker.kostuaKalkulatu(2)
        idazPrezioa.Text = Kliker.kostuaKalkulatu(3)
        filoPrezioa.Text = Kliker.kostuaKalkulatu(4)
        xuxenPrezioa.Text = Kliker.kostuaKalkulatu(5)
    End Sub

    Private Sub eguneratuKopuruak()
        arkatzKop.Text = Kliker.Objetuak(0)
        tippexKop.Text = Kliker.Objetuak(1)
        boligrafoKop.Text = Kliker.Objetuak(2)
        idazKop.Text = Kliker.Objetuak(3)
        filoKop.Text = Kliker.Objetuak(4)
        xuxenKop.Text = Kliker.Objetuak(5)
    End Sub

    Private Sub hasieratuKopuruak()
        arkatzKop.Text = 0
        tippexKop.Text = 0
        boligrafoKop.Text = 0
        idazKop.Text = 0
        filoKop.Text = 0
        xuxenKop.Text = 0
    End Sub

    Private Sub botoiakHasieratu()
        arkatza.Enabled = False
        tippex.Enabled = False
        boligrafo.Enabled = False
        idazmakina.Enabled = False
        filologoa.Enabled = False
        xuxen.Enabled = False

    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        nibela.Text = "Dirulaguntza lortzeko influentzia minimo bat behar da!"
        lvlUp.Enabled = False
        Kliker.ZuzenketakGuztira = 0
        Kliker.fullreset()
        hasieratuKopuruak()
        kostuakEguneratu()
        botoiakHasieratu()
    End Sub

    Private Sub twitter_Click(sender As Object, e As EventArgs) Handles twitter.Click
        System.Diagnostics.Process.Start("https://twitter.com/intent/tweet?button_hashtag=IxaKliker&text=Dagoeneko%20" + Convert.ToString(Kliker.ZuzenketakGuztira) + "%20zuzenketa%20lortu%20ditut%20Ixa%20Kliker%20jokoan%3B%20zenbat%20lor%20ditzakezu%20zuk%3F")
    End Sub



    '====================================== MUSIKA FUNTZIOAK ===================================

    Private Sub musikaGelditu_Click(sender As Object, e As EventArgs) Handles musikaGelditu.Click
        If musikaGelditu.Text = "Musika gelditu" Then
            StopBackgroundSound()
            musikaGelditu.Text = "Musika jarri"
        ElseIf musikaGelditu.Text = "Musika jarri" Then
            PlayLoopingBackgroundSoundFile()
            musikaGelditu.Text = "Musika gelditu"
        End If


    End Sub


    Sub PlayLoopingBackgroundSoundFile()
        My.Computer.Audio.Play("OST.wav",
            AudioPlayMode.BackgroundLoop)
    End Sub

    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub
End Class
