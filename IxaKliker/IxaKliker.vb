Imports System.IO

Public Class IxaKliker

    Private zuzenketak As Integer 'guztira egin diren zuzenketak
    Private lvl As Integer ' erabiltzaileak ea dirulaguntza jaso duen edo ez
    Private items(6) As Integer ' erabiltzaileak lortu dituen zuzenketak egiteko objetuak, segunduro egiten diren zuzenketetan zuzeneko eragina dute.

    Public Property ZuzenketakGuztira() As Integer
        Get
            Return zuzenketak
        End Get
        Set(ByVal value As Integer)
            zuzenketak = value
        End Set
    End Property

    Public Property Nibela() As Integer
        Get
            Return lvl
        End Get
        Set(ByVal value As Integer)
            lvl = value
        End Set
    End Property

    Public Property Objetuak() As Integer()
        Get
            Return items
        End Get
        Set(ByVal value As Integer())
            items = value
        End Set
    End Property


    Public Sub New()

        'Jokoaren datuak .iks fitxategietan gordeko dira (Ixa Kliker Save), noski, fitxategi hau azken finean textu fitxategi arrunt bat da, beste izen batekin.

        If My.Computer.FileSystem.FileExists("data.iks") And My.Computer.FileSystem.FileExists("items.iks") Then ' data.iks fitxategiak existitzen badu, dagoeneko partida bat gordeta dagoela nahi du esan

            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("data.iks")
            zuzenketak = fileReader.ReadLine()
            lvl = fileReader.ReadLine()
            fileReader.Close()

            fileReader = My.Computer.FileSystem.OpenTextFileReader("items.iks")
            items(0) = fileReader.ReadLine()
            items(1) = fileReader.ReadLine()
            items(2) = fileReader.ReadLine()
            items(3) = fileReader.ReadLine()
            items(4) = fileReader.ReadLine()
            items(5) = fileReader.ReadLine()
            fileReader.Close()


        Else ' data.iks eta items.iks fitxategiak ez dira existitzen, beraz aplikazioa irekitzen den lehenengo aldia da. Fitxategi hauek sortuko dira.

            Dim idazteko As String = ""

            Dim fs As FileStream = File.Create("data.iks")

            fs.Close()

            idazteko = "0" + vbCrLf + "1"
            My.Computer.FileSystem.WriteAllText("data.iks", idazteko, True)
            zuzenketak = 0
            lvl = 1

            fs = File.Create("items.iks")
            fs.Close()

            idazteko = "0" + vbCrLf + "0" + vbCrLf + "0" + vbCrLf + "0" + vbCrLf + "0" + vbCrLf + "0"
            My.Computer.FileSystem.WriteAllText("items.iks", idazteko, True)
            items = {0, 0, 0, 0, 0, 0}


        End If
    End Sub


    Public Function kalkulatuZps() As Integer ' Zuzenketak segunduro

        Dim arkatzak As Integer = items(0) * 1
        Dim tippexa As Integer = items(1) * 6
        Dim boligrafoGorriak As Integer = items(2) * 20
        Dim idaztekoMakina As Integer = items(3) * 55
        Dim filologoEuskalduna As Integer = items(4) * 160
        Dim xuxen As Integer = items(5) * 1000

        Dim zps As Integer = (arkatzak + tippexa + boligrafoGorriak + idaztekoMakina + filologoEuskalduna + xuxen) * lvl

        Return zps

    End Function


    Public Function kostuaKalkulatu(ByVal item As Integer) As Integer

        Dim zenbat As Integer = items(item)

        Dim kostua As Integer = (10 * 4 ^ (item * 1.5)) * 2 ^ items(item)

        Return kostua

    End Function

    Public Sub nibelaIgo()

        lvl += 1
        reset()

    End Sub

    Public Sub Gorde()

        Dim idazteko As String = ""
        idazteko = zuzenketak.ToString + vbCrLf + lvl.ToString
        My.Computer.FileSystem.WriteAllText("data.iks", idazteko, False)



        idazteko = ""
        For Each z As Integer In items

            idazteko = idazteko + z.ToString + vbCrLf


        Next
        My.Computer.FileSystem.WriteAllText("items.iks", idazteko, False)





    End Sub


    Public Sub reset()

        items = {0, 0, 0, 0, 0, 0}
        zuzenketak = 0


    End Sub

    Public Sub fullreset()

        items = {0, 0, 0, 0, 0, 0}
        zuzenketak = 0
        lvl = 1


    End Sub


End Class
