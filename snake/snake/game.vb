Public Class game

    Public kup As Boolean
    Public kdown As Boolean
    Public kleft As Boolean
    Public kright As Boolean
    Public xpos As Integer
    Public ypos As Integer
    Public posx(45) As Integer
    Public posy(45) As Integer
    Public vis(45) As Integer
    Public age As Integer
    Public food_timer As Integer
    Public key_pressed As Boolean
    Public bar_x(29) As Integer
    Public bar_y(29) As Integer
    Public crashed As Boolean
    Public level As Integer

    'done
    Function set_bar_positions()

        bar_x(0) = delocateX(bar1.Left)
        bar_y(0) = delocateY(bar1.Top)
        bar_x(1) = delocateX(bar2.Left)
        bar_y(1) = delocateY(bar2.Top)
        bar_x(2) = delocateX(bar3.Left)
        bar_y(2) = delocateY(bar3.Top)
        bar_x(3) = delocateX(bar4.Left)
        bar_y(3) = delocateY(bar4.Top)
        bar_x(4) = delocateX(bar5.Left)
        bar_y(4) = delocateY(bar5.Top)
        bar_x(5) = delocateX(bar6.Left)
        bar_y(5) = delocateY(bar6.Top)
        bar_x(6) = delocateX(bar7.Left)
        bar_y(6) = delocateY(bar7.Top)
        bar_x(7) = delocateX(bar8.Left)
        bar_y(7) = delocateY(bar8.Top)
        bar_x(8) = delocateX(bar9.Left)
        bar_y(8) = delocateY(bar9.Top)
        bar_x(9) = delocateX(bar10.Left)
        bar_y(9) = delocateY(bar10.Top)
        bar_x(10) = delocateX(bar11.Left)
        bar_y(10) = delocateY(bar11.Top)
        bar_x(11) = delocateX(bar12.Left)
        bar_y(11) = delocateY(bar12.Top)
        bar_x(12) = delocateX(bar13.Left)
        bar_y(12) = delocateY(bar13.Top)
        bar_x(13) = delocateX(bar14.Left)
        bar_y(13) = delocateY(bar14.Top)
        bar_x(14) = delocateX(bar15.Left)
        bar_y(14) = delocateY(bar15.Top)
        bar_x(15) = delocateX(bar16.Left)
        bar_y(15) = delocateY(bar16.Top)
        bar_x(16) = delocateX(bar17.Left)
        bar_y(16) = delocateY(bar17.Top)
        bar_x(17) = delocateX(bar18.Left)
        bar_y(17) = delocateY(bar18.Top)
        bar_x(18) = delocateX(bar19.Left)
        bar_y(18) = delocateY(bar19.Top)
        bar_x(19) = delocateX(bar20.Left)
        bar_y(19) = delocateY(bar20.Top)
        bar_x(20) = delocateX(bar21.Left)
        bar_y(20) = delocateY(bar21.Top)
        bar_x(21) = delocateX(bar22.Left)
        bar_y(21) = delocateY(bar22.Top)
        bar_x(22) = delocateX(bar23.Left)
        bar_y(22) = delocateY(bar23.Top)
        bar_x(23) = delocateX(bar24.Left)
        bar_y(23) = delocateY(bar24.Top)
        bar_x(24) = delocateX(bar25.Left)
        bar_y(24) = delocateY(bar25.Top)
        bar_x(25) = delocateX(bar26.Left)
        bar_y(25) = delocateY(bar26.Top)
        bar_x(26) = delocateX(bar27.Left)
        bar_y(26) = delocateY(bar27.Top)
        bar_x(27) = delocateX(bar28.Left)
        bar_y(27) = delocateY(bar28.Top)
        bar_x(28) = delocateX(bar29.Left)
        bar_y(28) = delocateY(bar29.Top)
        bar_x(29) = delocateX(bar30.Left)
        bar_y(29) = delocateY(bar30.Top)

    End Function
    'done
    Function Set_SnakeNextPosition()

        For i = 0 To 44
            posx(45 - i) = posx(44 - i)
            posy(45 - i) = posy(44 - i)
        Next
        posx(0) = xpos
        posy(0) = ypos

    End Function
    'done
    Function checkborder()

        If xpos = -1 And kleft = True Then
            xpos = 19
        End If

        If xpos = 20 And kright = True Then
            xpos = 0
        End If

        If ypos = -1 And kdown = True Then
            ypos = 19
        End If

        If ypos = 20 And kup = True Then
            ypos = 0
        End If

    End Function
    'done
    Function Snake_makestep()

        If car21.Visible = True Then
            car21.Location = locate(posx(21), posy(21))
        End If
        If car22.Visible = True Then
            car22.Location = locate(posx(22), posy(22))
        End If
        If car23.Visible = True Then
            car23.Location = locate(posx(23), posy(23))
        End If
        If car24.Visible = True Then
            car24.Location = locate(posx(24), posy(24))
        End If
        If car25.Visible = True Then
            car25.Location = locate(posx(25), posy(25))
        End If
        If car26.Visible = True Then
            car26.Location = locate(posx(26), posy(26))
        End If
        If car27.Visible = True Then
            car27.Location = locate(posx(27), posy(27))
        End If
        If car28.Visible = True Then
            car28.Location = locate(posx(28), posy(28))
        End If
        If car29.Visible = True Then
            car29.Location = locate(posx(29), posy(29))
        End If
        If car30.Visible = True Then
            car30.Location = locate(posx(30), posy(30))
        End If

        '##############################

        If car11.Visible = True Then
            car11.Location = locate(posx(11), posy(11))
        End If
        If car12.Visible = True Then
            car12.Location = locate(posx(12), posy(12))
        End If
        If car13.Visible = True Then
            car13.Location = locate(posx(13), posy(13))
        End If
        If car14.Visible = True Then
            car14.Location = locate(posx(14), posy(14))
        End If
        If car15.Visible = True Then
            car15.Location = locate(posx(15), posy(15))
        End If
        If car16.Visible = True Then
            car16.Location = locate(posx(16), posy(16))
        End If
        If car17.Visible = True Then
            car17.Location = locate(posx(17), posy(17))
        End If
        If car18.Visible = True Then
            car18.Location = locate(posx(18), posy(18))
        End If
        If car19.Visible = True Then
            car19.Location = locate(posx(19), posy(19))
        End If
        If car20.Visible = True Then
            car20.Location = locate(posx(20), posy(20))
        End If

        '#############################

        maincar.Location = locate(xpos, ypos)
        car0.Location = locate(posx(0), posy(0))
        car1.Location = locate(posx(1), posy(1))
        If car2.Visible = True Then
            car2.Location = locate(posx(2), posy(2))
        End If
        If car3.Visible = True Then
            car3.Location = locate(posx(3), posy(3))
        End If
        If car4.Visible = True Then
            car4.Location = locate(posx(4), posy(4))
        End If
        If car5.Visible = True Then
            car5.Location = locate(posx(5), posy(5))
        End If
        If car6.Visible = True Then
            car6.Location = locate(posx(6), posy(6))
        End If
        If car7.Visible = True Then
            car7.Location = locate(posx(7), posy(7))
        End If
        If car8.Visible = True Then
            car8.Location = locate(posx(8), posy(8))
        End If
        If car9.Visible = True Then
            car9.Location = locate(posx(9), posy(9))
        End If
        If car10.Visible = True Then
            car10.Location = locate(posx(10), posy(10))
        End If

        ' the same from 31 to 45 ###

    End Function
    'done
    Function locate(ByVal x As Integer, ByVal y As Integer) As Point

        Dim p As Point
        p.X = 15 * x
        p.Y = 285 - 15 * y
        Return p

    End Function
    'done
    Function delocateX(ByVal x As Integer) As Integer
        Return (x / 15)
    End Function
    'done
    Function delocateY(ByVal y As Integer) As Integer
        Return ((285 - y) / 15)
    End Function
    'done
    Function check_crash() As Boolean

        For i = 0 To 29
            If (xpos = bar_x(i)) And (ypos = bar_y(i)) Then
                Timer1.Stop()
                Return True
                GoTo x
            End If
        Next

        For i = 0 To 30
            If (xpos = posx(i)) And (ypos = posy(i)) And (vis(i) = 1) Then
                hide_cars(i)
                Exit For
            End If
        Next
        Return False
x:
    End Function
    'done
    Function hide_cars(ByVal car_crashed As Integer)

        Dim farpoint As Point
        farpoint.X = 500
        farpoint.Y = 500


        If car_crashed <= 30 Then
            car30.Location = farpoint
            car30.Visible = False
            vis(30) = 0
            age = 29
        End If
        If car_crashed <= 29 Then
            car29.Location = farpoint
            car29.Visible = False
            vis(29) = 0
            age = 28
        End If
        If car_crashed <= 28 Then
            car28.Location = farpoint
            car28.Visible = False
            vis(28) = 0
            age = 27
        End If
        If car_crashed <= 27 Then
            car27.Location = farpoint
            car27.Visible = False
            vis(27) = 0
            age = 26
        End If
        If car_crashed <= 26 Then
            car26.Location = farpoint
            car26.Visible = False
            vis(26) = 0
            age = 25
        End If
        If car_crashed <= 25 Then
            car25.Location = farpoint
            car25.Visible = False
            vis(25) = 0
            age = 24
        End If
        If car_crashed <= 24 Then
            car24.Location = farpoint
            car24.Visible = False
            vis(24) = 0
            age = 23
        End If
        If car_crashed <= 23 Then
            car23.Location = farpoint
            car23.Visible = False
            vis(23) = 0
            age = 22
        End If
        If car_crashed <= 22 Then
            car22.Location = farpoint
            car22.Visible = False
            vis(22) = 0
            age = 21
        End If
        If car_crashed <= 21 Then
            car21.Location = farpoint
            car21.Visible = False
            vis(21) = 0
            age = 20
        End If
        If car_crashed <= 20 Then
            car20.Location = farpoint
            car20.Visible = False
            vis(20) = 0
            age = 19
        End If
        If car_crashed <= 19 Then
            car19.Location = farpoint
            car19.Visible = False
            vis(19) = 0
            age = 18
        End If
        If car_crashed <= 18 Then
            car18.Location = farpoint
            car18.Visible = False
            vis(18) = 0
            age = 17
        End If
        If car_crashed <= 17 Then
            car17.Location = farpoint
            car17.Visible = False
            vis(17) = 0
            age = 16
        End If
        If car_crashed <= 16 Then
            car16.Location = farpoint
            car16.Visible = False
            vis(16) = 0
            age = 15
        End If
        If car_crashed <= 15 Then
            car15.Location = farpoint
            car15.Visible = False
            vis(15) = 0
            age = 14
        End If
        If car_crashed <= 14 Then
            car14.Location = farpoint
            car14.Visible = False
            vis(14) = 0
            age = 13
        End If
        If car_crashed <= 13 Then
            car13.Location = farpoint
            car13.Visible = False
            vis(13) = 0
            age = 12
        End If
        If car_crashed <= 12 Then
            car12.Location = farpoint
            car12.Visible = False
            vis(12) = 0
            age = 11
        End If
        If car_crashed <= 11 Then
            car11.Location = farpoint
            car11.Visible = False
            vis(11) = 0
            age = 10
        End If
        If car_crashed <= 10 Then
            car10.Location = farpoint
            car10.Visible = False
            vis(10) = 0
            age = 9
        End If
        If car_crashed <= 9 Then
            car9.Location = farpoint
            car9.Visible = False
            vis(9) = 0
            age = 8
        End If
        If car_crashed <= 8 Then
            car8.Location = farpoint
            car8.Visible = False
            vis(8) = 0
            age = 7
        End If
        If car_crashed <= 7 Then
            car7.Location = farpoint
            car7.Visible = False
            vis(7) = 0
            age = 6
        End If
        If car_crashed <= 6 Then
            car6.Location = farpoint
            car6.Visible = False
            vis(6) = 0
            age = 5
        End If
        If car_crashed <= 5 Then
            car5.Location = farpoint
            car5.Visible = False
            vis(5) = 0
            age = 4
        End If
        If car_crashed <= 4 Then
            car4.Location = farpoint
            car4.Visible = False
            vis(4) = 0
            age = 3
        End If
        If car_crashed <= 3 Then
            car3.Location = farpoint
            car3.Visible = False
            vis(3) = 0
            age = 2
        End If
        If car_crashed <= 2 Then
            car2.Location = farpoint
            car2.Visible = False
            vis(2) = 0
            age = 1
        End If

    End Function
    'done
    Function Grow_Snake(ByVal age As Integer)

        If age = 2 Then
            car2.Visible = True
            vis(2) = 1
        ElseIf age = 3 Then
            car3.Visible = True
            vis(3) = 1
        ElseIf age = 4 Then
            car4.Visible = True
            vis(4) = 1
        ElseIf age = 5 Then
            car5.Visible = True
            vis(5) = 1
        ElseIf age = 6 Then
            car6.Visible = True
            vis(6) = 1
        ElseIf age = 7 Then
            car7.Visible = True
            vis(7) = 1
        ElseIf age = 8 Then
            car8.Visible = True
            vis(8) = 1
        ElseIf age = 9 Then
            car9.Visible = True
            vis(9) = 1
        ElseIf age = 10 Then
            car10.Visible = True
            vis(10) = 1
        ElseIf age = 11 Then
            car11.Visible = True
            vis(11) = 1
        ElseIf age = 12 Then
            car12.Visible = True
            vis(12) = 1
        ElseIf age = 13 Then
            car13.Visible = True
            vis(13) = 1
        ElseIf age = 14 Then
            car14.Visible = True
            vis(14) = 1
        ElseIf age = 15 Then
            car15.Visible = True
            vis(15) = 1
        ElseIf age = 16 Then
            car16.Visible = True
            vis(16) = 1
        ElseIf age = 17 Then
            car17.Visible = True
            vis(17) = 1
        ElseIf age = 18 Then
            car18.Visible = True
            vis(18) = 1
        ElseIf age = 19 Then
            car19.Visible = True
            vis(19) = 1
        ElseIf age = 20 Then
            car20.Visible = True
            vis(20) = 1
        ElseIf age = 21 Then
            car21.Visible = True
            vis(21) = 1
        ElseIf age = 22 Then
            car22.Visible = True
            vis(22) = 1
        ElseIf age = 23 Then
            car23.Visible = True
            vis(23) = 1
        ElseIf age = 24 Then
            car24.Visible = True
            vis(24) = 1
        ElseIf age = 25 Then
            car25.Visible = True
            vis(25) = 1
        ElseIf age = 26 Then
            car26.Visible = True
            vis(26) = 1
        ElseIf age = 27 Then
            car27.Visible = True
            vis(27) = 1
        ElseIf age = 28 Then
            car28.Visible = True
            vis(28) = 1
        ElseIf age = 29 Then
            car29.Visible = True
            vis(29) = 1
        ElseIf age = 30 Then
            car30.Visible = True
            vis(30) = 1
        End If

        ' the same from 31 to 45

    End Function
    'done
    Function setFood()

        Randomize()
        Dim foodPoint As Point
rndx:   foodPoint.X = Int(19 * Rnd())
        foodPoint.Y = Int(19 * Rnd())
        For i = 0 To 29
            If ((foodPoint.X = posx(i)) And (foodPoint.Y = posy(i)) And (vis(i) = 1)) Or (foodPoint.X = bar_x(i) And foodPoint.Y = bar_y(i)) Then
                GoTo rndx
            End If
        Next
        food.Location = locate(foodPoint.X, foodPoint.Y)
        food.Visible = True

    End Function

    'done
    Private Sub game_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    'done
    Private Sub game_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If (e.KeyCode = Keys.Up) And (kdown = False) And (key_pressed = False) Then
            kup = True
            kdown = False
            kright = False
            kleft = False
            key_pressed = True
        End If

        If e.KeyCode = Keys.Down And (kup = False) And (key_pressed = False) Then
            kup = False
            kdown = True
            kright = False
            kleft = False
            key_pressed = True
        End If

        If e.KeyCode = Keys.Left And (kright = False) And (key_pressed = False) Then
            kup = False
            kdown = False
            kright = False
            kleft = True
            key_pressed = True
        End If

        If e.KeyCode = Keys.Right And (kleft = False) And (key_pressed = False) Then
            kup = False
            kdown = False
            kright = True
            kleft = False
            key_pressed = True
        End If

        If e.KeyCode = Keys.P Then
            If Timer1.Enabled = True Then
                Timer1.Stop()
            Else
                Timer1.Start()
            End If
        End If

    End Sub
    'done
    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form1.Hide()
        kup = False
        kdown = False
        kright = False
        kleft = True
        posx(0) = 16
        posy(0) = 1
        posx(1) = 17
        posy(1) = 1
        xpos = 15
        ypos = 1
        food.Left = 150
        food.Top = 150
        age = 1
        vis(0) = 1
        vis(1) = 1
        For i = 2 To 45
            vis(i) = 0
        Next
        maincar.Location = locate(xpos, ypos)
        car0.Location = locate(posx(0), posy(0))
        car1.Location = locate(posx(1), posy(1))
        set_bar_positions()
        Timer1.Start()
        crashed = False

    End Sub
    'done
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Set_SnakeNextPosition()

        If kup = True Then
            ypos += 1
            maincar.Image = My.Resources.up
            key_pressed = False
        ElseIf kdown = True Then
            ypos -= 1
            maincar.Image = My.Resources.down
            key_pressed = False
        ElseIf kleft = True Then
            xpos -= 1
            maincar.Image = My.Resources.left
            key_pressed = False
        ElseIf kright = True Then
            xpos += 1
            maincar.Image = My.Resources.right
            key_pressed = False
        End If

        checkborder()
        crashed = check_crash()
        If crashed = True Then
            Dim response As Integer
            response = MessageBox.Show("Crashed Do you want to play again ??", "Mission Failed", MessageBoxButtons.YesNo)
            If response = vbYes Then
                ' make separate function
                kup = False
                kdown = False
                kright = False
                kleft = True
                posx(0) = 16
                posy(0) = 1
                posx(1) = 17
                posy(1) = 1
                xpos = 15
                ypos = 1
                food.Left = 150
                food.Top = 150
                age = 1
                hide_cars(2)
                vis(0) = 1
                vis(1) = 1
                For i = 2 To 45
                    vis(i) = 0
                Next
                maincar.Location = locate(xpos, ypos)
                car0.Location = locate(posx(0), posy(0))
                car1.Location = locate(posx(1), posy(1))
                set_bar_positions()
                Timer1.Start()
                crashed = False
            Else
                End
            End If
        Else
            Snake_makestep()
        End If


        If (maincar.Location = food.Location) And (food.Visible = True) Then
            food.Visible = False
            food_timer = 2
            timerfood.Start()
            age += 1
            If age <= 30 Then
                Grow_Snake(age)
            End If
        End If

        Me.Text = "Poto World ^_^ ...  " & (age + 1)

    End Sub
    'done
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerfood.Tick

        food_timer -= 1
        If food_timer = 0 Then
            timerfood.Stop()
            setFood()
        End If

    End Sub

End Class