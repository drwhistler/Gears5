Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        TextBox_ArcadeWin.Text = record(0)
        TextBox_ArcadeLoss.Text = record(1)

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\mvp.txt")
        line = rdr.ReadLine()
        rdr.Close()

        record = line.Split(","c)
        TextBox_MVP.Text = record(0)

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt")
        line = rdr.ReadLine()
        rdr.Close()

        record = line.Split(","c)
        TextBox_GridironWin.Text = record(0)
        TextBox_GridironLoss.Text = record(1)

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt")
        line = rdr.ReadLine()
        rdr.Close()

        record = line.Split(","c)
        TextBox_HordeWin.Text = record(0)
        TextBox_HordeLoss.Text = record(1)

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt")
        line = rdr.ReadLine()
        rdr.Close()

        record = line.Split(","c)
        TextBox_EscapeWin.Text = record(0)
        TextBox_EscapeLoss.Text = record(1)

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt")
        line = rdr.ReadLine()
        rdr.Close()

        record = line.Split(","c)
        TextBox_RankedTDMWin.Text = record(0)
        TextBox_RankedTDMLoss.Text = record(1)

        rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt")
        line = rdr.ReadLine()
        rdr.Close()

        record = line.Split(","c)
        TextBox_RankedKOTHWin.Text = record(0)
        TextBox_RankedKOTHLoss.Text = record(1)
    End Sub

    Private Sub Button_ResetAll_Click(sender As Object, e As EventArgs) Handles Button_ResetAll.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\mvp.txt", "0")

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade_slobs.txt", "0 / 0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron_slobs.txt", "0 / 0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch_slobs.txt", "0 / 0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill_slobs.txt", "0 / 0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape_slobs.txt", "0 / 0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy_slobs.txt", "0 / 0")

        TextBox_MVP.Text = "0"
        TextBox_ArcadeWin.Text = "0"
        TextBox_ArcadeLoss.Text = "0"
        TextBox_GridironWin.Text = "0"
        TextBox_GridironLoss.Text = "0"
        TextBox_RankedTDMWin.Text = "0"
        TextBox_RankedTDMLoss.Text = "0"
        TextBox_RankedKOTHWin.Text = "0"
        TextBox_RankedKOTHLoss.Text = "0"
        TextBox_EscapeWin.Text = "0"
        TextBox_EscapeLoss.Text = "0"
        TextBox_HordeWin.Text = "0"
        TextBox_HordeLoss.Text = "0"

    End Sub

    Private Sub Button_ResetArcade_Click(sender As Object, e As EventArgs) Handles Button_ResetArcade.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade_slobs.txt", "0 / 0")
        TextBox_ArcadeLoss.Text = "0"
        TextBox_ArcadeWin.Text = "0"
    End Sub

    Private Sub Button_ResetGridiron_Click(sender As Object, e As EventArgs) Handles Button_ResetGridiron.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron_slobs.txt", "0 / 0")
        TextBox_GridironLoss.Text = "0"
        TextBox_GridironWin.Text = "0"
    End Sub

    Private Sub Button_ResetTDM_Click(sender As Object, e As EventArgs) Handles Button_ResetTDM.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch_slobs.txt", "0 / 0")
        TextBox_RankedTDMLoss.Text = "0"
        TextBox_RankedTDMWin.Text = "0"
    End Sub

    Private Sub Button_ResetKOTH_Click(sender As Object, e As EventArgs) Handles Button_ResetKOTH.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill_slobs.txt", "0 / 0")
        TextBox_RankedKOTHLoss.Text = "0"
        TextBox_RankedKOTHWin.Text = "0"
    End Sub

    Private Sub Button_ResetEscape_Click(sender As Object, e As EventArgs) Handles Button_ResetEscape.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape_slobs.txt", "0 / 0")
        TextBox_EscapeLoss.Text = "0"
        TextBox_EscapeWin.Text = "0"
    End Sub

    Private Sub Button_ResetHorde_Click(sender As Object, e As EventArgs) Handles Button_ResetHorde.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt", "0,0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy_slobs.txt", "0 / 0")
        TextBox_HordeLoss.Text = "0"
        TextBox_HordeWin.Text = "0"
    End Sub

    Private Sub Button_AracdeIW_Click(sender As Object, e As EventArgs) Handles Button_AracdeIW.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0) + 1
        Dim loss As String = record(1)

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade_slobs.txt", win + " / " + loss)

        TextBox_ArcadeWin.Text = win
        TextBox_ArcadeLoss.Text = loss
    End Sub

    Private Sub Button_ArcadeIL_Click(sender As Object, e As EventArgs) Handles Button_ArcadeIL.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0)
        Dim loss As String = record(1) + 1

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\arcade_slobs.txt", win + " / " + loss)

        TextBox_ArcadeWin.Text = win
        TextBox_ArcadeLoss.Text = loss
    End Sub

    Private Sub Button_GridironIW_Click(sender As Object, e As EventArgs) Handles Button_GridironIW.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0) + 1
        Dim loss As String = record(1)

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron_slobs.txt", win + " / " + loss)

        TextBox_GridironWin.Text = win
        TextBox_GridironLoss.Text = loss
    End Sub
    Private Sub Button_GridironIL_Click(sender As Object, e As EventArgs) Handles Button_GridironIL.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0)
        Dim loss As String = record(1) + 1

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\gridiron_slobs.txt", win + " / " + loss)

        TextBox_GridironWin.Text = win
        TextBox_GridironLoss.Text = loss
    End Sub

    Private Sub Button_TDMIW_Click(sender As Object, e As EventArgs) Handles Button_TDMIW.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0) + 1
        Dim loss As String = record(1)

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch_slobs.txt", win + " / " + loss)

        TextBox_RankedTDMWin.Text = win
        TextBox_RankedTDMLoss.Text = loss
    End Sub

    Private Sub Button_TDMIL_Click(sender As Object, e As EventArgs) Handles Button_TDMIL.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0)
        Dim loss As String = record(1) + 1

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\teamdeathmatch_slobs.txt", win + " / " + loss)

        TextBox_RankedTDMWin.Text = win
        TextBox_RankedTDMLoss.Text = loss
    End Sub

    Private Sub Button_KOTHIW_Click(sender As Object, e As EventArgs) Handles Button_KOTHIW.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0) + 1
        Dim loss As String = record(1)

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill_slobs.txt", win + " / " + loss)

        TextBox_RankedKOTHWin.Text = win
        TextBox_RankedKOTHLoss.Text = loss
    End Sub

    Private Sub Button_KOTHIL_Click(sender As Object, e As EventArgs) Handles Button_KOTHIL.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0)
        Dim loss As String = record(1) + 1

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\kingofthehill_slobs.txt", win + " / " + loss)

        TextBox_RankedKOTHWin.Text = win
        TextBox_RankedKOTHLoss.Text = loss
    End Sub

    Private Sub Button_EscapeIW_Click(sender As Object, e As EventArgs) Handles Button_EscapeIW.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0) + 1
        Dim loss As String = record(1)

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape_slobs.txt", win + " / " + loss)

        TextBox_EscapeWin.Text = win
        TextBox_EscapeLoss.Text = loss
    End Sub

    Private Sub Button_EscapeIL_Click(sender As Object, e As EventArgs) Handles Button_EscapeIL.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0)
        Dim loss As String = record(1) + 1

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\escape_slobs.txt", win + " / " + loss)

        TextBox_EscapeWin.Text = win
        TextBox_EscapeLoss.Text = loss
    End Sub

    Private Sub Button_HordeIW_Click(sender As Object, e As EventArgs) Handles Button_HordeIW.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0) + 1
        Dim loss As String = record(1)

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy_slobs.txt", win + " / " + loss)

        TextBox_HordeWin.Text = win
        TextBox_HordeLoss.Text = loss
    End Sub

    Private Sub Button_HordeIL_Click(sender As Object, e As EventArgs) Handles Button_HordeIL.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim record As String() = line.Split(","c)
        Dim win As String = record(0)
        Dim loss As String = record(1) + 1

        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy.txt", win + "," + loss)
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordefrenzy_slobs.txt", win + " / " + loss)

        TextBox_HordeWin.Text = win
        TextBox_HordeLoss.Text = loss
    End Sub

    Private Sub Button_MVP_Click(sender As Object, e As EventArgs) Handles Button_MVP.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\mvp.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        line = line + 1
        TextBox_MVP.Text = line
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\mvp.txt", line)
    End Sub

    Private Sub Button_MVPWhistler_Click(sender As Object, e As EventArgs) Handles Button_MVPWhistler.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpwhistler.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        line = line + 1
        TextBox_MVPWhistler.Text = line
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpwhistler.txt", line)
    End Sub

    Private Sub Button_MVPDanVincent_Click(sender As Object, e As EventArgs) Handles Button_MVPDanVincent.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpdanvincent.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        line = line + 1
        TextBox_MVPDanVincent.Text = line
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpdanvincent.txt", line)
    End Sub

    Private Sub Button_MVPFatalpoison_Click(sender As Object, e As EventArgs) Handles Button_MVPFatalpoison.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpfatalpoison.txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        line = line + 1
        TextBox_MVPFatalPoison.Text = line
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpfatalpoison.txt", line)
    End Sub

    Private Sub Button_ResetMVPWhistler_Click(sender As Object, e As EventArgs) Handles Button_ResetMVPWhistler.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpwhistler.txt", "0")
        TextBox_MVPWhistler.Text = "0"
    End Sub

    Private Sub Button_ResetMVPDanVincent_Click(sender As Object, e As EventArgs) Handles Button_ResetMVPDanVincent.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpdanvincent.txt", "0")
        TextBox_MVPDanVincent.Text = "0"
    End Sub

    Private Sub Button_ResetMVPFatalPoison_Click(sender As Object, e As EventArgs) Handles Button_ResetMVPFatalPoison.Click
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\Gears5\hordemvpfatalpoison.txt", "0")
        TextBox_MVPFatalPoison.Text = "0"
    End Sub
End Class
