<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ZuzenkGuztira = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.arkatza = New System.Windows.Forms.Button()
        Me.Eguneraketa = New System.Windows.Forms.Timer(Me.components)
        Me.Segunduro = New System.Windows.Forms.Timer(Me.components)
        Me.ZPS = New System.Windows.Forms.Label()
        Me.zuzenketaksegunduko = New System.Windows.Forms.Timer(Me.components)
        Me.tippex = New System.Windows.Forms.Button()
        Me.boligrafo = New System.Windows.Forms.Button()
        Me.prezioak = New System.Windows.Forms.Label()
        Me.arkatzPrezioa = New System.Windows.Forms.Label()
        Me.tippexPrezioa = New System.Windows.Forms.Label()
        Me.boligrafoPrezioa = New System.Windows.Forms.Label()
        Me.text1 = New System.Windows.Forms.Label()
        Me.koplabel = New System.Windows.Forms.Label()
        Me.arkatzKop = New System.Windows.Forms.Label()
        Me.tippexKop = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boligrafoKop = New System.Windows.Forms.Label()
        Me.lvlUp = New System.Windows.Forms.Button()
        Me.nibela = New System.Windows.Forms.Label()
        Me.idazmakina = New System.Windows.Forms.Button()
        Me.idazKop = New System.Windows.Forms.Label()
        Me.idazPrezioa = New System.Windows.Forms.Label()
        Me.filologoa = New System.Windows.Forms.Button()
        Me.filoKop = New System.Windows.Forms.Label()
        Me.filoPrezioa = New System.Windows.Forms.Label()
        Me.xuxen = New System.Windows.Forms.Button()
        Me.xuxenKop = New System.Windows.Forms.Label()
        Me.xuxenPrezioa = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.twitter = New System.Windows.Forms.Button()
        Me.textua = New System.Windows.Forms.TextBox()
        Me.musikaGelditu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ZuzenkGuztira
        '
        Me.ZuzenkGuztira.AutoSize = True
        Me.ZuzenkGuztira.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZuzenkGuztira.Location = New System.Drawing.Point(64, 286)
        Me.ZuzenkGuztira.Name = "ZuzenkGuztira"
        Me.ZuzenkGuztira.Size = New System.Drawing.Size(43, 51)
        Me.ZuzenkGuztira.TabIndex = 0
        Me.ZuzenkGuztira.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 169)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ZUZENDU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'arkatza
        '
        Me.arkatza.Location = New System.Drawing.Point(370, 48)
        Me.arkatza.Name = "arkatza"
        Me.arkatza.Size = New System.Drawing.Size(75, 27)
        Me.arkatza.TabIndex = 2
        Me.arkatza.Text = "Arkatza"
        Me.arkatza.UseVisualStyleBackColor = True
        '
        'Eguneraketa
        '
        Me.Eguneraketa.Enabled = True
        '
        'Segunduro
        '
        Me.Segunduro.Enabled = True
        Me.Segunduro.Interval = 1000
        '
        'ZPS
        '
        Me.ZPS.AutoSize = True
        Me.ZPS.Location = New System.Drawing.Point(117, 235)
        Me.ZPS.Name = "ZPS"
        Me.ZPS.Size = New System.Drawing.Size(23, 13)
        Me.ZPS.TabIndex = 4
        Me.ZPS.Text = "null"
        '
        'zuzenketaksegunduko
        '
        Me.zuzenketaksegunduko.Enabled = True
        '
        'tippex
        '
        Me.tippex.Location = New System.Drawing.Point(370, 81)
        Me.tippex.Name = "tippex"
        Me.tippex.Size = New System.Drawing.Size(75, 29)
        Me.tippex.TabIndex = 5
        Me.tippex.Text = "Tippex"
        Me.tippex.UseVisualStyleBackColor = True
        '
        'boligrafo
        '
        Me.boligrafo.Location = New System.Drawing.Point(370, 116)
        Me.boligrafo.Name = "boligrafo"
        Me.boligrafo.Size = New System.Drawing.Size(75, 45)
        Me.boligrafo.TabIndex = 6
        Me.boligrafo.Text = "Boligrafo gorria"
        Me.boligrafo.UseVisualStyleBackColor = True
        '
        'prezioak
        '
        Me.prezioak.AutoSize = True
        Me.prezioak.Location = New System.Drawing.Point(450, 20)
        Me.prezioak.Name = "prezioak"
        Me.prezioak.Size = New System.Drawing.Size(119, 13)
        Me.prezioak.TabIndex = 7
        Me.prezioak.Text = "Beharrezko zuzenketak"
        '
        'arkatzPrezioa
        '
        Me.arkatzPrezioa.AutoSize = True
        Me.arkatzPrezioa.Location = New System.Drawing.Point(452, 55)
        Me.arkatzPrezioa.Name = "arkatzPrezioa"
        Me.arkatzPrezioa.Size = New System.Drawing.Size(10, 13)
        Me.arkatzPrezioa.TabIndex = 8
        Me.arkatzPrezioa.Text = "-"
        '
        'tippexPrezioa
        '
        Me.tippexPrezioa.AutoSize = True
        Me.tippexPrezioa.Location = New System.Drawing.Point(452, 89)
        Me.tippexPrezioa.Name = "tippexPrezioa"
        Me.tippexPrezioa.Size = New System.Drawing.Size(10, 13)
        Me.tippexPrezioa.TabIndex = 9
        Me.tippexPrezioa.Text = "-"
        '
        'boligrafoPrezioa
        '
        Me.boligrafoPrezioa.AutoSize = True
        Me.boligrafoPrezioa.Location = New System.Drawing.Point(452, 132)
        Me.boligrafoPrezioa.Name = "boligrafoPrezioa"
        Me.boligrafoPrezioa.Size = New System.Drawing.Size(10, 13)
        Me.boligrafoPrezioa.TabIndex = 10
        Me.boligrafoPrezioa.Text = "-"
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(70, 210)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(120, 13)
        Me.text1.TabIndex = 11
        Me.text1.Text = "Zuzenketak segunduko"
        '
        'koplabel
        '
        Me.koplabel.AutoSize = True
        Me.koplabel.Location = New System.Drawing.Point(287, 20)
        Me.koplabel.Name = "koplabel"
        Me.koplabel.Size = New System.Drawing.Size(47, 13)
        Me.koplabel.TabIndex = 12
        Me.koplabel.Text = "Kopurua"
        '
        'arkatzKop
        '
        Me.arkatzKop.AutoSize = True
        Me.arkatzKop.Location = New System.Drawing.Point(290, 55)
        Me.arkatzKop.Name = "arkatzKop"
        Me.arkatzKop.Size = New System.Drawing.Size(10, 13)
        Me.arkatzKop.TabIndex = 13
        Me.arkatzKop.Text = "-"
        '
        'tippexKop
        '
        Me.tippexKop.AutoSize = True
        Me.tippexKop.Location = New System.Drawing.Point(290, 89)
        Me.tippexKop.Name = "tippexKop"
        Me.tippexKop.Size = New System.Drawing.Size(10, 13)
        Me.tippexKop.TabIndex = 14
        Me.tippexKop.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Zuzenketak guztira"
        '
        'boligrafoKop
        '
        Me.boligrafoKop.AutoSize = True
        Me.boligrafoKop.Location = New System.Drawing.Point(290, 132)
        Me.boligrafoKop.Name = "boligrafoKop"
        Me.boligrafoKop.Size = New System.Drawing.Size(10, 13)
        Me.boligrafoKop.TabIndex = 16
        Me.boligrafoKop.Text = "-"
        '
        'lvlUp
        '
        Me.lvlUp.Enabled = False
        Me.lvlUp.Location = New System.Drawing.Point(326, 325)
        Me.lvlUp.Name = "lvlUp"
        Me.lvlUp.Size = New System.Drawing.Size(243, 23)
        Me.lvlUp.TabIndex = 17
        Me.lvlUp.Text = "Eusko Jaurlaritzako dirulaguntza jaso"
        Me.lvlUp.UseVisualStyleBackColor = True
        '
        'nibela
        '
        Me.nibela.AutoSize = True
        Me.nibela.Location = New System.Drawing.Point(323, 309)
        Me.nibela.Name = "nibela"
        Me.nibela.Size = New System.Drawing.Size(257, 13)
        Me.nibela.TabIndex = 18
        Me.nibela.Text = "Dirulaguntza lortzeko influentzia minimo bat behar da!"
        '
        'idazmakina
        '
        Me.idazmakina.Location = New System.Drawing.Point(370, 168)
        Me.idazmakina.Name = "idazmakina"
        Me.idazmakina.Size = New System.Drawing.Size(75, 23)
        Me.idazmakina.TabIndex = 19
        Me.idazmakina.Text = "Idaz makina"
        Me.idazmakina.UseVisualStyleBackColor = True
        '
        'idazKop
        '
        Me.idazKop.AutoSize = True
        Me.idazKop.Location = New System.Drawing.Point(290, 168)
        Me.idazKop.Name = "idazKop"
        Me.idazKop.Size = New System.Drawing.Size(10, 13)
        Me.idazKop.TabIndex = 20
        Me.idazKop.Text = "-"
        '
        'idazPrezioa
        '
        Me.idazPrezioa.AutoSize = True
        Me.idazPrezioa.Location = New System.Drawing.Point(451, 173)
        Me.idazPrezioa.Name = "idazPrezioa"
        Me.idazPrezioa.Size = New System.Drawing.Size(10, 13)
        Me.idazPrezioa.TabIndex = 21
        Me.idazPrezioa.Text = "-"
        '
        'filologoa
        '
        Me.filologoa.Location = New System.Drawing.Point(370, 198)
        Me.filologoa.Name = "filologoa"
        Me.filologoa.Size = New System.Drawing.Size(75, 36)
        Me.filologoa.TabIndex = 22
        Me.filologoa.Text = "Filologo Euskalduna"
        Me.filologoa.UseVisualStyleBackColor = True
        '
        'filoKop
        '
        Me.filoKop.AutoSize = True
        Me.filoKop.Location = New System.Drawing.Point(290, 210)
        Me.filoKop.Name = "filoKop"
        Me.filoKop.Size = New System.Drawing.Size(10, 13)
        Me.filoKop.TabIndex = 23
        Me.filoKop.Text = "-"
        '
        'filoPrezioa
        '
        Me.filoPrezioa.AutoSize = True
        Me.filoPrezioa.Location = New System.Drawing.Point(452, 210)
        Me.filoPrezioa.Name = "filoPrezioa"
        Me.filoPrezioa.Size = New System.Drawing.Size(10, 13)
        Me.filoPrezioa.TabIndex = 24
        Me.filoPrezioa.Text = "-"
        '
        'xuxen
        '
        Me.xuxen.Location = New System.Drawing.Point(370, 246)
        Me.xuxen.Name = "xuxen"
        Me.xuxen.Size = New System.Drawing.Size(75, 23)
        Me.xuxen.TabIndex = 25
        Me.xuxen.Text = "Xuxen 6.0"
        Me.xuxen.UseVisualStyleBackColor = True
        '
        'xuxenKop
        '
        Me.xuxenKop.AutoSize = True
        Me.xuxenKop.Location = New System.Drawing.Point(290, 246)
        Me.xuxenKop.Name = "xuxenKop"
        Me.xuxenKop.Size = New System.Drawing.Size(10, 13)
        Me.xuxenKop.TabIndex = 26
        Me.xuxenKop.Text = "-"
        '
        'xuxenPrezioa
        '
        Me.xuxenPrezioa.AutoSize = True
        Me.xuxenPrezioa.Location = New System.Drawing.Point(452, 251)
        Me.xuxenPrezioa.Name = "xuxenPrezioa"
        Me.xuxenPrezioa.Size = New System.Drawing.Size(10, 13)
        Me.xuxenPrezioa.TabIndex = 27
        Me.xuxenPrezioa.Text = "-"
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(549, 506)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 37)
        Me.reset.TabIndex = 28
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'twitter
        '
        Me.twitter.Location = New System.Drawing.Point(12, 506)
        Me.twitter.Name = "twitter"
        Me.twitter.Size = New System.Drawing.Size(89, 37)
        Me.twitter.TabIndex = 30
        Me.twitter.Text = "Twitterren partekatu"
        Me.twitter.UseVisualStyleBackColor = True
        '
        'textua
        '
        Me.textua.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textua.Location = New System.Drawing.Point(12, 354)
        Me.textua.Multiline = True
        Me.textua.Name = "textua"
        Me.textua.ReadOnly = True
        Me.textua.Size = New System.Drawing.Size(612, 146)
        Me.textua.TabIndex = 31
        '
        'musikaGelditu
        '
        Me.musikaGelditu.Location = New System.Drawing.Point(107, 506)
        Me.musikaGelditu.Name = "musikaGelditu"
        Me.musikaGelditu.Size = New System.Drawing.Size(91, 36)
        Me.musikaGelditu.TabIndex = 32
        Me.musikaGelditu.Text = "Musika gelditu"
        Me.musikaGelditu.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 555)
        Me.Controls.Add(Me.musikaGelditu)
        Me.Controls.Add(Me.textua)
        Me.Controls.Add(Me.twitter)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.xuxenPrezioa)
        Me.Controls.Add(Me.xuxenKop)
        Me.Controls.Add(Me.xuxen)
        Me.Controls.Add(Me.filoPrezioa)
        Me.Controls.Add(Me.filoKop)
        Me.Controls.Add(Me.filologoa)
        Me.Controls.Add(Me.idazPrezioa)
        Me.Controls.Add(Me.idazKop)
        Me.Controls.Add(Me.idazmakina)
        Me.Controls.Add(Me.nibela)
        Me.Controls.Add(Me.lvlUp)
        Me.Controls.Add(Me.boligrafoKop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tippexKop)
        Me.Controls.Add(Me.arkatzKop)
        Me.Controls.Add(Me.koplabel)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.boligrafoPrezioa)
        Me.Controls.Add(Me.tippexPrezioa)
        Me.Controls.Add(Me.arkatzPrezioa)
        Me.Controls.Add(Me.prezioak)
        Me.Controls.Add(Me.boligrafo)
        Me.Controls.Add(Me.tippex)
        Me.Controls.Add(Me.ZPS)
        Me.Controls.Add(Me.arkatza)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ZuzenkGuztira)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Window"
        Me.Text = "Ixa Kliker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ZuzenkGuztira As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents arkatza As Button
    Friend WithEvents Eguneraketa As Timer
    Friend WithEvents Segunduro As Timer
    Friend WithEvents ZPS As Label
    Friend WithEvents zuzenketaksegunduko As Timer
    Friend WithEvents tippex As Button
    Friend WithEvents boligrafo As Button
    Friend WithEvents prezioak As Label
    Friend WithEvents arkatzPrezioa As Label
    Friend WithEvents tippexPrezioa As Label
    Friend WithEvents boligrafoPrezioa As Label
    Friend WithEvents text1 As Label
    Friend WithEvents koplabel As Label
    Friend WithEvents arkatzKop As Label
    Friend WithEvents tippexKop As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents boligrafoKop As Label
    Friend WithEvents lvlUp As Button
    Friend WithEvents nibela As Label
    Friend WithEvents idazmakina As Button
    Friend WithEvents idazKop As Label
    Friend WithEvents idazPrezioa As Label
    Friend WithEvents filologoa As Button
    Friend WithEvents filoKop As Label
    Friend WithEvents filoPrezioa As Label
    Friend WithEvents xuxen As Button
    Friend WithEvents xuxenKop As Label
    Friend WithEvents xuxenPrezioa As Label
    Friend WithEvents reset As Button
    Friend WithEvents twitter As Button
    Friend WithEvents textua As TextBox
    Friend WithEvents musikaGelditu As Button
End Class
