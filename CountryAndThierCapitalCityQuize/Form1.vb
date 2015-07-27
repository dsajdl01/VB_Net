Public Class Form1

    Dim Country As String

    Private Sub cmbContinent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbContinent.SelectedIndexChanged
        lstCities.Items.Clear()
        lblCapCity.Text = "What is the capital city of "
        lblOutput.Visible = False
        If cmbContinent.SelectedItem = "Asia" Then
            lstCountries.Items.Clear()
            With lstCountries.Items
                .Add("Cambodia")
                .Add("Vietnam")
                .Add("Japan")
                .Add("Russia")
                .Add("Jordan")
                .Add("Israel")
            End With
        ElseIf cmbContinent.SelectedItem = "Australia, North & Central America" Then
            lstCountries.Items.Clear()
            With lstCountries.Items
                .Add("USA")
                .Add("Mexico")
                .Add("Canada")
                .Add("Australia")
                .Add("Nicaragua")
                .Add("Costa Rica")
            End With
        ElseIf cmbContinent.SelectedItem = "South America" Then
            lstCountries.Items.Clear()
            With lstCountries.Items
                .Add("Colombia")
                .Add("Venesuela")
                .Add("Ecuador")
                .Add("Peru")
                .Add("Argentina")
                .Add("Brazil")
            End With
        ElseIf cmbContinent.SelectedItem = "Afrika" Then
            lstCountries.Items.Clear()
            With lstCountries.Items
                .Add("Egypt")
                .Add("South Africa")
                .Add("Zambie")
                .Add("Kenya")
                .Add("Marocco")
                .Add("Etiopia")
            End With
        ElseIf cmbContinent.SelectedItem = "Europa" Then
            lstCountries.Items.Clear()
            With lstCountries.Items
                .Add("Spain")
                .Add("France")
                .Add("Czech Republic")
                .Add("Poland")
                .Add("Germany")
                .Add("Lithuania")
            End With
        End If
    End Sub

    Private Sub lstCountries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCountries.SelectedIndexChanged
        lblOutput.Visible = False
        btnKlick.Enabled = True
        Country = lstCountries.SelectedItem
        Select Case Country
            Case "Vietnam"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Ho Chi Minh City")
                    .Add("Amman")
                    .Add("Tokyo")
                    .Add("Tel Aviv")
                    .Add("Moscow")
                    .Add("Phnom Penh")
                End With
            Case "Cambodia"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Phnom Penh")
                    .Add("Tel Aviv")
                    .Add("Moscow")
                    .Add("Ho Chi Minh City")
                    .Add("Amman")
                    .Add("Tokyo")
                End With
            Case "Russia"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Ho Chi Minh City")
                    .Add("Tokyo")
                    .Add("Moscow")
                    .Add("Tel Aviv")
                    .Add("Phom Penh")
                    .Add("Amman")
                End With
            Case "Israel"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Tokyo")
                    .Add("Amman")
                    .Add("Moscow")
                    .Add("Phnom Penh")
                    .Add("Ho Chi Minh City")
                    .Add("Tel Aviv")
                End With
            Case "Jordan"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Tokyo")
                    .Add("Moscow")
                    .Add("Phnom Penh")
                    .Add("Ho Chi Minh City")
                    .Add("Amman")
                    .Add("Tel Aviv")
                End With
            Case "Japan"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Ho Chi Minh City")
                    .Add("Tel Aviv")
                    .Add("Moscow")
                    .Add("Amman")
                    .Add("Phnom Penh")
                    .Add("Tokyo")
                End With
            Case "USA"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Mexico City")
                    .Add("Canberra")
                    .Add("Woshington DC")
                    .Add("Ottawa")
                    .Add("Managua")
                    .Add("San Jose")
                End With
            Case "Mexico"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("San Jose")
                    .Add("Managua")
                    .Add("Canberra")
                    .Add("Mexico City")
                    .Add("Ottawa")
                    .Add("Woshington DC")
                End With
            Case "Canada"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Managua")
                    .Add("Woshington DC")
                    .Add("Ottawa")
                    .Add("San Jose")
                    .Add("Canberra")
                    .Add("Mexico City")
                End With
            Case "Australia"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Managua")
                    .Add("Ottawa")
                    .Add("Canberra")
                    .Add("Mecico City")
                    .Add("San Jose")
                    .Add("Woshington DC")
                End With
            Case "Nicaragua"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Woshington DC")
                    .Add("San Jose")
                    .Add("Canberra")
                    .Add("Mexico City")
                    .Add("Ottawa")
                    .Add("Managua")
                End With
            Case "Costa Rica"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Ottawa")
                    .Add("Canberra")
                    .Add("San Jose")
                    .Add("Woshington DC")
                    .Add("Managua")
                    .Add("Mexico City")
                End With
            Case "Colombia"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Caracas")
                    .Add("Quito")
                    .Add("Lima")
                    .Add("Bogota")
                    .Add("Brasilia")
                    .Add("Buenos Aires")
                End With
            Case "Venesuela"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Buenos Aires")
                    .Add("Quito")
                    .Add("Brasilia")
                    .Add("Bogota")
                    .Add("Caracas")
                    .Add("Lima")
                End With
            Case "Ecuador"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Bogota")
                    .Add("Brasilia")
                    .Add("Buenos Aires")
                    .Add("Quito")
                    .Add("Lima")
                    .Add("Caracas")
                End With
            Case "Peru"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Caracas")
                    .Add("Bogota")
                    .Add("Quito")
                    .Add("Buenos Aires")
                    .Add("Lima")
                    .Add("Brasilia")
                End With
            Case "Argentina"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Brasilia")
                    .Add("Buenos Aires")
                    .Add("Lima")
                    .Add("Bogota")
                    .Add("Quito")
                    .Add("Caracas")
                End With
            Case "Brazil"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Buenos Aires")
                    .Add("Brasilia")
                    .Add("Lima")
                    .Add("Caracas")
                    .Add("Bogota")
                    .Add("Quito")
                End With
            Case "Egypt"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Lusaka")
                    .Add("Nairobi")
                    .Add("Addis Ababa")
                    .Add("Rabat")
                    .Add("Cairo")
                    .Add("Cape Town")
                End With
            Case "South Africa"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Nairobi")
                    .Add("Rabat")
                    .Add("Cape Town")
                    .Add("Addis Ababa")
                    .Add("Lusaca")
                    .Add("Cairo")
                End With
            Case "Zambie"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Addis Ababa")
                    .Add("Cairo")
                    .Add("Nairobi")
                    .Add("Lusaca")
                    .Add("Rabat")
                    .Add("Cape Town")
                End With
            Case "Kenya"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Rabat")
                    .Add("Cairo")
                    .Add("Cape Town")
                    .Add("Addis Ababa")
                    .Add("Lusaka")
                    .Add("Nairobi")
                End With
            Case "Marocco"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Cape Town")
                    .Add("Rabat")
                    .Add("Nairobi")
                    .Add("Lusaka")
                    .Add("Cairo")
                    .Add("Addis Ababa")
                End With
            Case "Etiopia"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Lusaka")
                    .Add("Cape Town")
                    .Add("Cairo")
                    .Add("Rabat")
                    .Add("Nairobi")
                    .Add("Addis Ababa")
                End With
            Case "Spain"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Paris")
                    .Add("Prague")
                    .Add("Vilnius")
                    .Add("Warsaw")
                    .Add("Berlin")
                    .Add("Madrid")
                End With
            Case "France"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Paris")
                    .Add("Warsaw")
                    .Add("Berlin")
                    .Add("Vilnius")
                    .Add("Madrid")
                    .Add("Prague")
                End With
            Case "Czech Republic"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Warsaw")
                    .Add("Prague")
                    .Add("Berlin")
                    .Add("Berlin")
                    .Add("Vilnius")
                    .Add("Paris")
                End With
            Case "Poland"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Prague")
                    .Add("Madrid")
                    .Add("Paris")
                    .Add("Vilnius")
                    .Add("Warsaw")
                    .Add("Berlin")
                End With
            Case "Germany"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Madrid")
                    .Add("Vilnius")
                    .Add("Berlin")
                    .Add("Warsaw")
                    .Add("Paris")
                    .Add("Prague")
                End With
            Case "Lithuania"
                lstCities.Items.Clear()
                With lstCities.Items
                    .Add("Berlin")
                    .Add("Prague")
                    .Add("Madrid")
                    .Add("Warsaw")
                    .Add("Vilnius")
                    .Add("Paris")
                End With
        End Select
        lblTest.Text = Country
        lblCapCity.Text = "What is the capital city of " & vbNewLine & Country & "?"

    End Sub

    Private Sub lstCities_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCities.SelectedIndexChanged
        Dim SelCity As String
        'btnKlick.Enabled = True
        lblOutput.Visible = False
        SelCity = lstCities.SelectedItem
        lblCity.Text = SelCity
    End Sub

    Private Sub btnKlick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKlick.Click
        Dim City As String
        Static Right, Wrong, Total As Integer
        lblOutput.Visible = False
        City = lstCities.SelectedItem
        btnKlick.Enabled = False
        If lstCountries.SelectedItem = "Vietnam" Then
            If City = "Ho Chi Minh City" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Cambodia" Then
            If City = "Phnom Penh" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Japan" Then
            If City = "Tokyo" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Russia" Then
            If City = "Moscow" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Jordan" Then
            If City = "Amman" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Israel" Then
            If City = "Tel Aviv" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "USA" Then
            If City = "Woshington DC" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Mexico" Then
            If City = "Mexico City" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Canada" Then
            If City = "Ottawa" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Australia" Then
            If City = "Canberra" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Nicaragua" Then
            If City = "Managua" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Costa Rica" Then
            If City = "San Jose" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Colombia" Then
            If City = "Bogota" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Venesuela" Then
            If City = "Caracas" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Ecuador" Then
            If City = "Quito" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Peru" Then
            If City = "Lima" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Argentina" Then
            If City = "Buenos Aires" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Brazil" Then
            If City = "Brasilia" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Egypt" Then
            If City = "Cairo" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "South Africa" Then
            If City = "Cape Town" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Zambie" Then
            If City = "Lusaca" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Kenya" Then
            If City = "Nairobi" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Marocco" Then
            If City = "Rabat" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Etiopia" Then
            If City = "Addis Ababa" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Spain" Then
            If City = "Madrid" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "France" Then
            If City = "Paris" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Czech Republic" Then
            If City = "Prague" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Poland" Then
            If City = "Warsaw" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Germany" Then
            If City = "Berlin" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        ElseIf lstCountries.SelectedItem = "Lithuania" Then
            If City = "Vilnius" Then
                lblOutput.Visible = True
                Right += 1
                lblOutput.Text = "Yes, it is correct answer. " & vbNewLine & City & " is capital city of " & Country
            Else
                Wrong += 1
                MsgBox("Wrong! Your answer is incorrect", , "Countries and Cities incorrect answer")
            End If
        End If
        lblCorect.Text = Right
        lblIncorrect.Text = Wrong
        Total = Right + Wrong
        lblPerc.Text = Format((Right / Total), "0.0%")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, "Are you sure that you want to exit?", "Exit message", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
